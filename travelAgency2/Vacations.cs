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
    public partial class Vacations : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private int id;
        private string page;
        private string connectionString = "server=.;database=TravelAgency;integrated security=true;TrustServerCertificate=True";
        public Vacations(int _id , string _page)
        {   
            id = _id;
            page = _page;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            if(page == "home")
            {
            formHomePage formHomePage = new formHomePage();
            formHomePage.Show();
            }
            else if(page == "allTravel")
            {
                AllTravelList list = new AllTravelList();
                list.Show();
            }
        }
        private void GetVacationTypeInformationById(int id)
        {
            var dataTable = new DataTable();
            string query = "SELECT * FROM VacationTypeInformations WHERE VacationTypeId = @Id";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    using (var reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }
            dataGridVacDate.DataSource = dataTable;
            dataGridVacDate.Columns["ID"].Visible = false;
            dataGridVacDate.Columns["VacationTypeId"].Visible = false;
            foreach (DataGridViewColumn column in dataGridVacDate.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }

        private void Vacations_Load(object sender, EventArgs e)
        {
            GetVacationTypeInformationById(id);
            GetVacationTypeLocationById(id);
        }
        private void GetVacationTypeLocationById(int id)
        {
            var dataTable = new DataTable();
            string query = "SELECT * FROM VacationTypeLocation WHERE VacationTypeId = @Id";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    using (var reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }
            dataGridLocations.DataSource = dataTable;
            dataGridLocations.Columns["ID"].Visible = false;
            dataGridLocations.Columns["VacationTypeId"].Visible = false;
            foreach (DataGridViewColumn column in dataGridLocations.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void Vacations_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            this.Hide();
            formContact formContact = new formContact(id, page);
            formContact.Show();
        }


    }
}
