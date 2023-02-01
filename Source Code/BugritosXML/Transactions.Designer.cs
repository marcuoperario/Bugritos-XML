
namespace BugritosXML
{
    partial class Transactions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.transactions_table = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.add_button = new BugritosXML.ButtonRadius();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactions_table)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Barlow Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(315, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 50);
            this.label4.TabIndex = 49;
            this.label4.Text = "TRANSACTIONS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-10000, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(257, 91);
            this.dataGridView1.TabIndex = 58;
            // 
            // transactions_table
            // 
            this.transactions_table.AllowUserToAddRows = false;
            this.transactions_table.AllowUserToDeleteRows = false;
            this.transactions_table.AllowUserToResizeColumns = false;
            this.transactions_table.AllowUserToResizeRows = false;
            this.transactions_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transactions_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.transactions_table.BackgroundColor = System.Drawing.Color.DimGray;
            this.transactions_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transactions_table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.transactions_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Barlow SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transactions_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.transactions_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactions_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.TransactionID,
            this.TransactionDate,
            this.TransactionTime,
            this.TransactionTotalPrice,
            this.ViewButton,
            this.EditButton,
            this.DeleteButton});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Barlow SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.transactions_table.DefaultCellStyle = dataGridViewCellStyle23;
            this.transactions_table.EnableHeadersVisualStyles = false;
            this.transactions_table.Location = new System.Drawing.Point(54, 145);
            this.transactions_table.MultiSelect = false;
            this.transactions_table.Name = "transactions_table";
            this.transactions_table.ReadOnly = true;
            this.transactions_table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transactions_table.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.transactions_table.RowHeadersVisible = false;
            this.transactions_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.transactions_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transactions_table.ShowEditingIcon = false;
            this.transactions_table.Size = new System.Drawing.Size(795, 526);
            this.transactions_table.TabIndex = 64;
            this.transactions_table.TabStop = false;
            this.transactions_table.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.transactions_table_CellMouseClick);
            this.transactions_table.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.transactions_table_CellMouseEnter);
            this.transactions_table.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.transactions_table_CellMouseLeave);
            // 
            // no
            // 
            this.no.FillWeight = 45F;
            this.no.HeaderText = "#";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            this.no.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TransactionID
            // 
            this.TransactionID.FillWeight = 90F;
            this.TransactionID.HeaderText = "ID";
            this.TransactionID.Name = "TransactionID";
            this.TransactionID.ReadOnly = true;
            this.TransactionID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TransactionDate
            // 
            this.TransactionDate.HeaderText = "Date";
            this.TransactionDate.Name = "TransactionDate";
            this.TransactionDate.ReadOnly = true;
            this.TransactionDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TransactionTime
            // 
            this.TransactionTime.HeaderText = "Time";
            this.TransactionTime.Name = "TransactionTime";
            this.TransactionTime.ReadOnly = true;
            this.TransactionTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TransactionTotalPrice
            // 
            this.TransactionTotalPrice.HeaderText = "Total Price";
            this.TransactionTotalPrice.Name = "TransactionTotalPrice";
            this.TransactionTotalPrice.ReadOnly = true;
            this.TransactionTotalPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ViewButton
            // 
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Barlow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.NullValue = "PRODUCTS";
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            this.ViewButton.DefaultCellStyle = dataGridViewCellStyle20;
            this.ViewButton.FillWeight = 65F;
            this.ViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewButton.HeaderText = "";
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.ReadOnly = true;
            // 
            // EditButton
            // 
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Barlow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.NullValue = "EDIT";
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.White;
            this.EditButton.DefaultCellStyle = dataGridViewCellStyle21;
            this.EditButton.FillWeight = 45F;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.HeaderText = "";
            this.EditButton.Name = "EditButton";
            this.EditButton.ReadOnly = true;
            // 
            // DeleteButton
            // 
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Barlow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.NullValue = "DELETE";
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.White;
            this.DeleteButton.DefaultCellStyle = dataGridViewCellStyle22;
            this.DeleteButton.FillWeight = 55F;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.HeaderText = "";
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.ReadOnly = true;
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
            this.add_button.Location = new System.Drawing.Point(738, 99);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(111, 40);
            this.add_button.TabIndex = 65;
            this.add_button.TabStop = false;
            this.add_button.Text = "Add";
            this.add_button.TextColor = System.Drawing.Color.White;
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(656, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 35);
            this.panel1.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.label1.Font = new System.Drawing.Font("Barlow SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 33);
            this.label1.TabIndex = 61;
            this.label1.Text = "Actions";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Transactions
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.transactions_table);
            this.Name = "Transactions";
            this.Size = new System.Drawing.Size(898, 760);
            this.EnabledChanged += new System.EventHandler(this.Transactions_EnabledChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactions_table)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridView transactions_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionTotalPrice;
        private System.Windows.Forms.DataGridViewButtonColumn ViewButton;
        private System.Windows.Forms.DataGridViewButtonColumn EditButton;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteButton;
        private ButtonRadius add_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
