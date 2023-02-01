
namespace BugritosXML
{
    partial class UserModal
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserModal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.name_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.viewprofile_button = new BugritosXML.ButtonRadius();
            this.signout_button = new BugritosXML.ButtonRadius();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(128, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // name_label
            // 
            this.name_label.BackColor = System.Drawing.Color.Transparent;
            this.name_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name_label.Font = new System.Drawing.Font("Barlow Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.ForeColor = System.Drawing.Color.White;
            this.name_label.Location = new System.Drawing.Point(0, 0);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(348, 43);
            this.name_label.TabIndex = 50;
            this.name_label.Text = "Name";
            this.name_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // email_label
            // 
            this.email_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.email_label.Font = new System.Drawing.Font("Barlow SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.ForeColor = System.Drawing.Color.White;
            this.email_label.Location = new System.Drawing.Point(0, 0);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(348, 51);
            this.email_label.TabIndex = 51;
            this.email_label.Text = "Email";
            this.email_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.name_label);
            this.panel1.Location = new System.Drawing.Point(1, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 43);
            this.panel1.TabIndex = 52;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.email_label);
            this.panel2.Location = new System.Drawing.Point(1, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 51);
            this.panel2.TabIndex = 53;
            // 
            // viewprofile_button
            // 
            this.viewprofile_button.BackColor = System.Drawing.Color.White;
            this.viewprofile_button.BackgroundColor = System.Drawing.Color.White;
            this.viewprofile_button.BorderColor = System.Drawing.Color.Black;
            this.viewprofile_button.BorderRadius = 10;
            this.viewprofile_button.BorderSize = 0;
            this.viewprofile_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewprofile_button.FlatAppearance.BorderSize = 0;
            this.viewprofile_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewprofile_button.Font = new System.Drawing.Font("Barlow SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewprofile_button.ForeColor = System.Drawing.Color.Black;
            this.viewprofile_button.Location = new System.Drawing.Point(39, 24);
            this.viewprofile_button.Name = "viewprofile_button";
            this.viewprofile_button.Size = new System.Drawing.Size(139, 38);
            this.viewprofile_button.TabIndex = 51;
            this.viewprofile_button.TabStop = false;
            this.viewprofile_button.Text = "View profile";
            this.viewprofile_button.TextColor = System.Drawing.Color.Black;
            this.viewprofile_button.UseVisualStyleBackColor = false;
            this.viewprofile_button.Click += new System.EventHandler(this.viewprofile_button_Click);
            // 
            // signout_button
            // 
            this.signout_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(24)))), ((int)(((byte)(72)))));
            this.signout_button.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(24)))), ((int)(((byte)(72)))));
            this.signout_button.BorderColor = System.Drawing.Color.Transparent;
            this.signout_button.BorderRadius = 10;
            this.signout_button.BorderSize = 0;
            this.signout_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signout_button.FlatAppearance.BorderSize = 0;
            this.signout_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signout_button.Font = new System.Drawing.Font("Barlow SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signout_button.ForeColor = System.Drawing.Color.White;
            this.signout_button.Location = new System.Drawing.Point(184, 24);
            this.signout_button.Name = "signout_button";
            this.signout_button.Size = new System.Drawing.Size(139, 38);
            this.signout_button.TabIndex = 54;
            this.signout_button.TabStop = false;
            this.signout_button.Text = "Sign out";
            this.signout_button.TextColor = System.Drawing.Color.White;
            this.signout_button.UseVisualStyleBackColor = false;
            this.signout_button.Click += new System.EventHandler(this.signout_button_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.viewprofile_button);
            this.panel3.Controls.Add(this.signout_button);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 208);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(349, 93);
            this.panel3.TabIndex = 55;
            // 
            // UserModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Name = "UserModal";
            this.Size = new System.Drawing.Size(349, 301);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private ButtonRadius signout_button;
        private System.Windows.Forms.Panel panel3;
        public ButtonRadius viewprofile_button;
        public System.Windows.Forms.Label name_label;
        public System.Windows.Forms.Label email_label;
    }
}
