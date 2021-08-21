using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Passwarder
{
    public partial class Pass_add : Form
    {
        private readonly SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Projects\Passwarder\Passdata.mdf;Integrated Security=True");
        SqlCommand cmd;

        string Userstring;

        public Pass_add()
        {
            InitializeComponent();
        }

        public void Numberget(string Numberb)
        {
            Userstring = Numberb.ToString();
        }

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

        private void Pass_add_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void LoadResults()
        {
            var c = con;

            con.Open();
            var select = "SELECT Application, Add_date, Expire_date, Pass, Strength, Pass_length FROM Passwords WHERE Cliente_Id='" + Userstring + "'";
            var dataAdapter = new SqlDataAdapter(select, c);
            _ = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            Passdatagrid.ReadOnly = true;
            Passdatagrid.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Pass_add_Load(object sender, EventArgs e)
        {
            Passhow.Checked = false;
            Passw.UseSystemPasswordChar = true;

            DateTime today = DateTime.Now;
            DateTime sixmonths = today.AddMonths(6);


            Startdateorg.Text = today.ToString("dd/MM/yyyy");
            Enddateorg.Text = sixmonths.ToString("dd/MM/yyyy");

            LoadResults();
        }

        private void Passw_TextChanged(object sender, EventArgs e)
        {
            string password = Passw.Text;
            int score = 0;

            Lengthext.Text = Passw.Text.Length.ToString();

            if (password.Length >= 12)
            {
                score++;
            }
            if (password.Any(char.IsUpper))
            {
                score++;
            }
            if (password.Any(char.IsLower))
            {
                score++;
            }
            if (password.Any(char.IsDigit))
            {
                score++;
            }
            if (password.Any(char.IsPunctuation))
            {
                score++;
            }
            else
            {
                Strength.Text = "";
            }

            Strength.Text = Convert.ToString(score);

            switch (score)
            {
                case 0:
                    Strength.Text = "";
                    Strength.ForeColor = Color.White;
                    return;
                case 1:
                    Strength.Text = "Very Weak";
                    Strength.ForeColor = Color.Red;
                    return;
                case 2:
                    Strength.Text = "Weak";
                    Strength.ForeColor = Color.IndianRed;
                    return;
                case 3:
                    Strength.Text = "Medium";
                    Strength.ForeColor = Color.DarkOrange;
                    return;
                case 4:
                    Strength.Text = "Good";
                    Strength.ForeColor = Color.LimeGreen;
                    return;
                case 5:
                    Strength.Text = "Very Good";
                    Strength.ForeColor = Color.Lime;
                    return;
            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        private void Inserter_Click(object sender, EventArgs e)
        {
            if (Appname.Text == "" || Passw.Text == "")
            {
                MessageBox.Show("Please fill out all boxes", "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Passwords WHERE Application='" + Appname.Text + "' AND Cliente_Id='" + Convert.ToInt32(Userstring) + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    DialogResult Dialogres = MessageBox.Show("The Application you choose already exists, if you wish to create a new one, select YES. If you wish to update the old one, select NO", "Application Already in Use", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                    if (Dialogres == DialogResult.Yes)
                    {
                        Appname.Text = Appname.Text.ToUpper();

                        con.Open();
                        cmd = new SqlCommand("INSERT INTO Passwords (Cliente_Id, Application, Add_date, Expire_date, Pass, Strength, Pass_length) VALUES ('" + Convert.ToInt32(Userstring) + "','" + Appname.Text + "','" + Startdateorg.Text + "','" + Enddateorg.Text + "','" + Passw.Text + "','" + Strength.Text + "','" + Lengthext.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Data inserted with Success!", "Password Inserted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Appname.Text = "";
                        Passw.Text = "";
                        Lengthext.Text = "0";

                        LoadResults();
                    }

                    else if (Dialogres == DialogResult.No)
                    {
                        Appname.Text = Appname.Text.ToUpper();

                        con.Open();
                        cmd = new SqlCommand("UPDATE Passwords SET Add_date = '" + Startdateorg.Text + "', Expire_date = '" + Enddateorg.Text + "', Pass = '" + Passw.Text + "', Strength = '" + Strength.Text + "', Pass_length = '" + Lengthext.Text +"' WHERE Cliente_Id = '" + Convert.ToInt32(Userstring) + "' AND Application = '" + Appname.Text + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Data Updated with Success!", "Password Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Appname.Text = "";
                        Passw.Text = "";
                        Lengthext.Text = "0";

                        LoadResults();
                    }

                   
                    
                }

                else if(dt.Rows[0][0].ToString() == "0")
                {
                    Appname.Text = Appname.Text.ToUpper();

                    con.Open();
                    cmd = new SqlCommand("INSERT INTO Passwords (Cliente_Id, Application, Add_date, Expire_date, Pass, Strength, Pass_length) VALUES ('" + Convert.ToInt32(Userstring) + "','" + Appname.Text + "','" + Startdateorg.Text + "','" + Enddateorg.Text + "','" + Passw.Text + "','" + Strength.Text + "','" + Lengthext.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Data inserted with Success!", "Password Inserted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Appname.Text = "";
                    Passw.Text = "";
                    Lengthext.Text = "0";

                    LoadResults();
                }
            }
        }

        //Closing App
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

        private void Passhow_CheckedChanged(object sender, EventArgs e)
        {
            if (Passhow.Checked == true)
            {
                Passw.UseSystemPasswordChar = false;
            }
            else
            {
                Passw.UseSystemPasswordChar = true;
            }
        }
    }
}