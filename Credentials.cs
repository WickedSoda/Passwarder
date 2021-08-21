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
    public partial class Credentials : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Projects\Passwarder\Passdata.mdf;Integrated Security=True");
        SqlCommand cmd;

        string Nickold;
        string Clientd;
        public Credentials()
        {
            InitializeComponent();

            Registerfor.Visible = false;
            Birtht.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        //Close and Minimize Button

        private void Closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minibtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Regist_Click(object sender, EventArgs e)
        {
            Registerfor.Visible = true;
            Registerfor.Location = new Point(10, 115);
        }

        //Register Details

        private void Monthcalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            Birtht.Text = Monthcalendar.SelectionRange.Start.ToShortDateString();

        }

        //Password Checker

        private void Passt_TextChanged(object sender, EventArgs e)
        {
            string password = Passt.Text;
            int score = 0;

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
                    Strength.Text = "Very Good!";
                    Strength.ForeColor = Color.Lime;
                    return;
            }

        }

        //Password Confirmation

        private void Confpasst_TextChanged(object sender, EventArgs e)
        {
            string confpass = Confpasst.Text;
            string origpass = Passt.Text;

            if (confpass == origpass)
            {
                Verify.Text = "Password Correct";
                Verify.ForeColor = Color.Lime;
            }
            else if (confpass != origpass)
            {
                Verify.Text = "The Passwords are diferent";
                Verify.ForeColor = Color.Red;
            }
            else
            {
                Verify.Text = "";
            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Registerfor.Visible = false;
        }

        //Email Checker

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(Emailt.Text);
                return addr.Address == Emailt.Text;
            }
            catch
            {
                return false;
            }
        }

        //Phone text box limit

        private void Phonet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Encrypt
        //public string Encrypt(string decrypted)
        //{
        //    string hash = "Password@2021$";
        //    byte[] data = UTF8Encoding.UTF8.GetBytes(decrypted);
        //
        //   MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
        //    TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
        //
        //    tripleDES.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
        //    tripleDES.Mode = CipherMode.ECB;
        //
        //    ICryptoTransform transform = tripleDES.CreateEncryptor();
        //    byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
        //
        //    return Convert.ToBase64String(result);
        //}


        //Decryption
        //public string Decrypt(string encrypted)
        //{
        //    string hash = "Password@2021$";
        //    byte[] data = Convert.FromBase64String(encrypted);
        //
        //    MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
        //    TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
        //
        //    tripleDES.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
        //    tripleDES.Mode = CipherMode.ECB;
        //
        //    ICryptoTransform transform = tripleDES.CreateDecryptor();
        //    byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
        //
        //    return UTF8Encoding.UTF8.GetString(result);
        //}


        //Clear

        private void Clear()
        {
            Nickt.Text = "";
            Emailt.Text = "";
            Passt.Text = "";
            Confpasst.Text = "";
            Phonet.Text = "";
            Passhow.Checked = false;

            Birtht.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        //Register

        private void Regbtn_Click(object sender, EventArgs e)
        {
            int checker = 0;

            Passt.UseSystemPasswordChar = false;
            Confpasst.UseSystemPasswordChar = false;

            //Data Check

            //All In Check
            if (Nickt.Text == "" || Emailt.Text == "" || Passt.Text == "" || Confpasst.Text == "" || Phonet.Text == "")
            {
                MessageBox.Show("Please fill all the blank spaces.", "Register Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                //Nickname Verifcation
                if (Nickt.Text.Length < 9)
                {
                    MessageBox.Show("Please make sure your Nickname has at least 9 characters", "Nickname Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checker++;
                }

                //Email Verification
                if (!IsValidEmail(Emailt.Text))
                {
                    MessageBox.Show("Please insert a valid Email (example@email.com).", "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checker++;
                }

                //Password Verification
                if (!Passt.Text.Any(char.IsUpper) || !Passt.Text.Any(char.IsLower) || !Passt.Text.Any(char.IsDigit) || Passt.Text.Length < 12)
                {
                    MessageBox.Show("Please make sure your password fullfills all requirements (1 uppercase, 1 lowercase, 1 digit and at least 12 chars)", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checker++;
                }

                //Confirm Password Verification
                if (Confpasst.Text != Passt.Text)
                {
                    MessageBox.Show("Please make sure both passwords are the same.", "Confirm Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checker++;
                }

                //Birth Verification
                if (Birtht.Text == DateTime.Now.ToString("dd/MM/yyyy"))
                {
                    MessageBox.Show("Please make sure to change your Birth date.", "Birth Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checker++;
                }

                //Phone Verification
                if (Phonet.Text.Length < 9)
                {
                    MessageBox.Show("Please enter a valid Phone number (9 characters).", "Nickname Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checker++;
                }

                //Password General Score Verification
                if (checker == 0)
                {
                    con.Open();

                    SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Register WHERE Nickname='" + Nickt.Text + "' AND Email='" + Emailt.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        MessageBox.Show("Your Nickname or Email, is already in use", "Register Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        cmd = new SqlCommand("INSERT INTO Register (Nickname, Age, Email, Password, Phone, Membership) VALUES ('" + Nickt.Text + "','" + Birtht.Text + "','" + Emailt.Text + "','" + Passt.Text + "','" + Phonet.Text + "','" + "Regular" + "')", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        Registerfor.Visible = false;

                        Nickb.Text = Nickt.Text;

                        Clear();
                    }

                    con.Close();

                }
            }


        }

        //Login Details

        private void Login_Click(object sender, EventArgs e)
        {
            if (Nickb.Text == "" || Passb.Text == "")
            {
                MessageBox.Show("Please fill all the boxes.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Register WHERE Nickname='" + Nickb.Text + "' AND Password='" + Passb.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Nickold = Nickb.Text;

                    //Get Cliente_Id FOR Main form

                    SqlCommand vda = new SqlCommand("SELECT Cliente_Id FROM Register WHERE Nickname='" + Nickb.Text + "'", con);

                    using (SqlDataReader reader = vda.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Clientd = (reader["Cliente_Id"].ToString());
                        }

                    }

                    //Next Form

                    Passb.Text = "";
                    this.Hide();
                    Main c = new Main();
                    c.Nickget(Nickold.ToString());
                    c.Clientget(Clientd.ToString());
                    c.ShowDialog();
                    this.Show();




                }
                else
                {
                    MessageBox.Show("Invalid Nickname or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
            }
        }

        //Closing App
        private void Credentials_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("This will close down the whole application. Are you sure?", "Close Application", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void Passhow_CheckedChanged(object sender, EventArgs e)
        {
            if (Passhow.Checked == true)
            {
                Passt.UseSystemPasswordChar = false;
                Confpasst.UseSystemPasswordChar = false;
            }

            else
            {
                Passt.UseSystemPasswordChar = true;
                Confpasst.UseSystemPasswordChar = true;
            }
        }
    }
}
