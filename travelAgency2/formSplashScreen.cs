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
    public partial class formSplashScreen : Form
    {
        public formSplashScreen()
        {
            InitializeComponent();
        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            timerSplash.Enabled = true;
            progressBarSplash.Enabled = true;
            try
            {
                progressBarSplash.Value += random.Next(1, 20);
                if (progressBarSplash.Value >= 100)
                {
                    progressBarSplash.Enabled = false;
                    timerSplash.Enabled = false;
                    this.Hide();
                    formUserLogin formUl = new formUserLogin();
                    formUl.Show();
                    return;
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
