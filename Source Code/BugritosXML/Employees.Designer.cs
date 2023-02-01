
namespace BugritosXML
{
    partial class Employees
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.employees_table = new System.Windows.Forms.DataGridView();
            this.ColumnNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.employees_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Barlow Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(348, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 50);
            this.label4.TabIndex = 49;
            this.label4.Text = "EMPLOYEES";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // employees_table
            // 
            this.employees_table.AllowUserToAddRows = false;
            this.employees_table.AllowUserToDeleteRows = false;
            this.employees_table.AllowUserToResizeColumns = false;
            this.employees_table.AllowUserToResizeRows = false;
            this.employees_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employees_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.employees_table.BackgroundColor = System.Drawing.Color.DimGray;
            this.employees_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employees_table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.employees_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Barlow SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employees_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.employees_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employees_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNo,
            this.EmployeeName,
            this.EmployeeGender,
            this.EmployeeBirthday});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Barlow SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.employees_table.DefaultCellStyle = dataGridViewCellStyle2;
            this.employees_table.EnableHeadersVisualStyles = false;
            this.employees_table.Location = new System.Drawing.Point(54, 145);
            this.employees_table.MultiSelect = false;
            this.employees_table.Name = "employees_table";
            this.employees_table.ReadOnly = true;
            this.employees_table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employees_table.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.employees_table.RowHeadersVisible = false;
            this.employees_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.employees_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employees_table.ShowEditingIcon = false;
            this.employees_table.Size = new System.Drawing.Size(795, 526);
            this.employees_table.TabIndex = 56;
            this.employees_table.TabStop = false;
            // 
            // ColumnNo
            // 
            this.ColumnNo.FillWeight = 45F;
            this.ColumnNo.HeaderText = "#";
            this.ColumnNo.Name = "ColumnNo";
            this.ColumnNo.ReadOnly = true;
            this.ColumnNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EmployeeName
            // 
            this.EmployeeName.HeaderText = "Name";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            this.EmployeeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EmployeeGender
            // 
            this.EmployeeGender.HeaderText = "Gender";
            this.EmployeeGender.Name = "EmployeeGender";
            this.EmployeeGender.ReadOnly = true;
            this.EmployeeGender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EmployeeBirthday
            // 
            this.EmployeeBirthday.HeaderText = "Birth";
            this.EmployeeBirthday.Name = "EmployeeBirthday";
            this.EmployeeBirthday.ReadOnly = true;
            this.EmployeeBirthday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-10000, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(257, 91);
            this.dataGridView1.TabIndex = 58;
            // 
            // Employees
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.employees_table);
            this.Controls.Add(this.label4);
            this.Name = "Employees";
            this.Size = new System.Drawing.Size(898, 760);
            this.Load += new System.EventHandler(this.Employees_Load);
            this.EnabledChanged += new System.EventHandler(this.Employees_EnabledChanged);
            ((System.ComponentModel.ISupportInitialize)(this.employees_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView employees_table;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeBirthday;
    }
}
