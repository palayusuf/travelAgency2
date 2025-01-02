using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace travelAgency2
{
    public partial class formUserLogin : Form
    {
        public formUserLogin()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            formLoginPage formLoginPage = new formLoginPage();
            formLoginPage.Show();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            this.Close();
            formSignUp formSignUp = new formSignUp();
            formSignUp.Show();
        }
    }
}
