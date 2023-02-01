
namespace BugritosXML
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.navbar_panel = new System.Windows.Forms.Panel();
            this.profile_button = new BugritosXML.ButtonRadius();
            this.siteinfo_button = new BugritosXML.ButtonRadius();
            this.url_textbox = new BugritosXML.RoundedTextbox();
            this.fbpage_button = new BugritosXML.ButtonRadius();
            this.webapp_button = new BugritosXML.ButtonRadius();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sidebar_panel = new System.Windows.Forms.Panel();
            this.home1 = new BugritosXML.Home();
            this.profile1 = new BugritosXML.Profile();
            this.products1 = new BugritosXML.Products();
            this.transactions1 = new BugritosXML.Transactions();
            this.employees1 = new BugritosXML.Employees();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.employees_button = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.products_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.transactions_button = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.home_button = new System.Windows.Forms.Button();
            this.userModal1 = new BugritosXML.UserModal();
            this.dashboard_panel = new System.Windows.Forms.Panel();
            this.content_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.browserModal1 = new BugritosXML.BrowserModal();
            this.navbar_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.sidebar_panel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.dashboard_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navbar_panel
            // 
            this.navbar_panel.BackColor = System.Drawing.Color.Crimson;
            this.navbar_panel.Controls.Add(this.profile_button);
            this.navbar_panel.Controls.Add(this.siteinfo_button);
            this.navbar_panel.Controls.Add(this.url_textbox);
            this.navbar_panel.Controls.Add(this.fbpage_button);
            this.navbar_panel.Controls.Add(this.webapp_button);
            this.navbar_panel.Controls.Add(this.label3);
            this.navbar_panel.Controls.Add(this.pictureBox2);
            this.navbar_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navbar_panel.Location = new System.Drawing.Point(0, 0);
            this.navbar_panel.Name = "navbar_panel";
            this.navbar_panel.Size = new System.Drawing.Size(1120, 61);
            this.navbar_panel.TabIndex = 0;
            // 
            // profile_button
            // 
            this.profile_button.AllowDrop = true;
            this.profile_button.BackColor = System.Drawing.Color.Crimson;
            this.profile_button.BackgroundColor = System.Drawing.Color.Crimson;
            this.profile_button.BorderColor = System.Drawing.Color.Transparent;
            this.profile_button.BorderRadius = 20;
            this.profile_button.BorderSize = 0;
            this.profile_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profile_button.FlatAppearance.BorderSize = 0;
            this.profile_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profile_button.Font = new System.Drawing.Font("Barlow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_button.ForeColor = System.Drawing.Color.White;
            this.profile_button.Image = ((System.Drawing.Image)(resources.GetObject("profile_button.Image")));
            this.profile_button.Location = new System.Drawing.Point(929, 3);
            this.profile_button.Name = "profile_button";
            this.profile_button.Size = new System.Drawing.Size(179, 53);
            this.profile_button.TabIndex = 5;
            this.profile_button.TabStop = false;
            this.profile_button.Text = "Name";
            this.profile_button.TextColor = System.Drawing.Color.White;
            this.profile_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.profile_button.UseVisualStyleBackColor = false;
            this.profile_button.Click += new System.EventHandler(this.profile_button_Click);
            // 
            // siteinfo_button
            // 
            this.siteinfo_button.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.siteinfo_button.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.siteinfo_button.BorderColor = System.Drawing.Color.Transparent;
            this.siteinfo_button.BorderRadius = 5;
            this.siteinfo_button.BorderSize = -1;
            this.siteinfo_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siteinfo_button.FlatAppearance.BorderSize = 0;
            this.siteinfo_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siteinfo_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.siteinfo_button.Image = ((System.Drawing.Image)(resources.GetObject("siteinfo_button.Image")));
            this.siteinfo_button.Location = new System.Drawing.Point(221, 14);
            this.siteinfo_button.Name = "siteinfo_button";
            this.siteinfo_button.Padding = new System.Windows.Forms.Padding(20);
            this.siteinfo_button.Size = new System.Drawing.Size(46, 33);
            this.siteinfo_button.TabIndex = 47;
            this.siteinfo_button.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.siteinfo_button.UseVisualStyleBackColor = false;
            this.siteinfo_button.Click += new System.EventHandler(this.siteinfo_button_Click);
            // 
            // url_textbox
            // 
            this.url_textbox.AutoSize = true;
            this.url_textbox.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.url_textbox.BackColor = System.Drawing.Color.White;
            this.url_textbox.BorderColor = System.Drawing.Color.Transparent;
            this.url_textbox.BorderFocusColor = System.Drawing.Color.Transparent;
            this.url_textbox.BorderRadius = 5;
            this.url_textbox.BorderSize = 1;
            this.url_textbox.CausesValidation = false;
            this.url_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.url_textbox.Enabled = false;
            this.url_textbox.Font = new System.Drawing.Font("Barlow SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.url_textbox.Location = new System.Drawing.Point(262, 14);
            this.url_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.url_textbox.Multiline = false;
            this.url_textbox.Name = "url_textbox";
            this.url_textbox.Padding = new System.Windows.Forms.Padding(15, 7, 7, 7);
            this.url_textbox.PasswordChar = false;
            this.url_textbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.url_textbox.PlaceholderText = "";
            this.url_textbox.Size = new System.Drawing.Size(474, 32);
            this.url_textbox.TabIndex = 0;
            this.url_textbox.Texts = "https://www.bugritosapp.com/home";
            this.url_textbox.UnderlinedStyle = false;
            // 
            // fbpage_button
            // 
            this.fbpage_button.BackColor = System.Drawing.Color.Crimson;
            this.fbpage_button.BackgroundColor = System.Drawing.Color.Crimson;
            this.fbpage_button.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.fbpage_button.BorderRadius = 10;
            this.fbpage_button.BorderSize = 0;
            this.fbpage_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fbpage_button.FlatAppearance.BorderSize = 0;
            this.fbpage_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbpage_button.Font = new System.Drawing.Font("Barlow SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbpage_button.ForeColor = System.Drawing.Color.White;
            this.fbpage_button.Location = new System.Drawing.Point(839, 9);
            this.fbpage_button.Name = "fbpage_button";
            this.fbpage_button.Size = new System.Drawing.Size(84, 35);
            this.fbpage_button.TabIndex = 5;
            this.fbpage_button.TabStop = false;
            this.fbpage_button.Text = "FB Page";
            this.fbpage_button.TextColor = System.Drawing.Color.White;
            this.fbpage_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.fbpage_button.UseVisualStyleBackColor = false;
            this.fbpage_button.Click += new System.EventHandler(this.fbpage_button_Click);
            // 
            // webapp_button
            // 
            this.webapp_button.BackColor = System.Drawing.Color.Crimson;
            this.webapp_button.BackgroundColor = System.Drawing.Color.Crimson;
            this.webapp_button.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.webapp_button.BorderRadius = 10;
            this.webapp_button.BorderSize = 0;
            this.webapp_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.webapp_button.FlatAppearance.BorderSize = 0;
            this.webapp_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.webapp_button.Font = new System.Drawing.Font("Barlow SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webapp_button.ForeColor = System.Drawing.Color.White;
            this.webapp_button.Location = new System.Drawing.Point(743, 9);
            this.webapp_button.Name = "webapp_button";
            this.webapp_button.Size = new System.Drawing.Size(86, 35);
            this.webapp_button.TabIndex = 4;
            this.webapp_button.TabStop = false;
            this.webapp_button.Text = "Web App";
            this.webapp_button.TextColor = System.Drawing.Color.White;
            this.webapp_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.webapp_button.UseVisualStyleBackColor = false;
            this.webapp_button.Click += new System.EventHandler(this.webapp_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Barlow Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(70, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 39);
            this.label3.TabIndex = 40;
            this.label3.Text = "Bugrito\'s";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // sidebar_panel
            // 
            this.sidebar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(52)))));
            this.sidebar_panel.Controls.Add(this.home1);
            this.sidebar_panel.Controls.Add(this.profile1);
            this.sidebar_panel.Controls.Add(this.products1);
            this.sidebar_panel.Controls.Add(this.transactions1);
            this.sidebar_panel.Controls.Add(this.employees1);
            this.sidebar_panel.Controls.Add(this.label1);
            this.sidebar_panel.Controls.Add(this.label6);
            this.sidebar_panel.Controls.Add(this.panel6);
            this.sidebar_panel.Controls.Add(this.panel3);
            this.sidebar_panel.Controls.Add(this.panel2);
            this.sidebar_panel.Controls.Add(this.panel4);
            this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar_panel.Location = new System.Drawing.Point(0, 61);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.Size = new System.Drawing.Size(222, 621);
            this.sidebar_panel.TabIndex = 2;
            // 
            // home1
            // 
            this.home1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.home1.Location = new System.Drawing.Point(-32768, 362);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(898, 956);
            this.home1.TabIndex = 46;
            // 
            // profile1
            // 
            this.profile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.profile1.Location = new System.Drawing.Point(-32768, 362);
            this.profile1.Name = "profile1";
            this.profile1.Size = new System.Drawing.Size(898, 612);
            this.profile1.TabIndex = 0;
            // 
            // products1
            // 
            this.products1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.products1.Location = new System.Drawing.Point(-32768, 362);
            this.products1.Name = "products1";
            this.products1.Size = new System.Drawing.Size(898, 760);
            this.products1.TabIndex = 0;
            this.products1.TabStop = false;
            this.products1.EnabledChanged += new System.EventHandler(this.products1_EnabledChanged);
            // 
            // transactions1
            // 
            this.transactions1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.transactions1.Location = new System.Drawing.Point(-32768, 362);
            this.transactions1.Name = "transactions1";
            this.transactions1.Size = new System.Drawing.Size(898, 760);
            this.transactions1.TabIndex = 0;
            this.transactions1.TabStop = false;
            // 
            // employees1
            // 
            this.employees1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.employees1.Location = new System.Drawing.Point(-32768, 362);
            this.employees1.Name = "employees1";
            this.employees1.Size = new System.Drawing.Size(898, 760);
            this.employees1.TabIndex = 0;
            this.employees1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Barlow Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 555);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 28);
            this.label1.TabIndex = 44;
            this.label1.Text = "Bugrito\'s IMS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Barlow SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(71, 583);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "VERSION 1.0";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel6.Controls.Add(this.employees_button);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 192);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(222, 64);
            this.panel6.TabIndex = 43;
            // 
            // employees_button
            // 
            this.employees_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(52)))));
            this.employees_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.employees_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employees_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employees_button.FlatAppearance.BorderSize = 0;
            this.employees_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employees_button.Font = new System.Drawing.Font("Barlow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employees_button.ForeColor = System.Drawing.Color.White;
            this.employees_button.Image = ((System.Drawing.Image)(resources.GetObject("employees_button.Image")));
            this.employees_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employees_button.Location = new System.Drawing.Point(0, 0);
            this.employees_button.Name = "employees_button";
            this.employees_button.Padding = new System.Windows.Forms.Padding(30, 15, 35, 15);
            this.employees_button.Size = new System.Drawing.Size(222, 64);
            this.employees_button.TabIndex = 37;
            this.employees_button.TabStop = false;
            this.employees_button.Text = "Employees";
            this.employees_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.employees_button.UseVisualStyleBackColor = false;
            this.employees_button.Click += new System.EventHandler(this.employees_button_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.products_button);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(222, 64);
            this.panel3.TabIndex = 42;
            // 
            // products_button
            // 
            this.products_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(52)))));
            this.products_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.products_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.products_button.FlatAppearance.BorderSize = 0;
            this.products_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.products_button.Font = new System.Drawing.Font("Barlow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products_button.ForeColor = System.Drawing.Color.White;
            this.products_button.Image = ((System.Drawing.Image)(resources.GetObject("products_button.Image")));
            this.products_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.products_button.Location = new System.Drawing.Point(0, 0);
            this.products_button.Name = "products_button";
            this.products_button.Padding = new System.Windows.Forms.Padding(30, 15, 50, 15);
            this.products_button.Size = new System.Drawing.Size(222, 64);
            this.products_button.TabIndex = 36;
            this.products_button.TabStop = false;
            this.products_button.Text = "Products";
            this.products_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.products_button.UseVisualStyleBackColor = false;
            this.products_button.Click += new System.EventHandler(this.products_button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.transactions_button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 64);
            this.panel2.TabIndex = 42;
            // 
            // transactions_button
            // 
            this.transactions_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(52)))));
            this.transactions_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transactions_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactions_button.FlatAppearance.BorderSize = 0;
            this.transactions_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactions_button.Font = new System.Drawing.Font("Barlow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactions_button.ForeColor = System.Drawing.Color.White;
            this.transactions_button.Image = ((System.Drawing.Image)(resources.GetObject("transactions_button.Image")));
            this.transactions_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transactions_button.Location = new System.Drawing.Point(0, 0);
            this.transactions_button.Name = "transactions_button";
            this.transactions_button.Padding = new System.Windows.Forms.Padding(30, 15, 19, 15);
            this.transactions_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.transactions_button.Size = new System.Drawing.Size(222, 64);
            this.transactions_button.TabIndex = 35;
            this.transactions_button.TabStop = false;
            this.transactions_button.Text = "Transactions";
            this.transactions_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.transactions_button.UseVisualStyleBackColor = false;
            this.transactions_button.Click += new System.EventHandler(this.transactions_button_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.home_button);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(222, 64);
            this.panel4.TabIndex = 41;
            // 
            // home_button
            // 
            this.home_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(52)))));
            this.home_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home_button.Dock = System.Windows.Forms.DockStyle.Left;
            this.home_button.FlatAppearance.BorderSize = 0;
            this.home_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_button.Font = new System.Drawing.Font("Barlow", 14.25F, System.Drawing.FontStyle.Bold);
            this.home_button.ForeColor = System.Drawing.Color.White;
            this.home_button.Image = ((System.Drawing.Image)(resources.GetObject("home_button.Image")));
            this.home_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_button.Location = new System.Drawing.Point(0, 0);
            this.home_button.Name = "home_button";
            this.home_button.Padding = new System.Windows.Forms.Padding(30, 15, 75, 15);
            this.home_button.Size = new System.Drawing.Size(222, 64);
            this.home_button.TabIndex = 34;
            this.home_button.TabStop = false;
            this.home_button.Text = "Home";
            this.home_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.home_button.UseVisualStyleBackColor = false;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // userModal1
            // 
            this.userModal1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.userModal1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.userModal1.Location = new System.Drawing.Point(768, 61);
            this.userModal1.Name = "userModal1";
            this.userModal1.Size = new System.Drawing.Size(349, 301);
            this.userModal1.TabIndex = 47;
            this.userModal1.Visible = false;
            this.userModal1.EnabledChanged += new System.EventHandler(this.userModal1_EnabledChanged);
            this.userModal1.Leave += new System.EventHandler(this.userModal1_Leave);
            // 
            // dashboard_panel
            // 
            this.dashboard_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dashboard_panel.Controls.Add(this.content_panel);
            this.dashboard_panel.Controls.Add(this.browserModal1);
            this.dashboard_panel.Controls.Add(this.userModal1);
            this.dashboard_panel.Controls.Add(this.sidebar_panel);
            this.dashboard_panel.Controls.Add(this.navbar_panel);
            this.dashboard_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard_panel.Location = new System.Drawing.Point(0, 0);
            this.dashboard_panel.Name = "dashboard_panel";
            this.dashboard_panel.Size = new System.Drawing.Size(1120, 682);
            this.dashboard_panel.TabIndex = 2;
            // 
            // content_panel
            // 
            this.content_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.content_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content_panel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.content_panel.Location = new System.Drawing.Point(222, 61);
            this.content_panel.Name = "content_panel";
            this.content_panel.Size = new System.Drawing.Size(898, 621);
            this.content_panel.TabIndex = 49;
            // 
            // browserModal1
            // 
            this.browserModal1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.browserModal1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.browserModal1.Location = new System.Drawing.Point(221, 61);
            this.browserModal1.Name = "browserModal1";
            this.browserModal1.Size = new System.Drawing.Size(333, 218);
            this.browserModal1.TabIndex = 48;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1120, 682);
            this.Controls.Add(this.dashboard_panel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.navbar_panel.ResumeLayout(false);
            this.navbar_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.sidebar_panel.ResumeLayout(false);
            this.sidebar_panel.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.dashboard_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navbar_panel;
        private ButtonRadius fbpage_button;
        private ButtonRadius webapp_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel sidebar_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button employees_button;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button products_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button transactions_button;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.Panel dashboard_panel;
        private ButtonRadius siteinfo_button;
        public RoundedTextbox url_textbox;
        private Employees employees1;
        private Profile profile1;
        private Products products1;
        private Transactions transactions1;
        private Home home1;
        public ButtonRadius profile_button;
        private UserModal userModal1;
        private System.Windows.Forms.FlowLayoutPanel content_panel;
        private BrowserModal browserModal1;
    }
}