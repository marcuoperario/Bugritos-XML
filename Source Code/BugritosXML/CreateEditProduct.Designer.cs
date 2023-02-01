
namespace BugritosXML
{
    partial class CreateEditProduct
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
            this.name_label = new System.Windows.Forms.Label();
            this.name_textbox = new BugritosXML.RoundedTextbox();
            this.cancel_button = new BugritosXML.ButtonRadius();
            this.label1 = new System.Windows.Forms.Label();
            this.save_button = new BugritosXML.ButtonRadius();
            this.type_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.price_textbox = new BugritosXML.RoundedTextbox();
            this.type_combobox = new CustomComboBox.RJComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.BackColor = System.Drawing.Color.Transparent;
            this.name_label.Font = new System.Drawing.Font("Barlow SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.name_label.Location = new System.Drawing.Point(56, 72);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(51, 22);
            this.name_label.TabIndex = 10;
            this.name_label.Text = "Name";
            this.name_label.Visible = false;
            // 
            // name_textbox
            // 
            this.name_textbox.BackColor = System.Drawing.SystemColors.Window;
            this.name_textbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(134)))), ((int)(((byte)(139)))));
            this.name_textbox.BorderFocusColor = System.Drawing.Color.Transparent;
            this.name_textbox.BorderRadius = 0;
            this.name_textbox.BorderSize = 3;
            this.name_textbox.Font = new System.Drawing.Font("Barlow SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(134)))), ((int)(((byte)(139)))));
            this.name_textbox.Location = new System.Drawing.Point(33, 81);
            this.name_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.name_textbox.Multiline = false;
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Padding = new System.Windows.Forms.Padding(15);
            this.name_textbox.PasswordChar = false;
            this.name_textbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.name_textbox.PlaceholderText = "";
            this.name_textbox.Size = new System.Drawing.Size(307, 57);
            this.name_textbox.TabIndex = 6;
            this.name_textbox.Texts = "Name";
            this.name_textbox.UnderlinedStyle = false;
            this.name_textbox.Enter += new System.EventHandler(this.name_textbox_Enter);
            this.name_textbox.Leave += new System.EventHandler(this.name_textbox_Leave);
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.Color.Transparent;
            this.cancel_button.BackgroundColor = System.Drawing.Color.Transparent;
            this.cancel_button.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cancel_button.BorderRadius = 10;
            this.cancel_button.BorderSize = 0;
            this.cancel_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_button.FlatAppearance.BorderSize = 0;
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_button.Font = new System.Drawing.Font("Barlow SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.ForeColor = System.Drawing.Color.Black;
            this.cancel_button.Location = new System.Drawing.Point(137, 368);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(101, 40);
            this.cancel_button.TabIndex = 9;
            this.cancel_button.TabStop = false;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.TextColor = System.Drawing.Color.Black;
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Barlow SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(33, 34);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(94, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "PRODUCT";
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(24)))), ((int)(((byte)(72)))));
            this.save_button.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(24)))), ((int)(((byte)(72)))));
            this.save_button.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.save_button.BorderRadius = 10;
            this.save_button.BorderSize = 0;
            this.save_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_button.FlatAppearance.BorderSize = 0;
            this.save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_button.Font = new System.Drawing.Font("Barlow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_button.ForeColor = System.Drawing.Color.White;
            this.save_button.Location = new System.Drawing.Point(244, 368);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(101, 40);
            this.save_button.TabIndex = 7;
            this.save_button.TabStop = false;
            this.save_button.Text = "Save";
            this.save_button.TextColor = System.Drawing.Color.White;
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // type_label
            // 
            this.type_label.AutoSize = true;
            this.type_label.BackColor = System.Drawing.Color.Transparent;
            this.type_label.Font = new System.Drawing.Font("Barlow SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.type_label.Location = new System.Drawing.Point(56, 156);
            this.type_label.Name = "type_label";
            this.type_label.Size = new System.Drawing.Size(44, 22);
            this.type_label.TabIndex = 12;
            this.type_label.Text = "Type";
            this.type_label.Visible = false;
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.BackColor = System.Drawing.Color.Transparent;
            this.price_label.Font = new System.Drawing.Font("Barlow SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.price_label.Location = new System.Drawing.Point(56, 239);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(48, 22);
            this.price_label.TabIndex = 14;
            this.price_label.Text = "Price";
            this.price_label.Visible = false;
            // 
            // price_textbox
            // 
            this.price_textbox.BackColor = System.Drawing.SystemColors.Window;
            this.price_textbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(134)))), ((int)(((byte)(139)))));
            this.price_textbox.BorderFocusColor = System.Drawing.Color.Transparent;
            this.price_textbox.BorderRadius = 0;
            this.price_textbox.BorderSize = 3;
            this.price_textbox.Font = new System.Drawing.Font("Barlow SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(134)))), ((int)(((byte)(139)))));
            this.price_textbox.Location = new System.Drawing.Point(33, 250);
            this.price_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.price_textbox.Multiline = false;
            this.price_textbox.Name = "price_textbox";
            this.price_textbox.Padding = new System.Windows.Forms.Padding(15);
            this.price_textbox.PasswordChar = false;
            this.price_textbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.price_textbox.PlaceholderText = "";
            this.price_textbox.Size = new System.Drawing.Size(307, 57);
            this.price_textbox.TabIndex = 13;
            this.price_textbox.Texts = "Price";
            this.price_textbox.UnderlinedStyle = false;
            this.price_textbox.Enter += new System.EventHandler(this.price_textbox_Enter);
            this.price_textbox.Leave += new System.EventHandler(this.price_textbox_Leave);
            // 
            // type_combobox
            // 
            this.type_combobox.BackColor = System.Drawing.Color.White;
            this.type_combobox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(134)))), ((int)(((byte)(139)))));
            this.type_combobox.BorderSize = 2;
            this.type_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_combobox.Font = new System.Drawing.Font("Barlow SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_combobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(134)))), ((int)(((byte)(139)))));
            this.type_combobox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(134)))), ((int)(((byte)(139)))));
            this.type_combobox.Items.AddRange(new object[] {
            "",
            "Burgers",
            "Sandwhiches",
            "Pastas",
            "Appetizers",
            "Breakfast",
            "Desserts",
            "Drinks"});
            this.type_combobox.ListBackColor = System.Drawing.SystemColors.Window;
            this.type_combobox.ListTextColor = System.Drawing.Color.Black;
            this.type_combobox.Location = new System.Drawing.Point(33, 168);
            this.type_combobox.MinimumSize = new System.Drawing.Size(200, 30);
            this.type_combobox.Name = "type_combobox";
            this.type_combobox.Padding = new System.Windows.Forms.Padding(3);
            this.type_combobox.Size = new System.Drawing.Size(307, 57);
            this.type_combobox.TabIndex = 15;
            this.type_combobox.Texts = "Type";
            this.type_combobox.Enter += new System.EventHandler(this.type_combobox_Enter);
            this.type_combobox.Leave += new System.EventHandler(this.type_combobox_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13700, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(208, 65);
            this.dataGridView1.TabIndex = 59;
            // 
            // CreateEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(392, 432);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.type_label);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.type_combobox);
            this.Controls.Add(this.price_textbox);
            this.Controls.Add(this.name_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateEditProduct";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateEditProduct_FormClosing);
            this.Load += new System.EventHandler(this.CreateEditProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_label;
        public RoundedTextbox name_textbox;
        private ButtonRadius cancel_button;
        public System.Windows.Forms.Label label1;
        private ButtonRadius save_button;
        private System.Windows.Forms.Label type_label;
        private System.Windows.Forms.Label price_label;
        public RoundedTextbox price_textbox;
        public CustomComboBox.RJComboBox type_combobox;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}