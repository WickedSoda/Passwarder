
namespace Passwarder
{
    partial class Pass_check
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pass_check));
            this.Uppermenu = new System.Windows.Forms.Panel();
            this.Infotxt = new System.Windows.Forms.Label();
            this.Icons = new System.Windows.Forms.Panel();
            this.Minibtn = new System.Windows.Forms.Button();
            this.Closebtn = new System.Windows.Forms.Button();
            this.Backbtn = new System.Windows.Forms.Button();
            this.Passw = new System.Windows.Forms.TextBox();
            this.Passl = new System.Windows.Forms.Label();
            this.Appname = new System.Windows.Forms.TextBox();
            this.Applab = new System.Windows.Forms.Label();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NoInfo = new System.Windows.Forms.Label();
            this.Counter = new System.Windows.Forms.Label();
            this.Counterl = new System.Windows.Forms.Label();
            this.Uppermenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Uppermenu
            // 
            this.Uppermenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(131)))), ((int)(((byte)(171)))));
            this.Uppermenu.Controls.Add(this.Infotxt);
            this.Uppermenu.Controls.Add(this.Icons);
            this.Uppermenu.Controls.Add(this.Minibtn);
            this.Uppermenu.Controls.Add(this.Closebtn);
            this.Uppermenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Uppermenu.Location = new System.Drawing.Point(0, 0);
            this.Uppermenu.Name = "Uppermenu";
            this.Uppermenu.Size = new System.Drawing.Size(1118, 36);
            this.Uppermenu.TabIndex = 3;
            this.Uppermenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Uppermenu_MouseDown);
            // 
            // Infotxt
            // 
            this.Infotxt.AutoSize = true;
            this.Infotxt.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Infotxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Infotxt.Location = new System.Drawing.Point(39, 7);
            this.Infotxt.Name = "Infotxt";
            this.Infotxt.Size = new System.Drawing.Size(160, 26);
            this.Infotxt.TabIndex = 26;
            this.Infotxt.Text = "Check Password";
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
            // Backbtn
            // 
            this.Backbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backbtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.Location = new System.Drawing.Point(950, 162);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(140, 40);
            this.Backbtn.TabIndex = 34;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = false;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // Passw
            // 
            this.Passw.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passw.Location = new System.Drawing.Point(132, 134);
            this.Passw.MaxLength = 35;
            this.Passw.Name = "Passw";
            this.Passw.Size = new System.Drawing.Size(426, 31);
            this.Passw.TabIndex = 38;
            this.Passw.UseSystemPasswordChar = true;
            // 
            // Passl
            // 
            this.Passl.AutoSize = true;
            this.Passl.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Passl.Location = new System.Drawing.Point(21, 137);
            this.Passl.Name = "Passl";
            this.Passl.Size = new System.Drawing.Size(105, 26);
            this.Passl.TabIndex = 37;
            this.Passl.Text = "Password:";
            // 
            // Appname
            // 
            this.Appname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Appname.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appname.Location = new System.Drawing.Point(203, 68);
            this.Appname.MaxLength = 20;
            this.Appname.Name = "Appname";
            this.Appname.Size = new System.Drawing.Size(355, 31);
            this.Appname.TabIndex = 36;
            // 
            // Applab
            // 
            this.Applab.AutoSize = true;
            this.Applab.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Applab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Applab.Location = new System.Drawing.Point(21, 71);
            this.Applab.Name = "Applab";
            this.Applab.Size = new System.Drawing.Size(176, 26);
            this.Applab.TabIndex = 35;
            this.Applab.Text = "Application Name:";
            // 
            // Searchbtn
            // 
            this.Searchbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Searchbtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbtn.Location = new System.Drawing.Point(804, 162);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(140, 40);
            this.Searchbtn.TabIndex = 39;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = false;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.NoInfo);
            this.panel1.Location = new System.Drawing.Point(12, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 478);
            this.panel1.TabIndex = 40;
            // 
            // NoInfo
            // 
            this.NoInfo.AutoSize = true;
            this.NoInfo.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NoInfo.Location = new System.Drawing.Point(376, 210);
            this.NoInfo.Name = "NoInfo";
            this.NoInfo.Size = new System.Drawing.Size(359, 37);
            this.NoInfo.TabIndex = 51;
            this.NoInfo.Text = "No Passwords are stored";
            // 
            // Counter
            // 
            this.Counter.AutoSize = true;
            this.Counter.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Counter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Counter.Location = new System.Drawing.Point(111, 188);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(16, 17);
            this.Counter.TabIndex = 51;
            this.Counter.Text = "0";
            // 
            // Counterl
            // 
            this.Counterl.AutoSize = true;
            this.Counterl.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Counterl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Counterl.Location = new System.Drawing.Point(12, 188);
            this.Counterl.Name = "Counterl";
            this.Counterl.Size = new System.Drawing.Size(101, 17);
            this.Counterl.TabIndex = 52;
            this.Counterl.Text = "Nº of Passwords:";
            // 
            // Pass_check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 698);
            this.Controls.Add(this.Counterl);
            this.Controls.Add(this.Counter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.Passw);
            this.Controls.Add(this.Passl);
            this.Controls.Add(this.Appname);
            this.Controls.Add(this.Applab);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.Uppermenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pass_check";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Password";
            this.Load += new System.EventHandler(this.Pass_check_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pass_check_MouseDown);
            this.Uppermenu.ResumeLayout(false);
            this.Uppermenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Uppermenu;
        private System.Windows.Forms.Label Infotxt;
        private System.Windows.Forms.Panel Icons;
        private System.Windows.Forms.Button Minibtn;
        private System.Windows.Forms.Button Closebtn;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.TextBox Passw;
        private System.Windows.Forms.Label Passl;
        private System.Windows.Forms.TextBox Appname;
        private System.Windows.Forms.Label Applab;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Counter;
        private System.Windows.Forms.Label NoInfo;
        private System.Windows.Forms.Label Counterl;
    }
}