
namespace Passwarder
{
    partial class Pass_random
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pass_random));
            this.Uppermenu = new System.Windows.Forms.Panel();
            this.Infotxt = new System.Windows.Forms.Label();
            this.Icons = new System.Windows.Forms.Panel();
            this.Minibtn = new System.Windows.Forms.Button();
            this.Closebtn = new System.Windows.Forms.Button();
            this.Uppermenu.SuspendLayout();
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
            this.Uppermenu.TabIndex = 4;
            // 
            // Infotxt
            // 
            this.Infotxt.AutoSize = true;
            this.Infotxt.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Infotxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Infotxt.Location = new System.Drawing.Point(39, 7);
            this.Infotxt.Name = "Infotxt";
            this.Infotxt.Size = new System.Drawing.Size(181, 26);
            this.Infotxt.TabIndex = 26;
            this.Infotxt.Text = "Random Password";
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
            // Pass_random
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 698);
            this.Controls.Add(this.Uppermenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pass_random";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pass_random";
            this.Uppermenu.ResumeLayout(false);
            this.Uppermenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Uppermenu;
        private System.Windows.Forms.Label Infotxt;
        private System.Windows.Forms.Panel Icons;
        private System.Windows.Forms.Button Minibtn;
        private System.Windows.Forms.Button Closebtn;
    }
}