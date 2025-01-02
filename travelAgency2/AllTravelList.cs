using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace travelAgency2
{
    public partial class AllTravelList : Form

    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private string connectionString = "server=.;database=TravelAgency;integrated security=true;TrustServerCertificate=True";

        public AllTravelList()
        {
            InitializeComponent();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            formHomePage formHomePage = new formHomePage();
            formHomePage.Show();
        }
        private void GetAllTravelList(string month)
        {
            var dataTable = new DataTable();

            string query = "SELECT * FROM VacationTypeInformations";

            if (!string.IsNullOrEmpty(month))
            {
                query += " WHERE MONTH(StartDate) = @MonthNumber ORDER BY StartDate";
            }

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand(query, connection))
                {
                    if (!string.IsNullOrEmpty(month))
                    {
                        int monthNumber = DateTime.ParseExact(month, "MMMM", System.Globalization.CultureInfo.CurrentCulture).Month;
                        command.Parameters.AddWithValue("@MonthNumber", monthNumber);
                    }

                    using (var reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }

            dataGridAllTravel.DataSource = dataTable;
            dataGridAllTravel.Columns["ID"].Visible = false;
            dataGridAllTravel.Columns["VacationTypeId"].Visible = false;
            foreach (DataGridViewColumn column in dataGridAllTravel.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }


        private void AllTravelList_Load(object sender, EventArgs e)
        {
            GetAllTravelList(null);
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            dataGridAllTravel.DataSource = null;
            dataGridAllTravel.Columns.Clear();
            Button monthBtn = (Button)sender;

            GetAllTravelList(monthBtn.Text);
        }
        private void dataGridAllTravel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridAllTravel.Rows[e.RowIndex];

                int id = Convert.ToInt32(selectedRow.Cells["VacationTypeId"].Value.ToString());
                Vacations vacation = new Vacations(id, "allTravel");
                this.Close();
                vacation.Show();
           
            }
        }

        private void AllTravelList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
