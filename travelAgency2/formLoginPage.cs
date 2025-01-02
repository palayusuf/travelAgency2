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
    public partial class formLoginPage : Form
    {
        string connectionString = "Server=.;Database=TravelAgency;Trusted_Connection=True;TrustServerCertificate=True;";
        public formLoginPage()
        {
            InitializeComponent();
        }

        private void btnLook_MouseDown(object sender, MouseEventArgs e)
        {
            textPassword.PasswordChar = '\0';
        }

        private void btnLook_MouseUp(object sender, MouseEventArgs e)
        {
            textPassword.PasswordChar = '*';
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textUsername.Text) || string.IsNullOrEmpty(textPassword.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                string cmdStr = "SELECT COUNT(1) FROM Users WHERE USERNAME = @username AND PASSWORD = @password";

                SqlCommand cmd = new SqlCommand(cmdStr, conn);

                cmd.Parameters.AddWithValue("@username", textUsername.Text);
                cmd.Parameters.AddWithValue("@password", textPassword.Text);

                int sonuc = (int)cmd.ExecuteScalar();
                
                if (sonuc > 0)
                {
                    formHomePage hPage = new formHomePage();
                    this.Hide();
                    hPage.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
                }

                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu, lütfen daha sonra tekrar deneyiniz.");
            }
        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
            this.Close();
            formUserLogin formUserLogin = new formUserLogin();
            formUserLogin.Show();
        }

    }
}
