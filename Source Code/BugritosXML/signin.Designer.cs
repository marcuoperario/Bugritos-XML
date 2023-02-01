
namespace BugritosXML
{
    partial class signin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.create_account = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.email_textbox = new BugritosXML.RoundedTextbox();
            this.password_textbox = new BugritosXML.RoundedPasswordTextBox();
            this.signin_button = new BugritosXML.ButtonRadius();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(560, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Barlow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(786, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sign in";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Barlow SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(723, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Not yet registered?";
            // 
            // create_account
            // 
            this.create_account.AutoSize = true;
            this.create_account.BackColor = System.Drawing.Color.Transparent;
            this.create_account.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create_account.Font = new System.Drawing.Font("Barlow SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_account.ForeColor = System.Drawing.Color.Crimson;
            this.create_account.Location = new System.Drawing.Point(865, 442);
            this.create_account.Name = "create_account";
            this.create_account.Size = new System.Drawing.Size(73, 26);
            this.create_account.TabIndex = 7;
            this.create_account.Text = "Sign up";
            this.create_account.Click += new System.EventHandler(this.create_account_Click);
            this.create_account.MouseLeave += new System.EventHandler(this.create_account_MouseLeave);
            this.create_account.MouseHover += new System.EventHandler(this.create_account_MouseHover);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Barlow SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(703, 545);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(262, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "© 2021 Bugrito\'s. All rights reserved";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Barlow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(656, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 33);
            this.label4.TabIndex = 14;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Barlow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(656, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 33);
            this.label5.TabIndex = 15;
            this.label5.Text = "Password";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Barlow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Crimson;
            this.exit.Location = new System.Drawing.Point(791, 486);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(99, 50);
            this.exit.TabIndex = 18;
            this.exit.Text = "EXIT";
            this.exit.Click += new System.EventHandler(this.label3_Click);
            this.exit.MouseLeave += new System.EventHandler(this.exit_MouseLeave);
            this.exit.MouseHover += new System.EventHandler(this.exit_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Barlow Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(772, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 50);
            this.label3.TabIndex = 19;
            this.label3.Text = "Bugrito\'s";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(808, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(209, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.Visible = false;
            // 
            // email_textbox
            // 
            this.email_textbox.BackColor = System.Drawing.SystemColors.Window;
            this.email_textbox.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.email_textbox.BorderFocusColor = System.Drawing.Color.Black;
            this.email_textbox.BorderRadius = 0;
            this.email_textbox.BorderSize = 2;
            this.email_textbox.Font = new System.Drawing.Font("Barlow SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_textbox.Location = new System.Drawing.Point(665, 219);
            this.email_textbox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.email_textbox.Multiline = false;
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.email_textbox.PasswordChar = false;
            this.email_textbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.email_textbox.PlaceholderText = "";
            this.email_textbox.Size = new System.Drawing.Size(352, 43);
            this.email_textbox.TabIndex = 17;
            this.email_textbox.Texts = "";
            this.email_textbox.UnderlinedStyle = false;
            this.email_textbox.Enter += new System.EventHandler(this.email_textbox_Enter);
            this.email_textbox.Leave += new System.EventHandler(this.email_textbox_Leave);
            // 
            // password_textbox
            // 
            this.password_textbox.BackColor = System.Drawing.SystemColors.Window;
            this.password_textbox.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.password_textbox.BorderFocusColor = System.Drawing.Color.Black;
            this.password_textbox.BorderRadius = 0;
            this.password_textbox.BorderSize = 2;
            this.password_textbox.Font = new System.Drawing.Font("Barlow SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.password_textbox.ForeColor = System.Drawing.Color.Black;
            this.password_textbox.Location = new System.Drawing.Point(665, 316);
            this.password_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.password_textbox.Multiline = false;
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Padding = new System.Windows.Forms.Padding(7);
            this.password_textbox.PasswordChar = false;
            this.password_textbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.password_textbox.PlaceholderText = "";
            this.password_textbox.Size = new System.Drawing.Size(352, 44);
            this.password_textbox.TabIndex = 16;
            this.password_textbox.Texts = "";
            this.password_textbox.UnderlinedStyle = false;
            this.password_textbox.Enter += new System.EventHandler(this.password_textbox_Enter);
            this.password_textbox.Leave += new System.EventHandler(this.password_textbox_Leave);
            // 
            // signin_button
            // 
            this.signin_button.BackColor = System.Drawing.Color.Gainsboro;
            this.signin_button.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.signin_button.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.signin_button.BorderRadius = 20;
            this.signin_button.BorderSize = 0;
            this.signin_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signin_button.Enabled = false;
            this.signin_button.FlatAppearance.BorderSize = 0;
            this.signin_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signin_button.Font = new System.Drawing.Font("Barlow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin_button.ForeColor = System.Drawing.Color.Gray;
            this.signin_button.Location = new System.Drawing.Point(665, 377);
            this.signin_button.Name = "signin_button";
            this.signin_button.Size = new System.Drawing.Size(352, 48);
            this.signin_button.TabIndex = 11;
            this.signin_button.TabStop = false;
            this.signin_button.Text = "SIGN IN";
            this.signin_button.TextColor = System.Drawing.Color.Gray;
            this.signin_button.UseVisualStyleBackColor = false;
            this.signin_button.Click += new System.EventHandler(this.buttonRadius1_Click);
            // 
            // signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1120, 600);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.signin_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.create_account);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "signin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.signin_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseHover += new System.EventHandler(this.signin_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label create_account;
        private System.Windows.Forms.Label label6;
        private ButtonRadius signin_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private RoundedPasswordTextBox password_textbox;
        private RoundedTextbox email_textbox;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

