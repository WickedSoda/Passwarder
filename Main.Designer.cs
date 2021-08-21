
namespace Passwarder
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Mainmenu = new System.Windows.Forms.Panel();
            this.Logout = new System.Windows.Forms.Button();
            this.Infotext1 = new System.Windows.Forms.Label();
            this.Hour = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Hourl = new System.Windows.Forms.Label();
            this.Datel = new System.Windows.Forms.Label();
            this.Anapass = new System.Windows.Forms.Button();
            this.Randpass = new System.Windows.Forms.Button();
            this.Checkpass = new System.Windows.Forms.Button();
            this.Addpass = new System.Windows.Forms.Button();
            this.Uppermenu = new System.Windows.Forms.Panel();
            this.Userl = new System.Windows.Forms.Label();
            this.Welcomel = new System.Windows.Forms.Label();
            this.Icons = new System.Windows.Forms.Panel();
            this.Minibtn = new System.Windows.Forms.Button();
            this.Closebtn = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Panel();
            this.DHtimer = new System.Windows.Forms.Timer(this.components);
            this.Infopanel = new System.Windows.Forms.Panel();
            this.Infotext2 = new System.Windows.Forms.Label();
            this.Infopanel2 = new System.Windows.Forms.Panel();
            this.Mainmenu.SuspendLayout();
            this.Uppermenu.SuspendLayout();
            this.Infopanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mainmenu
            // 
            this.Mainmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(164)))), ((int)(((byte)(212)))));
            this.Mainmenu.Controls.Add(this.Logout);
            this.Mainmenu.Controls.Add(this.Infotext1);
            this.Mainmenu.Controls.Add(this.Hour);
            this.Mainmenu.Controls.Add(this.Date);
            this.Mainmenu.Controls.Add(this.Hourl);
            this.Mainmenu.Controls.Add(this.Datel);
            this.Mainmenu.Controls.Add(this.Anapass);
            this.Mainmenu.Controls.Add(this.Randpass);
            this.Mainmenu.Controls.Add(this.Checkpass);
            this.Mainmenu.Controls.Add(this.Addpass);
            this.Mainmenu.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Mainmenu.Location = new System.Drawing.Point(0, 33);
            this.Mainmenu.Name = "Mainmenu";
            this.Mainmenu.Size = new System.Drawing.Size(342, 666);
            this.Mainmenu.TabIndex = 0;
            // 
            // Logout
            // 
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.Red;
            this.Logout.Location = new System.Drawing.Point(244, 66);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(95, 38);
            this.Logout.TabIndex = 11;
            this.Logout.Text = "Log out";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Infotext1
            // 
            this.Infotext1.AutoSize = true;
            this.Infotext1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Infotext1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Infotext1.Location = new System.Drawing.Point(49, 574);
            this.Infotext1.Name = "Infotext1";
            this.Infotext1.Size = new System.Drawing.Size(239, 72);
            this.Infotext1.TabIndex = 10;
            this.Infotext1.Text = "in case of bug or suggestion\r\nplease contact us by email\r\npasswarder@outlook.com\r" +
    "\n";
            // 
            // Hour
            // 
            this.Hour.AutoSize = true;
            this.Hour.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hour.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Hour.Location = new System.Drawing.Point(70, 66);
            this.Hour.Name = "Hour";
            this.Hour.Size = new System.Drawing.Size(65, 26);
            this.Hour.TabIndex = 9;
            this.Hour.Text = "00:00";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Date.Location = new System.Drawing.Point(70, 24);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(128, 26);
            this.Date.TabIndex = 8;
            this.Date.Text = "00/00/0000";
            // 
            // Hourl
            // 
            this.Hourl.AutoSize = true;
            this.Hourl.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hourl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Hourl.Location = new System.Drawing.Point(12, 66);
            this.Hourl.Name = "Hourl";
            this.Hourl.Size = new System.Drawing.Size(59, 26);
            this.Hourl.TabIndex = 7;
            this.Hourl.Text = "Hour:";
            // 
            // Datel
            // 
            this.Datel.AutoSize = true;
            this.Datel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Datel.Location = new System.Drawing.Point(12, 24);
            this.Datel.Name = "Datel";
            this.Datel.Size = new System.Drawing.Size(60, 26);
            this.Datel.TabIndex = 6;
            this.Datel.Text = "Date:";
            // 
            // Anapass
            // 
            this.Anapass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Anapass.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anapass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Anapass.Location = new System.Drawing.Point(0, 381);
            this.Anapass.Name = "Anapass";
            this.Anapass.Size = new System.Drawing.Size(342, 84);
            this.Anapass.TabIndex = 4;
            this.Anapass.Text = "Password Analyser";
            this.Anapass.UseVisualStyleBackColor = true;
            // 
            // Randpass
            // 
            this.Randpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Randpass.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Randpass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Randpass.Location = new System.Drawing.Point(0, 291);
            this.Randpass.Name = "Randpass";
            this.Randpass.Size = new System.Drawing.Size(342, 84);
            this.Randpass.TabIndex = 3;
            this.Randpass.Text = "Random Password";
            this.Randpass.UseVisualStyleBackColor = true;
            // 
            // Checkpass
            // 
            this.Checkpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Checkpass.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkpass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Checkpass.Location = new System.Drawing.Point(0, 200);
            this.Checkpass.Name = "Checkpass";
            this.Checkpass.Size = new System.Drawing.Size(342, 84);
            this.Checkpass.TabIndex = 2;
            this.Checkpass.Text = "Check Password";
            this.Checkpass.UseVisualStyleBackColor = true;
            this.Checkpass.Click += new System.EventHandler(this.Checkpass_Click);
            // 
            // Addpass
            // 
            this.Addpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addpass.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addpass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Addpass.Location = new System.Drawing.Point(0, 110);
            this.Addpass.Name = "Addpass";
            this.Addpass.Size = new System.Drawing.Size(342, 84);
            this.Addpass.TabIndex = 1;
            this.Addpass.Text = "Add Password";
            this.Addpass.UseVisualStyleBackColor = true;
            this.Addpass.Click += new System.EventHandler(this.Addpass_Click);
            // 
            // Uppermenu
            // 
            this.Uppermenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(131)))), ((int)(((byte)(171)))));
            this.Uppermenu.Controls.Add(this.Userl);
            this.Uppermenu.Controls.Add(this.Welcomel);
            this.Uppermenu.Controls.Add(this.Icons);
            this.Uppermenu.Controls.Add(this.Minibtn);
            this.Uppermenu.Controls.Add(this.Closebtn);
            this.Uppermenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Uppermenu.Location = new System.Drawing.Point(0, 0);
            this.Uppermenu.Name = "Uppermenu";
            this.Uppermenu.Size = new System.Drawing.Size(1118, 36);
            this.Uppermenu.TabIndex = 1;
            this.Uppermenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Uppermenu_MouseDown);
            // 
            // Userl
            // 
            this.Userl.AutoSize = true;
            this.Userl.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Userl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Userl.Location = new System.Drawing.Point(129, 7);
            this.Userl.Name = "Userl";
            this.Userl.Size = new System.Drawing.Size(21, 24);
            this.Userl.TabIndex = 10;
            this.Userl.Text = "0";
            // 
            // Welcomel
            // 
            this.Welcomel.AutoSize = true;
            this.Welcomel.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcomel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Welcomel.Location = new System.Drawing.Point(39, 7);
            this.Welcomel.Name = "Welcomel";
            this.Welcomel.Size = new System.Drawing.Size(98, 24);
            this.Welcomel.TabIndex = 9;
            this.Welcomel.Text = "Welcome, ";
            // 
            // Icons
            // 
            this.Icons.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Icons.BackgroundImage")));
            this.Icons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Icons.Location = new System.Drawing.Point(3, 3);
            this.Icons.Name = "Icons";
            this.Icons.Size = new System.Drawing.Size(30, 30);
            this.Icons.TabIndex = 3;
            // 
            // Minibtn
            // 
            this.Minibtn.BackColor = System.Drawing.Color.DarkGray;
            this.Minibtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minibtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minibtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Minibtn.Location = new System.Drawing.Point(1044, 3);
            this.Minibtn.Name = "Minibtn";
            this.Minibtn.Size = new System.Drawing.Size(33, 30);
            this.Minibtn.TabIndex = 4;
            this.Minibtn.Text = "_";
            this.Minibtn.UseVisualStyleBackColor = false;
            this.Minibtn.Click += new System.EventHandler(this.Minibtn_Click);
            // 
            // Closebtn
            // 
            this.Closebtn.BackColor = System.Drawing.Color.Firebrick;
            this.Closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Closebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Closebtn.Location = new System.Drawing.Point(1083, 3);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(33, 30);
            this.Closebtn.TabIndex = 3;
            this.Closebtn.Text = "X";
            this.Closebtn.UseVisualStyleBackColor = false;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // Title
            // 
            this.Title.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Title.BackgroundImage")));
            this.Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Title.Location = new System.Drawing.Point(431, 42);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(606, 83);
            this.Title.TabIndex = 2;
            // 
            // DHtimer
            // 
            this.DHtimer.Enabled = true;
            this.DHtimer.Interval = 1000;
            this.DHtimer.Tick += new System.EventHandler(this.DHtimer_Tick);
            // 
            // Infopanel
            // 
            this.Infopanel.Controls.Add(this.Infotext2);
            this.Infopanel.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Infopanel.Location = new System.Drawing.Point(346, 586);
            this.Infopanel.Name = "Infopanel";
            this.Infopanel.Size = new System.Drawing.Size(768, 113);
            this.Infopanel.TabIndex = 3;
            // 
            // Infotext2
            // 
            this.Infotext2.AutoSize = true;
            this.Infotext2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Infotext2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Infotext2.Location = new System.Drawing.Point(362, 40);
            this.Infotext2.Name = "Infotext2";
            this.Infotext2.Size = new System.Drawing.Size(53, 26);
            this.Infotext2.TabIndex = 11;
            this.Infotext2.Text = "Tips:";
            // 
            // Infopanel2
            // 
            this.Infopanel2.Location = new System.Drawing.Point(346, 143);
            this.Infopanel2.Name = "Infopanel2";
            this.Infopanel2.Size = new System.Drawing.Size(768, 437);
            this.Infopanel2.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1118, 698);
            this.Controls.Add(this.Infopanel2);
            this.Controls.Add(this.Infopanel);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Uppermenu);
            this.Controls.Add(this.Mainmenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Mother_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mother_MouseDown);
            this.Mainmenu.ResumeLayout(false);
            this.Mainmenu.PerformLayout();
            this.Uppermenu.ResumeLayout(false);
            this.Uppermenu.PerformLayout();
            this.Infopanel.ResumeLayout(false);
            this.Infopanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Mainmenu;
        private System.Windows.Forms.Panel Uppermenu;
        private System.Windows.Forms.Button Anapass;
        private System.Windows.Forms.Button Randpass;
        private System.Windows.Forms.Button Checkpass;
        private System.Windows.Forms.Button Addpass;
        private System.Windows.Forms.Panel Title;
        private System.Windows.Forms.Label Hour;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Hourl;
        private System.Windows.Forms.Label Datel;
        private System.Windows.Forms.Timer DHtimer;
        private System.Windows.Forms.Button Minibtn;
        private System.Windows.Forms.Button Closebtn;
        private System.Windows.Forms.Panel Icons;
        private System.Windows.Forms.Label Infotext1;
        private System.Windows.Forms.Panel Infopanel;
        private System.Windows.Forms.Label Infotext2;
        private System.Windows.Forms.Panel Infopanel2;
        private System.Windows.Forms.Label Userl;
        private System.Windows.Forms.Label Welcomel;
        private System.Windows.Forms.Button Logout;
    }
}

