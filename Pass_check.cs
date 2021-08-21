using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace Passwarder
{
    public partial class Pass_check : Form
    {
        readonly string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Projects\Passwarder\Passdata.mdf;Integrated Security=True";

        string Userstring;
        public Pass_check()
        {
            InitializeComponent();
        }

        public void Numberget(string Numberb)
        {
            Userstring = Numberb.ToString();
        }

        private void Pass_check_Load(object sender, EventArgs e)
        {

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

        private void Pass_check_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // Back Button

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(con))
            {
                sqlcon.Open();
                SqlCommand com;
                SqlCommand data;

                int top = 65;
                int bottom = 70;
                string retreiver = "";

                string query = "SELECT Pass_Id, Application, Add_date, Expire_date, Pass, Strength, Pass_length FROM Passwords WHERE Cliente_Id = '" + Userstring + "'";
                com = new SqlCommand(query, sqlcon);

                if (Appname.Text != "" && Passw.Text != "")
                {
                    retreiver = "SELECT Pass_Id, Application, Add_date, Expire_date, Pass, Strength, Pass_length FROM Passwords WHERE Cliente_Id ='" + Userstring + "' AND Application = '" + Appname.Text + "' AND Pass = '" + Passw.Text + "'";
                    data = new SqlCommand("SELECT COUNT(*) FROM Passwords WHERE Cliente_Id ='" + Userstring + "' AND Application = '" + Appname.Text + "' AND Pass = '" + Passw.Text + "'", sqlcon);
                }

                else if (Appname.Text != "" && Passw.Text == "")
                {
                    retreiver = "SELECT Pass_Id, Application, Add_date, Expire_date, Pass, Strength, Pass_length FROM Passwords WHERE Cliente_Id ='" + Userstring + "' AND Application = '" + Appname.Text + "'";
                    data = new SqlCommand("SELECT COUNT(*) FROM Passwords WHERE Cliente_Id ='" + Userstring + "' AND Application = '" + Appname.Text + "'", sqlcon);
                }

                else if (Appname.Text == "" && Passw.Text != "")
                {
                    retreiver = "SELECT Pass_Id, Application, Add_date, Expire_date, Pass, Strength, Pass_length FROM Passwords WHERE Cliente_Id ='" + Userstring + "' AND Pass = '" + Passw.Text + "'";
                    data = new SqlCommand("SELECT COUNT(*) FROM Passwords WHERE Cliente_Id ='" + Userstring + "' AND Pass = '" + Passw.Text + "'", sqlcon);
                }

                else
                {
                    retreiver = "SELECT Pass_Id, Application, Add_date, Expire_date, Pass, Strength, Pass_length FROM Passwords WHERE Cliente_Id ='" + Userstring + "'";
                    data = new SqlCommand("SELECT COUNT(*) FROM Passwords WHERE Cliente_Id = '" + Userstring + "'", sqlcon);
                }

                using (SqlDataAdapter adp = new SqlDataAdapter(retreiver, sqlcon))
                {

                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    int count = Convert.ToInt32(data.ExecuteScalar());
                    SqlDataReader reader = com.ExecuteReader();

                    Counter.Text = Convert.ToString(count);

                    Label[] Idlabel = new Label[count];
                    Label[] Idnumber = new Label[count];
                    Label[] Applabel = new Label[count];
                    Label[] Apptext = new Label[count];
                    Label[] Passlabel = new Label[count];
                    TextBox[] Passtext = new TextBox[count];
                    Label[] Startlabel = new Label[count];
                    Label[] Start_text = new Label[count];
                    Label[] Expirelabel = new Label[count];
                    Label[] Expire_text = new Label[count];
                    Label[] Strengthlabel = new Label[count];
                    Label[] Strengthtext = new Label[count];
                    Label[] Lengthlabel = new Label[count];
                    Label[] Length_text = new Label[count];

                    // Idlabel

                    Idlabel[0]= new Label
                    {
                        AutoSize = true,
                        Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                        ForeColor = System.Drawing.SystemColors.ActiveCaptionText,
                        Location = new System.Drawing.Point(29, (30)),
                        Name = "Idlabel" + 0,
                        Size = new System.Drawing.Size(21, 17),
                        Text = "Id:"
                    };

                    // Idnumber

                    Idnumber[0] = new Label
                    {
                        AutoSize = true,
                        Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                        ForeColor = System.Drawing.SystemColors.ActiveCaptionText,
                        Location = new System.Drawing.Point(47, (30)),
                        Name = "Idnumber" + 0,
                        Size = new System.Drawing.Size(16, 17),
                        Text = "0"
                    };

                    // Applabel

                    Applabel[0] = new Label
                    {
                        AutoSize = true,
                        Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                        ForeColor = System.Drawing.SystemColors.ActiveCaptionText,
                        Location = new System.Drawing.Point(132, (30)),
                        Name = "Applabel" + 0,
                        Size = new System.Drawing.Size(73, 17),
                        Text = "Application:"
                    };

                    // Apptext

                    Apptext[0] = new Label
                    {
                        AutoSize = true,
                        Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                        ForeColor = System.Drawing.SystemColors.ActiveCaptionText,
                        Location = new System.Drawing.Point(202, (30)),
                        Name = "Apptext" + 0,
                        Size = new System.Drawing.Size(16, 17),
                        Text = "0"
                    };

                    // Passlabel

                    Passlabel[0] = new Label
                    {
                        AutoSize = true,
                        Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                        ForeColor = System.Drawing.SystemColors.ActiveCaptionText,
                        Location = new System.Drawing.Point(479, (30)),
                        Name = "Passlabel" + 0,
                        Size = new System.Drawing.Size(65, 17),
                        Text = "Password:"
                    };

                    // Passtext

                    Passtext[0] = new TextBox
                    {
                        Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                        Location = new System.Drawing.Point(550, (27)),
                        MaxLength = 20,
                        Name = "Passtext" + 0,
                        Size = new System.Drawing.Size(232, 22),
                    };

                    // Startlabel

                    Startlabel[0] = new Label
                    {
                        AutoSize = true,
                        Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                        ForeColor = System.Drawing.SystemColors.ActiveCaptionText,
                        Location = new System.Drawing.Point(29, (50)),
                        Name = "Startlabel" + 0,
                        Size = new System.Drawing.Size(67, 17),
                        Text = "Start Date:"
                    };

                    // Start_text

                    Start_text[0] = new Label
                    {
                        AutoSize = true,
                        Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                        ForeColor = System.Drawing.SystemColors.ActiveCaptionText,
                        Location = new System.Drawing.Point(91, (50)),
                        Name = "Start_text" + 0,
                        Size = new System.Drawing.Size(16, 17),
                        Text = "0"
                    };

                    // Expirelabel

                    Expirelabel[0] = new Label
                    {
                        AutoSize = true,
                        Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                        ForeColor = System.Drawing.SystemColors.ActiveCaptionText,
                        Location = new System.Drawing.Point(239, (50)),
                        Name = "Expirelabel" + 0,
                        Size = new System.Drawing.Size(74, 17),
                        Text = "Expire Date:"
                    };

                    // Expire_text

                    Expire_text[0] = new Label
                    {
                        AutoSize = true,
                        Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                        ForeColor = System.Drawing.SystemColors.ActiveCaptionText,
                        Location = new System.Drawing.Point(308, (50)),
                        Name = "Expire_text" + 0,
                        Size = new System.Drawing.Size(16, 17),
                        Text = "0"
                    };

                    // Strengthlabel

                    Strengthlabel[0] = new Label
                    {
                        AutoSize = true,
                        Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                        ForeColor = System.Drawing.SystemColors.ActiveCaptionText,
                        Location = new System.Drawing.Point(479, (50)),
                        Name = "Strengthlabel" + 0,
                        Size = new System.Drawing.Size(58, 17),
                        Text = "Strength:"
                    };

                    // Strengthtext

                    Strengthtext[0] = new Label
                    {
                        AutoSize = true,
                        Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                        ForeColor = System.Drawing.SystemColors.ActiveCaptionText,
                        Location = new System.Drawing.Point(534, (50)),
                        Name = "Strengthtext" + 0,
                        Size = new System.Drawing.Size(16, 17),
                        Text = "0"
                    };

                    // Lengthlabel

                    Lengthlabel[0] = new Label
                    {
                        AutoSize = true,
                        Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                        ForeColor = System.Drawing.SystemColors.ActiveCaptionText,
                        Location = new System.Drawing.Point(836, (50)),
                        Name = "Lengthlabel" + 0,
                        Size = new System.Drawing.Size(76, 17),
                        Text = "Pass length:"
                    };

                    // Length_text2

                    Length_text[0] = new Label
                    {
                        AutoSize = true,
                        Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                        ForeColor = System.Drawing.SystemColors.ActiveCaptionText,
                        Location = new System.Drawing.Point(907, (50)),
                        Name = "Length_text" + 0,
                        Size = new System.Drawing.Size(16, 17),
                        Text = "0"
                    };

                    if (count == 1)
                    {
                        NoInfo.Visible = false;
                        panel1.Controls.Clear();
                        // Control Add

                        panel1.Controls.Add(Idlabel[0]);
                        panel1.Controls.Add(Idnumber[0]);
                        Idnumber[0].Text = Convert.ToString(dt.Rows[0].Field<int>("Pass_Id"));

                        panel1.Controls.Add(Applabel[0]);
                        panel1.Controls.Add(Apptext[0]);
                        Apptext[0].Text = Convert.ToString(dt.Rows[0].Field<string>("Application"));

                        panel1.Controls.Add(Passlabel[0]);
                        panel1.Controls.Add(Passtext[0]);
                        Passtext[0].Text = Convert.ToString(dt.Rows[0].Field<string>("Pass"));

                        panel1.Controls.Add(Startlabel[0]);
                        panel1.Controls.Add(Start_text[0]);
                        Start_text[0].Text = Convert.ToString(dt.Rows[0].Field<string>("Add_date"));

                        panel1.Controls.Add(Expirelabel[0]);
                        panel1.Controls.Add(Expire_text[0]);
                        Expire_text[0].Text = Convert.ToString(dt.Rows[0].Field<string>("Expire_date"));

                        panel1.Controls.Add(Strengthlabel[0]);
                        panel1.Controls.Add(Strengthtext[0]);
                        Strengthtext[0].Text = Convert.ToString(dt.Rows[0].Field<string>("Strength"));

                        panel1.Controls.Add(Lengthlabel[0]);
                        panel1.Controls.Add(Length_text[0]);
                        Length_text[0].Text = Convert.ToString(dt.Rows[0].Field<int>("Pass_length"));
                    }

                    else if (count > 1)
                    {
                        NoInfo.Visible = false;
                        panel1.Controls.Clear();
                        // Control Add

                        panel1.Controls.Add(Idlabel[0]);
                        panel1.Controls.Add(Idnumber[0]);
                        Idnumber[0].Text = Convert.ToString(dt.Rows[0].Field<int>("Pass_Id"));

                        panel1.Controls.Add(Applabel[0]);
                        panel1.Controls.Add(Apptext[0]);
                        Apptext[0].Text = Convert.ToString(dt.Rows[0].Field<string>("Application"));

                        panel1.Controls.Add(Passlabel[0]);
                        panel1.Controls.Add(Passtext[0]);
                        Passtext[0].Text = Convert.ToString(dt.Rows[0].Field<string>("Pass"));

                        panel1.Controls.Add(Startlabel[0]);
                        panel1.Controls.Add(Start_text[0]);
                        Start_text[0].Text = Convert.ToString(dt.Rows[0].Field<string>("Add_date"));

                        panel1.Controls.Add(Expirelabel[0]);
                        panel1.Controls.Add(Expire_text[0]);
                        Expire_text[0].Text = Convert.ToString(dt.Rows[0].Field<string>("Expire_date"));

                        panel1.Controls.Add(Strengthlabel[0]);
                        panel1.Controls.Add(Strengthtext[0]);
                        Strengthtext[0].Text = Convert.ToString(dt.Rows[0].Field<string>("Strength"));

                        panel1.Controls.Add(Lengthlabel[0]);
                        panel1.Controls.Add(Length_text[0]);
                        Length_text[0].Text = Convert.ToString(dt.Rows[0].Field<int>("Pass_length"));

                        sqlcon.Close();

                        for (int i = 1; i < count; i++)
                        {

                            // Idlabel2

                            Idlabel[i] = new Label
                            {
                                AutoSize = true,
                                Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                                ForeColor = System.Drawing.SystemColors.ActiveCaptionText,
                                Location = new System.Drawing.Point(29, (30 + top)),
                                Name = "Idlabel" + i,
                                Size = new System.Drawing.Size(21, 17),
                                Text = "Id:"
                            };

                            // Idnumber2

                            Idnumber[i] = new Label
                            {
                                AutoSize = true,
                                Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                                ForeColor = System.Drawing.SystemColors.ActiveCaptionText,
                                Location = new System.Drawing.Point(47, (30 + top)),
                                Name = "Idnumber" + i,
                                Size = new System.Drawing.Size(16, 17),
                                Text = "0"
                            };

                            // Applabel2

                            Applabel[i] = new Label
                            {
                                AutoSize = true,
                                Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                                ForeColor = System.Drawing.SystemColors.ActiveCaptionText,
                                Location = new System.Drawing.Point(132, (30 + top)),
                                Name = "Applabel" + i,
                                Size = new System.Drawing.Size(73, 17),
                                Text = "Application:"
                            };

                            // Apptext2

                            Apptext[i] = new Label
                            {
                                AutoSize = true,
                                Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                                ForeColor = System.Drawing.SystemColors.ActiveCaptionText,
                                Location = new System.Drawing.Point(202, (30 + top)),
                                Name = "Apptext" + i,
                                Size = new System.Drawing.Size(16, 17),
                                Text = "0"
                            };

                            // Passlabel2

                            Passlabel[i] = new Label
                            {
                                AutoSize = true,
                                Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                                ForeColor = System.Drawing.SystemColors.ActiveCaptionText,
                                Location = new System.Drawing.Point(479, (30 + top)),
                                Name = "Passlabel" + i,
                                Size = new System.Drawing.Size(65, 17),
                                Text = "Password:"
                            };

                            // Passtext2

                            Passtext[i] = new TextBox
                            {
                                Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                                Location = new System.Drawing.Point(550, (27 + top)),
                                MaxLength = 20,
                                Name = "Passtext" + i,
                                Size = new System.Drawing.Size(232, 22),
                            };

                            // Startlabel2

                            Startlabel[i] = new Label
                            {
                                AutoSize = true,
                                Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                                ForeColor = System.Drawing.SystemColors.ActiveCaptionText,
                                Location = new System.Drawing.Point(29, (50 + bottom)),
                                Name = "Startlabel" + i,
                                Size = new System.Drawing.Size(67, 17),
                                Text = "Start Date:"
                            };

                            // Start_text2

                            Start_text[i] = new Label
                            {
                                AutoSize = true,
                                Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                                ForeColor = System.Drawing.SystemColors.ActiveCaptionText,
                                Location = new System.Drawing.Point(91, (50 + bottom)),
                                Name = "Start_text" + i,
                                Size = new System.Drawing.Size(16, 17),
                                Text = "0"
                            };

                            // Expirelabel2

                            Expirelabel[i] = new Label
                            {
                                AutoSize = true,
                                Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                                ForeColor = System.Drawing.SystemColors.ActiveCaptionText,
                                Location = new System.Drawing.Point(239, (50 + bottom)),
                                Name = "Expirelabel" + i,
                                Size = new System.Drawing.Size(74, 17),
                                Text = "Expire Date:"
                            };

                            // Expire_text2

                            Expire_text[i] = new Label
                            {
                                AutoSize = true,
                                Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                                ForeColor = System.Drawing.SystemColors.ActiveCaptionText,
                                Location = new System.Drawing.Point(308, (50 + bottom)),
                                Name = "Expire_text" + i,
                                Size = new System.Drawing.Size(16, 17),
                                Text = "0"
                            };

                            // Strengthlabel2

                            Strengthlabel[i] = new Label
                            {
                                AutoSize = true,
                                Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                                ForeColor = System.Drawing.SystemColors.ActiveCaptionText,
                                Location = new System.Drawing.Point(479, (50 + bottom)),
                                Name = "Strengthlabel" + i,
                                Size = new System.Drawing.Size(58, 17),
                                Text = "Strength:"
                            };

                            // Strengthtext2

                            Strengthtext[i] = new Label
                            {
                                AutoSize = true,
                                Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                                ForeColor = System.Drawing.SystemColors.ActiveCaptionText,
                                Location = new System.Drawing.Point(534, (50 + bottom)),
                                Name = "Strengthtext" + i,
                                Size = new System.Drawing.Size(16, 17),
                                Text = "0"
                            };

                            // Lengthlabel2

                            Lengthlabel[i] = new Label
                            {
                                AutoSize = true,
                                Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                                ForeColor = System.Drawing.SystemColors.ActiveCaptionText,
                                Location = new System.Drawing.Point(836, (50 + bottom)),
                                Name = "Lengthlabel" + i,
                                Size = new System.Drawing.Size(76, 17),
                                Text = "Pass length:"
                            };

                            // Length_text2

                            Length_text[i] = new Label
                            {
                                AutoSize = true,
                                Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                                ForeColor = System.Drawing.SystemColors.ActiveCaptionText,
                                Location = new System.Drawing.Point(907, (50 + bottom)),
                                Name = "Length_text" + i,
                                Size = new System.Drawing.Size(16, 17),
                                Text = "0"
                            };

                            // Control Add

                            panel1.Controls.Add(Idlabel[i]);
                            panel1.Controls.Add(Idnumber[i]);
                            Idnumber[i].Text = Convert.ToString(dt.Rows[i].Field<int>("Pass_Id"));

                            panel1.Controls.Add(Applabel[i]);
                            panel1.Controls.Add(Apptext[i]);
                            Apptext[i].Text = Convert.ToString(dt.Rows[i].Field<string>("Application"));

                            panel1.Controls.Add(Passlabel[i]);
                            panel1.Controls.Add(Passtext[i]);
                            Passtext[i].Text = Convert.ToString(dt.Rows[i].Field<string>("Pass"));

                            panel1.Controls.Add(Startlabel[i]);
                            panel1.Controls.Add(Start_text[i]);
                            Start_text[i].Text = Convert.ToString(dt.Rows[i].Field<string>("Add_date"));

                            panel1.Controls.Add(Expirelabel[i]);
                            panel1.Controls.Add(Expire_text[i]);
                            Expire_text[i].Text = Convert.ToString(dt.Rows[i].Field<string>("Expire_date"));

                            panel1.Controls.Add(Strengthlabel[i]);
                            panel1.Controls.Add(Strengthtext[i]);
                            Strengthtext[i].Text = Convert.ToString(dt.Rows[i].Field<string>("Strength"));

                            panel1.Controls.Add(Lengthlabel[i]);
                            panel1.Controls.Add(Length_text[i]);
                            Length_text[i].Text = Convert.ToString(dt.Rows[i].Field<int>("Pass_length"));

                            top += 80;
                            bottom += 80;
                        }

                        sqlcon.Close();
                    }

                    else
                    {

                    }
                }
                sqlcon.Close();
            }
        }

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
    }
}
