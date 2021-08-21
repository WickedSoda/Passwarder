
namespace Passwarder
{
    partial class Pass_add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pass_add));
            this.Uppermenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Icons = new System.Windows.Forms.Panel();
            this.Minibtn = new System.Windows.Forms.Button();
            this.Closebtn = new System.Windows.Forms.Button();
            this.Appname = new System.Windows.Forms.TextBox();
            this.Applab = new System.Windows.Forms.Label();
            this.Passw = new System.Windows.Forms.TextBox();
            this.Passl = new System.Windows.Forms.Label();
            this.Strength = new System.Windows.Forms.Label();
            this.Passdatagrid = new System.Windows.Forms.DataGridView();
            this.Lengthl = new System.Windows.Forms.Label();
            this.Lengthext = new System.Windows.Forms.Label();
            this.Backbtn = new System.Windows.Forms.Button();
            this.Inserter = new System.Windows.Forms.Button();
            this.Startdate = new System.Windows.Forms.Label();
            this.Enddate = new System.Windows.Forms.Label();
            this.Startdateorg = new System.Windows.Forms.Label();
            this.Enddateorg = new System.Windows.Forms.Label();
            this.Passhow = new System.Windows.Forms.CheckBox();
            this.Uppermenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Passdatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Uppermenu
            // 
            this.Uppermenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(131)))), ((int)(((byte)(171)))));
            this.Uppermenu.Controls.Add(this.label1);
            this.Uppermenu.Controls.Add(this.Icons);
            this.Uppermenu.Controls.Add(this.Minibtn);
            this.Uppermenu.Controls.Add(this.Closebtn);
            this.Uppermenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Uppermenu.Location = new System.Drawing.Point(0, 0);
            this.Uppermenu.Name = "Uppermenu";
            this.Uppermenu.Size = new System.Drawing.Size(1118, 36);
            this.Uppermenu.TabIndex = 2;
            this.Uppermenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Uppermenu_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(39, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 26);
            this.label1.TabIndex = 26;
            this.label1.Text = "Add Password";
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
            // Appname
            // 
            this.Appname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Appname.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appname.Location = new System.Drawing.Point(221, 87);
            this.Appname.MaxLength = 20;
            this.Appname.Name = "Appname";
            this.Appname.Size = new System.Drawing.Size(355, 31);
            this.Appname.TabIndex = 25;
            // 
            // Applab
            // 
            this.Applab.AutoSize = true;
            this.Applab.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Applab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Applab.Location = new System.Drawing.Point(39, 90);
            this.Applab.Name = "Applab";
            this.Applab.Size = new System.Drawing.Size(176, 26);
            this.Applab.TabIndex = 24;
            this.Applab.Text = "Application Name:";
            // 
            // Passw
            // 
            this.Passw.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passw.Location = new System.Drawing.Point(150, 153);
            this.Passw.MaxLength = 35;
            this.Passw.Name = "Passw";
            this.Passw.Size = new System.Drawing.Size(426, 31);
            this.Passw.TabIndex = 27;
            this.Passw.UseSystemPasswordChar = true;
            this.Passw.TextChanged += new System.EventHandler(this.Passw_TextChanged);
            // 
            // Passl
            // 
            this.Passl.AutoSize = true;
            this.Passl.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Passl.Location = new System.Drawing.Point(39, 156);
            this.Passl.Name = "Passl";
            this.Passl.Size = new System.Drawing.Size(105, 26);
            this.Passl.TabIndex = 26;
            this.Passl.Text = "Password:";
            // 
            // Strength
            // 
            this.Strength.AutoSize = true;
            this.Strength.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Strength.ForeColor = System.Drawing.Color.IndianRed;
            this.Strength.Location = new System.Drawing.Point(151, 187);
            this.Strength.Name = "Strength";
            this.Strength.Size = new System.Drawing.Size(0, 19);
            this.Strength.TabIndex = 28;
            // 
            // Passdatagrid
            // 
            this.Passdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Passdatagrid.Location = new System.Drawing.Point(44, 253);
            this.Passdatagrid.Name = "Passdatagrid";
            this.Passdatagrid.Size = new System.Drawing.Size(1033, 417);
            this.Passdatagrid.TabIndex = 29;
            // 
            // Lengthl
            // 
            this.Lengthl.AutoSize = true;
            this.Lengthl.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lengthl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lengthl.Location = new System.Drawing.Point(39, 199);
            this.Lengthl.Name = "Lengthl";
            this.Lengthl.Size = new System.Drawing.Size(78, 26);
            this.Lengthl.TabIndex = 30;
            this.Lengthl.Text = "Length:";
            // 
            // Lengthext
            // 
            this.Lengthext.AutoSize = true;
            this.Lengthext.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lengthext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lengthext.Location = new System.Drawing.Point(120, 199);
            this.Lengthext.Name = "Lengthext";
            this.Lengthext.Size = new System.Drawing.Size(24, 26);
            this.Lengthext.TabIndex = 31;
            this.Lengthext.Text = "0";
            // 
            // Backbtn
            // 
            this.Backbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backbtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.Location = new System.Drawing.Point(778, 207);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(140, 40);
            this.Backbtn.TabIndex = 32;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = false;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // Inserter
            // 
            this.Inserter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Inserter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inserter.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inserter.Location = new System.Drawing.Point(937, 207);
            this.Inserter.Name = "Inserter";
            this.Inserter.Size = new System.Drawing.Size(140, 40);
            this.Inserter.TabIndex = 33;
            this.Inserter.Text = "Insert";
            this.Inserter.UseVisualStyleBackColor = false;
            this.Inserter.Click += new System.EventHandler(this.Inserter_Click);
            // 
            // Startdate
            // 
            this.Startdate.AutoSize = true;
            this.Startdate.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Startdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Startdate.Location = new System.Drawing.Point(642, 90);
            this.Startdate.Name = "Startdate";
            this.Startdate.Size = new System.Drawing.Size(64, 16);
            this.Startdate.TabIndex = 34;
            this.Startdate.Text = "Initial date:";
            // 
            // Enddate
            // 
            this.Enddate.AutoSize = true;
            this.Enddate.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enddate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Enddate.Location = new System.Drawing.Point(640, 115);
            this.Enddate.Name = "Enddate";
            this.Enddate.Size = new System.Drawing.Size(66, 16);
            this.Enddate.TabIndex = 35;
            this.Enddate.Text = "Expire date:";
            // 
            // Startdateorg
            // 
            this.Startdateorg.AutoSize = true;
            this.Startdateorg.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Startdateorg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Startdateorg.Location = new System.Drawing.Point(712, 90);
            this.Startdateorg.Name = "Startdateorg";
            this.Startdateorg.Size = new System.Drawing.Size(15, 16);
            this.Startdateorg.TabIndex = 36;
            this.Startdateorg.Text = "0";
            // 
            // Enddateorg
            // 
            this.Enddateorg.AutoSize = true;
            this.Enddateorg.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enddateorg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Enddateorg.Location = new System.Drawing.Point(712, 115);
            this.Enddateorg.Name = "Enddateorg";
            this.Enddateorg.Size = new System.Drawing.Size(15, 16);
            this.Enddateorg.TabIndex = 37;
            this.Enddateorg.Text = "0";
            // 
            // Passhow
            // 
            this.Passhow.AutoSize = true;
            this.Passhow.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passhow.Location = new System.Drawing.Point(582, 159);
            this.Passhow.Name = "Passhow";
            this.Passhow.Size = new System.Drawing.Size(114, 21);
            this.Passhow.TabIndex = 38;
            this.Passhow.Text = "Show Password";
            this.Passhow.UseVisualStyleBackColor = true;
            this.Passhow.CheckedChanged += new System.EventHandler(this.Passhow_CheckedChanged);
            // 
            // Pass_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 698);
            this.Controls.Add(this.Passhow);
            this.Controls.Add(this.Enddateorg);
            this.Controls.Add(this.Startdateorg);
            this.Controls.Add(this.Enddate);
            this.Controls.Add(this.Startdate);
            this.Controls.Add(this.Inserter);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.Lengthext);
            this.Controls.Add(this.Lengthl);
            this.Controls.Add(this.Passdatagrid);
            this.Controls.Add(this.Strength);
            this.Controls.Add(this.Passw);
            this.Controls.Add(this.Passl);
            this.Controls.Add(this.Appname);
            this.Controls.Add(this.Applab);
            this.Controls.Add(this.Uppermenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pass_add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Password";
            this.Load += new System.EventHandler(this.Pass_add_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pass_add_MouseDown);
            this.Uppermenu.ResumeLayout(false);
            this.Uppermenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Passdatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Uppermenu;
        private System.Windows.Forms.Panel Icons;
        private System.Windows.Forms.Button Minibtn;
        private System.Windows.Forms.Button Closebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Appname;
        private System.Windows.Forms.Label Applab;
        private System.Windows.Forms.TextBox Passw;
        private System.Windows.Forms.Label Passl;
        private System.Windows.Forms.Label Strength;
        private System.Windows.Forms.DataGridView Passdatagrid;
        private System.Windows.Forms.Label Lengthl;
        private System.Windows.Forms.Label Lengthext;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Button Inserter;
        private System.Windows.Forms.Label Startdate;
        private System.Windows.Forms.Label Enddate;
        private System.Windows.Forms.Label Startdateorg;
        private System.Windows.Forms.Label Enddateorg;
        private System.Windows.Forms.CheckBox Passhow;
    }
}