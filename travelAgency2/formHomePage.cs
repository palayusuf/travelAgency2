using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;


namespace travelAgency2
{
    public partial class formHomePage : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public formHomePage()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void favorites_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            Button btn = sender as Button;
            if(pictureBox != null)
            {
            pictureBox.Size = new Size(315,65);
            pictureBox.Location = new Point(pictureBox.Location.X-5, pictureBox.Location.Y-5);
            }
            else if(btn != null)
            {
                btn.Size = new Size(350, 70);
                btn.Location = new Point(btn.Location.X - 5, btn.Location.Y - 5);
            }

        }

        private void favorites_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            Button btn = sender as Button;
            if(pictureBox != null)
            {
            pictureBox.Size = new Size(294, 52);
            pictureBox.Location = new Point(pictureBox.Location.X + 5, pictureBox.Location.Y + 5);
            }
            else if (btn != null)
            {
                btn.Size = new Size(334, 55);
                btn.Location = new Point(btn.Location.X + 5, btn.Location.Y + 5);
            }
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            PictureBox pic = sender as PictureBox;
            if(menuItem != null )
            {
                int id = int.Parse(menuItem.Tag.ToString());
                Vacations vacation = new Vacations(id,"home");
                this.Hide();
                vacation.Show();
            }
            else if ( pic != null )
            {
                int id = int.Parse(pic.Tag.ToString());
                Vacations vacation = new Vacations(id,"home");
                this.Hide();
                vacation.Show();
            }

        }

        private void btnAllTravel_Click(object sender, EventArgs e)
        {
            AllTravelList allTravel = new AllTravelList();
            this.Hide();
            allTravel.Show();
        }
    }
}
