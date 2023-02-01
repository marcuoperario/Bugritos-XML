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
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace BugritosXML
{
    public partial class Products : UserControl
    {
        public Products()
        {
            InitializeComponent();
            products_table.Region = Region.FromHrgn(RoundedForms.CreateRoundRect(0, 0, products_table.Width, products_table.Height, 30, 30));
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            CreateEditProduct cep = new CreateEditProduct(this);
            cep.label1.Text = "ADD PRODUCT";
            cep.ActiveControl = cep.label1;
            cep.Show();
        }

        private void DataSource()
        {
            if (!File.Exists("products.xml"))
            {
                return;
            }
            else
            {
                Auth.ReadKey();
                Auth.DecryptFile("products.xml", Auth.EncryptedKey);
                DataSet ds = new DataSet();
                ds.Clear();
                products_table.DataSource = null;
                products_table.Rows.Clear();
                products_table.Refresh();
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                ds.ReadXml("products.xml");
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    DataView dv = new DataView(ds.Tables[0]);
                    dataGridView1.DataSource = dv;
                    LoadXML();
                }
                Auth.ReadKey();
                Auth.EncryptFile("products.xml", Auth.EncryptedKey);
            }
        }

        private void LoadXML()
        {
            int i = 1;
            if (products_table.Rows.Count == 0 && dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    string col1 = Convert.ToString(dr.Cells["ProductID"].Value);
                    string col2 = Convert.ToString(dr.Cells["ProductName"].Value);
                    string col3 = Convert.ToString(dr.Cells["ProductType"].Value);
                    string col4 = Convert.ToString(dr.Cells["ProductPrice"].Value);
                    if (!string.IsNullOrEmpty(col1 + col2 + col3 + col4))
                    {
                        products_table.Rows.Add(i, col1, col2, col3, col4);
                    }
                    i++;
                }
                products_table.ClearSelection();
            }
        }

        private void Products_EnabledChanged(object sender, EventArgs e)
        {
            this.Enabled = true;
            BringToFront();
            DataSource();
        }

        private void products_table_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 5:
                    CreateEditProduct cep = new CreateEditProduct(this);
                    DataGridViewRow dgvRow = products_table.Rows[e.RowIndex];
                    string price = dgvRow.Cells[4].Value.ToString();
                    string finalPrice = price.Trim().Replace("₱", "").Replace(".00", "").Replace(",", "");
                    cep.ActiveControl = cep.label1;
                    cep.label1.Text = "EDIT PRODUCT";
                    cep.ProductID = dgvRow.Cells[1].Value.ToString();
                    cep.name_textbox.Texts = dgvRow.Cells[2].Value.ToString();
                    cep.type_combobox.SelectedItem = dgvRow.Cells[3].Value.ToString();
                    cep.price_textbox.Texts = finalPrice;
                    cep.Show();
                    break;
                case 6:
                    if (MessageBox.Show("Are you sure you want to delete this Product?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        string pid = products_table.Rows[e.RowIndex].Cells[1].Value.ToString();
                        Auth.ReadKey();
                        Auth.DecryptFile("products.xml", Auth.EncryptedKey);
                        XmlDocument doc = new XmlDocument();
                        doc.Load("products.xml");
                        XmlNode node = doc.SelectSingleNode(String.Format("/Products/Product[ProductID='{0}']", pid));
                        node.ParentNode.RemoveChild(node);
                        doc.Save("products.xml");
                        MessageBox.Show("Product was succesfully deleted!");
                        Auth.ReadKey();
                        Auth.EncryptFile("products.xml", Auth.EncryptedKey);
                        this.Enabled = false;
                    }
                    break;
                default:
                    break;
            }
        }

        private void products_table_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 5 || e.ColumnIndex == 6 || e.ColumnIndex == 7)
                    products_table.Cursor = Cursors.Hand;
            }
            else
            {
                products_table.Cursor = Cursors.Default;
            }
        }

        private void products_table_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            products_table.Cursor = Cursors.Default;
        }
    }
}

