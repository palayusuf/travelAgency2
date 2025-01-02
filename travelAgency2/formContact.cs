using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace travelAgency2
{
    public partial class formContact : Form
    {
        private int id;
        private string page;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private string connectionString = "server=.;database=TravelAgency;integrated security=true;TrustServerCertificate=True";
        public formContact(int _id, string _page)
        {
            id = _id;
            InitializeComponent();
            page = _page;
        }

        private void GetAllTravelList()
        {
            cmbBoxTravels.Items.Clear();

            string query = "SELECT DATENAME(MONTH, StartDate) AS MonthName, YEAR(StartDate) AS Year, Id, StartDate, EndDate, Name, Price FROM VacationTypeInformations ORDER BY StartDate";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        string currentGroup = null;

                        while (reader.Read())
                        {
                            string monthName = reader["MonthName"].ToString();
                            string year = reader["Year"].ToString();
                            string name = reader["Name"].ToString();
                            string price = reader["Price"].ToString();
                            string startDate = Convert.ToDateTime(reader["StartDate"]).ToString("d MMMM yyyy");
                            string endDate = Convert.ToDateTime(reader["EndDate"]).ToString("d MMMM yyyy");
                            int id = Convert.ToInt32(reader["Id"].ToString());

                            string groupHeader = $"{monthName} {year}";
                            if (groupHeader != currentGroup)
                            {
                                cmbBoxTravels.Items.Add(groupHeader);
                                currentGroup = groupHeader;
                            }

                            string itemText = $"   {name} ({startDate} - {endDate})";
                            var comboBoxItem = new ComboBoxItem
                            {
                                Text = itemText,
                                Value = new { ID = id, Price = price, StartDate = startDate, EndDate = endDate }
                            };

                            cmbBoxTravels.Items.Add(comboBoxItem);
                        }
                    }
                }
            }

            cmbBoxTravels.DisplayMember = "Text";
            cmbBoxTravels.ValueMember = "Value";
        }

        private class ComboBoxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void formContact_Load(object sender, EventArgs e)
        {
            GetAllTravelList();
        }

        private void formContact_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void cmbBoxTravels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxTravels.SelectedItem != null)
            {
                if (cmbBoxTravels.SelectedItem.ToString() != "January 2025" &&
                    cmbBoxTravels.SelectedItem.ToString() != "February 2025" &&
                    cmbBoxTravels.SelectedItem.ToString() != "March 2025" &&
                    cmbBoxTravels.SelectedItem.ToString() != "April 2025" &&
                    cmbBoxTravels.SelectedItem.ToString() != "May 2025" &&
                    cmbBoxTravels.SelectedItem.ToString() != "June 2025" &&
                    cmbBoxTravels.SelectedItem.ToString() != "July 2025" &&
                    cmbBoxTravels.SelectedItem.ToString() != "August 2025" &&
                    cmbBoxTravels.SelectedItem.ToString() != "September 2025")
                {
                    dynamic selectedItem = cmbBoxTravels.SelectedItem;

                    int id = Convert.ToInt32(selectedItem.Value.ID);
                    string price = selectedItem.Value.Price;
                    string startDate = selectedItem.Value.StartDate;
                    string endDate = selectedItem.Value.EndDate;

                    panelInfermations.Visible = true;
                    lblStartDate.Text = startDate;
                    lblEndDate.Text = endDate;
                    lblPrice.Text = price;
                    int money = Convert.ToInt32(lblPrice.Text.Split(' ')[0]);
                    string paraBirimi = lblPrice.Text.Split(' ')[1];
                    if (comboBoxPerson.SelectedItem != null)
                    {
                        int personNumber = Convert.ToInt32(comboBoxPerson.SelectedItem.ToString().Split(' ')[0]);
                        Hesapla(personNumber, money, paraBirimi);
                    }
                    return;
                }
                cmbBoxTravels.SelectedIndex = -1;
                return;
            }
            else
            {
                panelInfermations.Visible = false;
            }
        }

        private void comboBoxPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPerson.SelectedItem != null)
            {
                int personNumber = Convert.ToInt32(comboBoxPerson.SelectedItem.ToString().Split(' ')[0]);
                lblJoiner.Text = personNumber.ToString();
                int money = Convert.ToInt32(lblPrice.Text.Split(' ')[0]);
                string paraBirimi = lblPrice.Text.Split(' ')[1];
                Hesapla(personNumber, money, paraBirimi);
                return;
            }
        }

        private void Hesapla(int? personNumber, int price, string paraBirimi)
        {
            if (personNumber != null && price != null && paraBirimi != null)
            {
                lblTotal.Text = $"{(personNumber * price)} {paraBirimi}";
                return;
            }
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Vacations vacations = new Vacations(id, page);
            vacations.Show();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBoxPhone.Text, @"^0[5]\d{9}$"))
            {
                MessageBox.Show("Lütfen geçerli bir Türkiye telefon numarası giriniz! (0 ile başlamalı ve 11 haneli olmalı)", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection sql = new SqlConnection(connectionString);
            sql.Open();

            string query = "INSERT INTO Reservations(phoneNumber, travelName, participantNumber) values(@phone, @travel, @participants)";

            SqlCommand sqlCommand = new SqlCommand(query, sql);

            sqlCommand.Parameters.Add("@phone", textBoxPhone.Text);
            sqlCommand.Parameters.Add("@participants", comboBoxPerson.SelectedItem.ToString());
            sqlCommand.Parameters.Add("@travel", cmbBoxTravels.SelectedItem.ToString());
            sqlCommand.ExecuteNonQuery();

            sql.Close();

            if (MessageBox.Show("Bilgileriniz başarıyla kaydedilmiştir. 2 iş günü içerisinde sizinle iletişime geçilecektir.\nBaşka bir işlem yapmak ister misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var form = new formHomePage();
                this.Hide();
                form.Show();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
