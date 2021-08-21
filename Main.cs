using System;
using System.Windows.Forms;

namespace Passwarder
{
    public partial class Main : Form
    {
        string Nicknew;
        string Clientw;
        string Numberb;
        public Main()
        {
            InitializeComponent();

            Date.Text = DateTime.Now.ToString("dd/MM/yyyy");
            Hour.Text = DateTime.Now.ToString("HH:mm");
        }
        private void Mother_Load(object sender, EventArgs e)
        {
            Userl.Text = "" + Nicknew + "#" + Clientw;
            Numberb = Clientw.ToString();
        }

        public void Nickget(string Nickold)
        {
            Nicknew = Nickold.ToString();
        }

        public void Clientget(string Clientd)
        {
            Clientw = Clientd.ToString();
        }

        //Drag and Drop Window

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Uppermenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Mother_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        //Hour and Date Timer

        private void DHtimer_Tick(object sender, EventArgs e)
        {

            Date.Text = DateTime.Now.ToString("dd/MM/yyyy");
            Hour.Text = DateTime.Now.ToString("HH:mm");
        }

        //Close and Minimize Button

        private void Closebtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will close down the whole application. Are you sure?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void Minibtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Log Out

        private void Logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Log out", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }

        }

        private void Addpass_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pass_add psd = new Pass_add();
            psd.Numberget(Numberb.ToString());
            psd.ShowDialog();
            this.Show();

        }

        private void Checkpass_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pass_check psc = new Pass_check();
            psc.Numberget(Numberb.ToString());
            psc.ShowDialog();
            this.Show();
        }

        private void Randpass_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pass_random psr = new Pass_random();
            psr.Numberget(Numberb.ToString());
            psr.ShowDialog();
            this.Show();
        }
    }
}
