
namespace BugritosXML
{
    partial class CreateEditSale
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.day_label = new System.Windows.Forms.Label();
            this.month_label = new System.Windows.Forms.Label();
            this.year_label = new System.Windows.Forms.Label();
            this.hour_label = new System.Windows.Forms.Label();
            this.min_label = new System.Windows.Forms.Label();
            this.period_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.products_label = new System.Windows.Forms.Label();
            this.receipt_table = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteProduct = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.quantity_label = new System.Windows.Forms.Label();
            this.total_price = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.quantity_textbox = new BugritosXML.RoundedTextbox();
            this.add_button = new BugritosXML.ButtonRadius();
            this.products_combobox = new CustomComboBox.RJComboBox();
            this.period_combobox = new CustomComboBox.RJComboBox();
            this.month_combobox = new CustomComboBox.RJComboBox();
            this.year_textbox = new BugritosXML.RoundedTextbox();
            this.day_textbox = new BugritosXML.RoundedTextbox();
            this.cancel_button = new BugritosXML.ButtonRadius();
            this.save_button = new BugritosXML.ButtonRadius();
            this.hour_textbox = new BugritosXML.RoundedTextbox();
            this.min_textbox = new BugritosXML.RoundedTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.receipt_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Barlow SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "ADD SALE";
            // 
            // day_label
            // 
            this.day_label.AutoSize = true;
            this.day_label.BackColor = System.Drawing.Color.Transparent;
            this.day_label.Font = new System.Drawing.Font("Barlow SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.day_label.Location = new System.Drawing.Point(44, 89);
            this.day_label.Name = "day_label";
            this.day_label.Size = new System.Drawing.Size(36, 22);
            this.day_label.TabIndex = 7;
            this.day_label.Text = "Day";
            // 
            // month_label
            // 
            this.month_label.AutoSize = true;
            this.month_label.BackColor = System.Drawing.Color.Transparent;
            this.month_label.Font = new System.Drawing.Font("Barlow SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.month_label.Location = new System.Drawing.Point(148, 89);
            this.month_label.Name = "month_label";
            this.month_label.Size = new System.Drawing.Size(54, 22);
            this.month_label.TabIndex = 9;
            this.month_label.Text = "Month";
            // 
            // year_label
            // 
            this.year_label.AutoSize = true;
            this.year_label.BackColor = System.Drawing.Color.Transparent;
            this.year_label.Font = new System.Drawing.Font("Barlow SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.year_label.Location = new System.Drawing.Point(374, 89);
            this.year_label.Name = "year_label";
            this.year_label.Size = new System.Drawing.Size(42, 22);
            this.year_label.TabIndex = 11;
            this.year_label.Text = "Year";
            // 
            // hour_label
            // 
            this.hour_label.AutoSize = true;
            this.hour_label.BackColor = System.Drawing.Color.Transparent;
            this.hour_label.Font = new System.Drawing.Font("Barlow SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.hour_label.Location = new System.Drawing.Point(44, 199);
            this.hour_label.Name = "hour_label";
            this.hour_label.Size = new System.Drawing.Size(44, 22);
            this.hour_label.TabIndex = 13;
            this.hour_label.Text = "Hour";
            // 
            // min_label
            // 
            this.min_label.AutoSize = true;
            this.min_label.BackColor = System.Drawing.Color.Transparent;
            this.min_label.Font = new System.Drawing.Font("Barlow SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.min_label.Location = new System.Drawing.Point(148, 199);
            this.min_label.Name = "min_label";
            this.min_label.Size = new System.Drawing.Size(34, 22);
            this.min_label.TabIndex = 15;
            this.min_label.Text = "Min";
            // 
            // period_label
            // 
            this.period_label.AutoSize = true;
            this.period_label.BackColor = System.Drawing.Color.Transparent;
            this.period_label.Font = new System.Drawing.Font("Barlow SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.period_label.Location = new System.Drawing.Point(242, 199);
            this.period_label.Name = "period_label";
            this.period_label.Size = new System.Drawing.Size(61, 22);
            this.period_label.TabIndex = 17;
            this.period_label.Text = "Period.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Barlow Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(103, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 44);
            this.label5.TabIndex = 19;
            this.label5.Text = ":";
            // 
            // products_label
            // 
            this.products_label.AutoSize = true;
            this.products_label.BackColor = System.Drawing.Color.Transparent;
            this.products_label.Font = new System.Drawing.Font("Barlow SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.products_label.Location = new System.Drawing.Point(44, 312);
            this.products_label.Name = "products_label";
            this.products_label.Size = new System.Drawing.Size(68, 22);
            this.products_label.TabIndex = 22;
            this.products_label.Text = "Product";
            this.products_label.Visible = false;
            // 
            // receipt_table
            // 
            this.receipt_table.AllowUserToAddRows = false;
            this.receipt_table.AllowUserToDeleteRows = false;
            this.receipt_table.AllowUserToResizeColumns = false;
            this.receipt_table.AllowUserToResizeRows = false;
            this.receipt_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.receipt_table.BackgroundColor = System.Drawing.Color.DimGray;
            this.receipt_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.receipt_table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.receipt_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Barlow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.receipt_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.receipt_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receipt_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.ProductQuantity,
            this.ProductPrice,
            this.DeleteProduct});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Barlow SemiBold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.receipt_table.DefaultCellStyle = dataGridViewCellStyle7;
            this.receipt_table.EnableHeadersVisualStyles = false;
            this.receipt_table.Location = new System.Drawing.Point(482, 34);
            this.receipt_table.MultiSelect = false;
            this.receipt_table.Name = "receipt_table";
            this.receipt_table.ReadOnly = true;
            this.receipt_table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.receipt_table.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.receipt_table.RowHeadersVisible = false;
            this.receipt_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.receipt_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.receipt_table.ShowEditingIcon = false;
            this.receipt_table.Size = new System.Drawing.Size(460, 347);
            this.receipt_table.TabIndex = 60;
            this.receipt_table.TabStop = false;
            this.receipt_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.receipt_table_CellClick);
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.HeaderText = "Qty.";
            this.ProductQuantity.Name = "ProductQuantity";
            this.ProductQuantity.ReadOnly = true;
            this.ProductQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ProductPrice
            // 
            this.ProductPrice.HeaderText = "Amount";
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.ReadOnly = true;
            this.ProductPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DeleteProduct
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Barlow SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.NullValue = "DELETE";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.DeleteProduct.DefaultCellStyle = dataGridViewCellStyle6;
            this.DeleteProduct.FillWeight = 50F;
            this.DeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteProduct.HeaderText = "";
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.ReadOnly = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Dock = System.Windows.Forms.DockStyle.Left;
            this.label.Font = new System.Drawing.Font("Barlow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(0, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(137, 33);
            this.label.TabIndex = 61;
            this.label.Text = "Total Price:";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32736, 448);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(237, 66);
            this.dataGridView1.TabIndex = 63;
            // 
            // quantity_label
            // 
            this.quantity_label.AutoSize = true;
            this.quantity_label.BackColor = System.Drawing.Color.Transparent;
            this.quantity_label.Font = new System.Drawing.Font("Barlow SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.quantity_label.Location = new System.Drawing.Point(374, 312);
            this.quantity_label.Name = "quantity_label";
            this.quantity_label.Size = new System.Drawing.Size(36, 22);
            this.quantity_label.TabIndex = 66;
            this.quantity_label.Text = "Qty.";
            this.quantity_label.Visible = false;
            // 
            // total_price
            // 
            this.total_price.AutoSize = true;
            this.total_price.Dock = System.Windows.Forms.DockStyle.Right;
            this.total_price.Font = new System.Drawing.Font("Barlow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_price.Location = new System.Drawing.Point(374, 0);
            this.total_price.Name = "total_price";
            this.total_price.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.total_price.Size = new System.Drawing.Size(86, 33);
            this.total_price.TabIndex = 67;
            this.total_price.Text = "₱ 0.00";
            this.total_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32736, 471);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "label2";
            this.label2.EnabledChanged += new System.EventHandler(this.label2_EnabledChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.total_price);
            this.panel1.Location = new System.Drawing.Point(482, 391);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 66);
            this.panel1.TabIndex = 69;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(5555, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 70;
            // 
            // quantity_textbox
            // 
            this.quantity_textbox.BackColor = System.Drawing.Color.White;
            this.quantity_textbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(134)))), ((int)(((byte)(139)))));
            this.quantity_textbox.BorderFocusColor = System.Drawing.Color.Transparent;
            this.quantity_textbox.BorderRadius = 0;
            this.quantity_textbox.BorderSize = 3;
            this.quantity_textbox.Font = new System.Drawing.Font("Barlow SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(134)))), ((int)(((byte)(139)))));
            this.quantity_textbox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.quantity_textbox.Location = new System.Drawing.Point(360, 324);
            this.quantity_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.quantity_textbox.Multiline = false;
            this.quantity_textbox.Name = "quantity_textbox";
            this.quantity_textbox.Padding = new System.Windows.Forms.Padding(15);
            this.quantity_textbox.PasswordChar = false;
            this.quantity_textbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.quantity_textbox.PlaceholderText = "";
            this.quantity_textbox.Size = new System.Drawing.Size(95, 57);
            this.quantity_textbox.TabIndex = 65;
            this.quantity_textbox.TabStop = false;
            this.quantity_textbox.Texts = "Qty.";
            this.quantity_textbox.UnderlinedStyle = false;
            this.quantity_textbox.Enter += new System.EventHandler(this.quantity_textbox_Enter);
            this.quantity_textbox.Leave += new System.EventHandler(this.quantity_textbox_Leave);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(86)))));
            this.add_button.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(86)))));
            this.add_button.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.add_button.BorderRadius = 10;
            this.add_button.BorderSize = 0;
            this.add_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_button.FlatAppearance.BorderSize = 0;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Barlow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.Location = new System.Drawing.Point(30, 402);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(425, 40);
            this.add_button.TabIndex = 62;
            this.add_button.TabStop = false;
            this.add_button.Text = "Add Product";
            this.add_button.TextColor = System.Drawing.Color.White;
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // products_combobox
            // 
            this.products_combobox.BackColor = System.Drawing.Color.White;
            this.products_combobox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(134)))), ((int)(((byte)(139)))));
            this.products_combobox.BorderSize = 2;
            this.products_combobox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.products_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.products_combobox.Font = new System.Drawing.Font("Barlow SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products_combobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(134)))), ((int)(((byte)(139)))));
            this.products_combobox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(134)))), ((int)(((byte)(139)))));
            this.products_combobox.Items.AddRange(new object[] {
            ""});
            this.products_combobox.ListBackColor = System.Drawing.SystemColors.Window;
            this.products_combobox.ListTextColor = System.Drawing.Color.Black;
            this.products_combobox.Location = new System.Drawing.Point(30, 324);
            this.products_combobox.MinimumSize = new System.Drawing.Size(50, 30);
            this.products_combobox.Name = "products_combobox";
            this.products_combobox.Padding = new System.Windows.Forms.Padding(3);
            this.products_combobox.Size = new System.Drawing.Size(304, 57);
            this.products_combobox.TabIndex = 23;
            this.products_combobox.TabStop = false;
            this.products_combobox.Texts = "Product";
            this.products_combobox.Enter += new System.EventHandler(this.products_combobox_Enter);
            this.products_combobox.Leave += new System.EventHandler(this.products_combobox_Leave);
            // 
            // period_combobox
            // 
            this.period_combobox.BackColor = System.Drawing.Color.White;
            this.period_combobox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(134)))), ((int)(((byte)(139)))));
            this.period_combobox.BorderSize = 2;
            this.period_combobox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.period_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.period_combobox.Font = new System.Drawing.Font("Barlow SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period_combobox.ForeColor = System.Drawing.Color.Black;
            this.period_combobox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(134)))), ((int)(((byte)(139)))));
            this.period_combobox.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.period_combobox.ListBackColor = System.Drawing.SystemColors.Window;
            this.period_combobox.ListTextColor = System.Drawing.Color.Black;
            this.period_combobox.Location = new System.Drawing.Point(228, 211);
            this.period_combobox.MinimumSize = new System.Drawing.Size(50, 30);
            this.period_combobox.Name = "period_combobox";
            this.period_combobox.Padding = new System.Windows.Forms.Padding(3);
            this.period_combobox.Size = new System.Drawing.Size(106, 57);
            this.period_combobox.TabIndex = 18;
            this.period_combobox.TabStop = false;
            this.period_combobox.Texts = "";
            this.period_combobox.Enter += new System.EventHandler(this.period_combobox_Enter);
            this.period_combobox.Leave += new System.EventHandler(this.period_combobox_Leave);
            // 
            // month_combobox
            // 
            this.month_combobox.BackColor = System.Drawing.Color.White;
            this.month_combobox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(134)))), ((int)(((byte)(139)))));
            this.month_combobox.BorderSize = 2;
            this.month_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.month_combobox.Font = new System.Drawing.Font("Barlow SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month_combobox.ForeColor = System.Drawing.Color.Black;
            this.month_combobox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(134)))), ((int)(((byte)(139)))));
            this.month_combobox.Items.AddRange(new object[] {
            "",
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.month_combobox.ListBackColor = System.Drawing.SystemColors.Window;
            this.month_combobox.ListTextColor = System.Drawing.Color.Black;
            this.month_combobox.Location = new System.Drawing.Point(134, 101);
            this.month_combobox.MinimumSize = new System.Drawing.Size(200, 30);
            this.month_combobox.Name = "month_combobox";
            this.month_combobox.Padding = new System.Windows.Forms.Padding(3);
            this.month_combobox.Size = new System.Drawing.Size(200, 57);
            this.month_combobox.TabIndex = 12;
            this.month_combobox.TabStop = false;
            this.month_combobox.Texts = "";
            this.month_combobox.Enter += new System.EventHandler(this.month_combobox_Enter);
            this.month_combobox.Leave += new System.EventHandler(this.month_combobox_Leave);
            // 
            // year_textbox
            // 
            this.year_textbox.BackColor = System.Drawing.Color.White;
            this.year_textbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(134)))), ((int)(((byte)(139)))));
            this.year_textbox.BorderFocusColor = System.Drawing.Color.Transparent;
            this.year_textbox.BorderRadius = 0;
            this.year_textbox.BorderSize = 3;
            this.year_textbox.Font = new System.Drawing.Font("Barlow SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year_textbox.Location = new System.Drawing.Point(360, 101);
            this.year_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.year_textbox.Multiline = false;
            this.year_textbox.Name = "year_textbox";
            this.year_textbox.Padding = new System.Windows.Forms.Padding(15);
            this.year_textbox.PasswordChar = false;
            this.year_textbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.year_textbox.PlaceholderText = "YYYY";
            this.year_textbox.Size = new System.Drawing.Size(95, 57);
            this.year_textbox.TabIndex = 10;
            this.year_textbox.TabStop = false;
            this.year_textbox.Texts = "";
            this.year_textbox.UnderlinedStyle = false;
            this.year_textbox.Enter += new System.EventHandler(this.year_textbox_Enter);
            this.year_textbox.Leave += new System.EventHandler(this.year_textbox_Leave);
            // 
            // day_textbox
            // 
            this.day_textbox.BackColor = System.Drawing.Color.White;
            this.day_textbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(134)))), ((int)(((byte)(139)))));
            this.day_textbox.BorderFocusColor = System.Drawing.Color.Transparent;
            this.day_textbox.BorderRadius = 0;
            this.day_textbox.BorderSize = 3;
            this.day_textbox.Font = new System.Drawing.Font("Barlow SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day_textbox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.day_textbox.Location = new System.Drawing.Point(30, 101);
            this.day_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.day_textbox.Multiline = false;
            this.day_textbox.Name = "day_textbox";
            this.day_textbox.Padding = new System.Windows.Forms.Padding(15);
            this.day_textbox.PasswordChar = false;
            this.day_textbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.day_textbox.PlaceholderText = "";
            this.day_textbox.Size = new System.Drawing.Size(69, 57);
            this.day_textbox.TabIndex = 6;
            this.day_textbox.TabStop = false;
            this.day_textbox.Texts = "";
            this.day_textbox.UnderlinedStyle = false;
            this.day_textbox.Enter += new System.EventHandler(this.day_textbox_Enter);
            this.day_textbox.Leave += new System.EventHandler(this.day_textbox_Leave);
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
            this.cancel_button.Location = new System.Drawing.Point(734, 459);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(101, 40);
            this.cancel_button.TabIndex = 4;
            this.cancel_button.TabStop = false;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.TextColor = System.Drawing.Color.Black;
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
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
            this.save_button.Location = new System.Drawing.Point(841, 459);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(101, 40);
            this.save_button.TabIndex = 2;
            this.save_button.TabStop = false;
            this.save_button.Text = "Save";
            this.save_button.TextColor = System.Drawing.Color.White;
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // hour_textbox
            // 
            this.hour_textbox.BackColor = System.Drawing.Color.White;
            this.hour_textbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(134)))), ((int)(((byte)(139)))));
            this.hour_textbox.BorderFocusColor = System.Drawing.Color.Transparent;
            this.hour_textbox.BorderRadius = 0;
            this.hour_textbox.BorderSize = 3;
            this.hour_textbox.Font = new System.Drawing.Font("Barlow SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hour_textbox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hour_textbox.Location = new System.Drawing.Point(30, 212);
            this.hour_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.hour_textbox.Multiline = false;
            this.hour_textbox.Name = "hour_textbox";
            this.hour_textbox.Padding = new System.Windows.Forms.Padding(15);
            this.hour_textbox.PasswordChar = false;
            this.hour_textbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.hour_textbox.PlaceholderText = "";
            this.hour_textbox.Size = new System.Drawing.Size(69, 57);
            this.hour_textbox.TabIndex = 20;
            this.hour_textbox.TabStop = false;
            this.hour_textbox.Texts = "";
            this.hour_textbox.UnderlinedStyle = false;
            this.hour_textbox.Enter += new System.EventHandler(this.hour_textbox_Enter);
            this.hour_textbox.Leave += new System.EventHandler(this.hour_textbox_Leave);
            // 
            // min_textbox
            // 
            this.min_textbox.BackColor = System.Drawing.Color.White;
            this.min_textbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(134)))), ((int)(((byte)(139)))));
            this.min_textbox.BorderFocusColor = System.Drawing.Color.Transparent;
            this.min_textbox.BorderRadius = 0;
            this.min_textbox.BorderSize = 3;
            this.min_textbox.Font = new System.Drawing.Font("Barlow SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min_textbox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.min_textbox.Location = new System.Drawing.Point(134, 211);
            this.min_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.min_textbox.Multiline = false;
            this.min_textbox.Name = "min_textbox";
            this.min_textbox.Padding = new System.Windows.Forms.Padding(15);
            this.min_textbox.PasswordChar = false;
            this.min_textbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.min_textbox.PlaceholderText = "";
            this.min_textbox.Size = new System.Drawing.Size(73, 57);
            this.min_textbox.TabIndex = 21;
            this.min_textbox.TabStop = false;
            this.min_textbox.Texts = "";
            this.min_textbox.UnderlinedStyle = false;
            this.min_textbox.Enter += new System.EventHandler(this.min_textbox_Enter);
            this.min_textbox.Leave += new System.EventHandler(this.min_textbox_Leave);
            // 
            // CreateEditSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(974, 526);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quantity_label);
            this.Controls.Add(this.quantity_textbox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.receipt_table);
            this.Controls.Add(this.products_label);
            this.Controls.Add(this.products_combobox);
            this.Controls.Add(this.period_label);
            this.Controls.Add(this.period_combobox);
            this.Controls.Add(this.min_label);
            this.Controls.Add(this.hour_label);
            this.Controls.Add(this.month_label);
            this.Controls.Add(this.month_combobox);
            this.Controls.Add(this.year_label);
            this.Controls.Add(this.year_textbox);
            this.Controls.Add(this.day_label);
            this.Controls.Add(this.day_textbox);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.hour_textbox);
            this.Controls.Add(this.min_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateEditSale";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.CreateEditSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.receipt_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ButtonRadius save_button;
        private ButtonRadius cancel_button;
        private System.Windows.Forms.Label day_label;
        public RoundedTextbox day_textbox;
        private System.Windows.Forms.Label month_label;
        private System.Windows.Forms.Label year_label;
        public RoundedTextbox year_textbox;
        public CustomComboBox.RJComboBox month_combobox;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hour_label;
        private System.Windows.Forms.Label min_label;
        private System.Windows.Forms.Label period_label;
        public CustomComboBox.RJComboBox period_combobox;
        public System.Windows.Forms.Label label5;
        public RoundedTextbox hour_textbox;
        public RoundedTextbox min_textbox;
        private System.Windows.Forms.Label products_label;
        public CustomComboBox.RJComboBox products_combobox;
        public System.Windows.Forms.DataGridView receipt_table;
        public System.Windows.Forms.Label label;
        private ButtonRadius add_button;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label quantity_label;
        public RoundedTextbox quantity_textbox;
        public System.Windows.Forms.Label total_price;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dataGridView2;
        private new System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteProduct;
        public System.Windows.Forms.Label label2;
    }
}