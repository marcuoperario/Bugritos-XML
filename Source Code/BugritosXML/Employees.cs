using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugritosXML
{
    public partial class Employees : UserControl
    {
        public Employees()
        {
            InitializeComponent();
            employees_table.Region = Region.FromHrgn(RoundedForms.CreateRoundRect(0, 0, employees_table.Width, employees_table.Height, 30, 30));
        }

        private void Employees_EnabledChanged(object sender, EventArgs e)
        {
            this.Enabled = true;
            DataSource();
        }

        private void DataSource()
        {
            if (!File.Exists("users.xml"))
            {
                return;
            }
            else
            {
                Auth.ReadKey();
                Auth.DecryptFile("users.xml", Auth.EncryptedKey);
                DataSet ds = new DataSet();
                ds.Clear();
                employees_table.DataSource = null;
                employees_table.Rows.Clear();
                employees_table.Refresh();
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                ds.ReadXml("users.xml");
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    DataView dv = new DataView(ds.Tables[0]);
                    dataGridView1.DataSource = dv;
                    LoadXML();
                }
                Auth.ReadKey();
                Auth.EncryptFile("users.xml", Auth.EncryptedKey);
            }
        }

        private void LoadXML()
        {
            int i = 0;
            int j = 1;
            if (employees_table.Rows.Count == 0)
            {
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    string col1 = Convert.ToString(dr.Cells["FirstName"].Value);
                    string col2 = Convert.ToString(dr.Cells["LastName"].Value);
                    string col3 = Convert.ToString(dr.Cells["Gender"].Value);
                    string col4 = Convert.ToString(dr.Cells["Birthday"].Value);
                    string col5 = Convert.ToString(dr.Cells["EmailAddress"].Value);
                    if (!string.IsNullOrEmpty(col1 + col2 + col3 + col4 + col5))
                    {
                        string fullname = col1 + " " + col2;
                        employees_table.Rows.Add(j,fullname, col3, col4, col5);
                        i++;
                        j++;
                    }
                }
            }
            employees_table.ClearSelection();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            DataSource();
        }
    }
}
