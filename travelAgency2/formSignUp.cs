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
    public partial class formSignUp : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        string connectionString = "Server=.;Database=TravelAgency;Trusted_Connection=True;TrustServerCertificate=True;";

        public formSignUp()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private bool isTxtEmpty()
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPw.Text) || string.IsNullOrEmpty(txtMail.Text) || string.IsNullOrEmpty(txtPhone.Text))
            {
                return true;
            }

            return false;
        }

        private bool ValidateForm()
        {
            if (!Regex.IsMatch(txtName.Text, @"^[a-zA-Z\sğüşöçıİĞÜŞÖÇ]+$"))
            {
                MessageBox.Show("Ad Soyad sadece harflerden oluşmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (Regex.IsMatch(txtUsername.Text, @"^\d+$"))
            {
                MessageBox.Show("Kullanıcı adı sadece rakamlardan oluşamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Regex.IsMatch(txtMail.Text, @"^[^\s@]+@[^\s@]+\.[^\s@]+$"))
            {
                MessageBox.Show("Lütfen geçerli bir e-posta adresi giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Regex.IsMatch(txtPhone.Text, @"^0[5]\d{9}$"))
            {
                MessageBox.Show("Lütfen geçerli bir Türkiye telefon numarası giriniz! (0 ile başlamalı ve 11 haneli olmalı)", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
            formUserLogin formUserLogin = new formUserLogin();
            formUserLogin.Show();
        }

        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            if (isTxtEmpty())
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            if (!ValidateForm())
            {
                return;
            }

            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                string cmdStr = "INSERT INTO USERS(FullName, Username, Password, MailAddress, PhoneNumber)  VALUES (@name, @username, @pw, @mail, @phone)";
                SqlCommand cmd = new SqlCommand(cmdStr, conn);

                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@pw", txtPw.Text);
                cmd.Parameters.AddWithValue("@mail", txtMail.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);

                cmd.ExecuteNonQuery();
                this.Close();
                formHomePage formHomePage = new formHomePage();
                formHomePage.Show();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu, lütfen daha sonra tekrar deneyiniz.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLook_MouseDown(object sender, MouseEventArgs e)
        {
            txtPw.PasswordChar = '\0';
        }

        private void txtPw_MouseUp(object sender, MouseEventArgs e)
        {
            txtPw.PasswordChar = '*';
        }

        private void btnSignUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSignUp_Click_1(null, null);
            }
        }
    }
}
