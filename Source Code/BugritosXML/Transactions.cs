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

namespace BugritosXML
{
    public partial class Transactions : UserControl
    {
        public Transactions()
        {
            InitializeComponent();
            transactions_table.Region = Region.FromHrgn(RoundedForms.CreateRoundRect(0, 0, transactions_table.Width, transactions_table.Height, 30, 30));
        }

        private void Transactions_EnabledChanged(object sender, EventArgs e)
        {
            this.Enabled = true;
            BringToFront();
            DataSource();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            CreateEditSale ces = new CreateEditSale(this);
            ces.label1.Text = "ADD TRANSACTION";
            ces.label2.Enabled = false;
            ces.LoadCurrentTime();
            ces.Show();
        }

        private void DataSource()
        {
            if (!File.Exists("transactions.xml"))
            {
                return;
            }
            else
            {
                Auth.ReadKey();
                Auth.DecryptFile("transactions.xml", Auth.EncryptedKey);
                DataSet ds = new DataSet();
                ds.Clear();
                transactions_table.DataSource = null;
                transactions_table.Rows.Clear();
                transactions_table.Refresh();
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                ds.ReadXml("transactions.xml");
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    DataView dv = new DataView(ds.Tables[0]);
                    dataGridView1.DataSource = dv;
                    LoadXML();
                }
                Auth.ReadKey();
                Auth.EncryptFile("transactions.xml", Auth.EncryptedKey);
            }
        }
        private void LoadXML()
        {
            int i = 1;
            if (transactions_table.Rows.Count == 0 && dataGridView1.Rows.Count > 0)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("transactions.xml");
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    string col1 = Convert.ToString(dr.Cells["TransactionID"].Value);
                    string col2 = Convert.ToString(dr.Cells["TransactionDate"].Value);
                    string col3 = Convert.ToString(dr.Cells["TransactionTime"].Value);
                    string col4 = Convert.ToString(dr.Cells["TransactionTotalPrice"].Value);

                    if (!string.IsNullOrEmpty(col1 + col2 + col3 + col4))
                    {
                        transactions_table.Rows.Add(i, col1, col2, col3, col4);
                    }
                    i++;
                }
            }
            transactions_table.ClearSelection();
        }

        private void transactions_table_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 5 || e.ColumnIndex == 6 || e.ColumnIndex == 7)
                    transactions_table.Cursor = Cursors.Hand;
            }
            else
            {
                transactions_table.Cursor = Cursors.Default;
            }
        }

        private void transactions_table_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            transactions_table.Cursor = Cursors.Default;
        }

        private void transactions_table_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string tid = transactions_table.Rows[e.RowIndex].Cells[1].Value.ToString();
                switch (e.ColumnIndex)
                {
                    case 5:
                        Auth.ReadKey();
                        Auth.DecryptFile("transactions.xml", Auth.EncryptedKey);
                        XmlDocument xml = new XmlDocument();
                        xml.Load("transactions.xml");
                        XmlNodeList xnList = xml.SelectNodes("/Transactions/Transaction[TransactionID='" + tid + "']/TransactionProducts/TransactionProduct");
                        foreach (XmlNode xn in xnList)
                        {
                            string pn = xn["ProductName"].InnerText;
                            string pq = xn["ProductQuantity"].InnerText;
                            string pp = xn["ProductPrice"].InnerText;
                            MessageBox.Show(string.Format("{0} - {1} units - {2}", pn, pq, pp));
                        }
                        Auth.ReadKey();
                        Auth.EncryptFile("transactions.xml", Auth.EncryptedKey);
                        this.Enabled = false;
                        break;

                    case 6:
                        Auth.ReadKey();
                        Auth.DecryptFile("transactions.xml", Auth.EncryptedKey);
                        XmlDocument docs = new XmlDocument();
                        docs.Load("transactions.xml");
                        CreateEditSale ces = new CreateEditSale(this);
                        DataGridViewRow dgvRow = transactions_table.Rows[e.RowIndex];
                        ces.ActiveControl = ces.label1;
                        ces.TransactionID = dgvRow.Cells[1].Value.ToString();
                        string date = dgvRow.Cells[2].Value.ToString();
                        string time = dgvRow.Cells[3].Value.ToString();
                        string secondDate = date.Trim().Replace(",", " ");
                        string secondTime = time.Replace(":", " ");
                        string[] finalDate = secondDate.Split();
                        string[] finalTime = secondTime.Split();
                        string finalyear = secondDate.Substring(secondDate.Length - 4, 4);
                        string minper = finalTime[1];
                        string finalmin = minper.Substring(0, 2);
                        string finalperiod = minper.Substring(2, 2);
                        ces.label1.Text = "EDIT TRANSACTION";
                        ces.day_textbox.Texts = finalDate[1];
                        ces.month_combobox.Texts = finalDate[0];
                        ces.year_textbox.Texts = finalyear;
                        ces.hour_textbox.Texts = finalTime[0];
                        ces.min_textbox.Texts = finalmin;
                        ces.period_combobox.Texts = finalperiod;
                        Auth.ReadKey();
                        Auth.EncryptFile("transactions.xml", Auth.EncryptedKey);
                        ces.LoadReceipt(tid);
                        ces.Show();
                        break;
                    case 7:
                        if (MessageBox.Show("Are you sure you want to delete this transaction?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            Auth.ReadKey();
                            Auth.DecryptFile("transactions.xml", Auth.EncryptedKey);
                            XmlDocument doc = new XmlDocument();
                            doc.Load("transactions.xml");
                            XmlNode node = doc.SelectSingleNode(String.Format("/Transactions/Transaction[TransactionID='{0}']", tid));
                            node.ParentNode.RemoveChild(node);
                            doc.Save("transactions.xml");
                            MessageBox.Show("Transaction was succesfully deleted!");
                            Auth.ReadKey();
                            Auth.EncryptFile("transactions.xml", Auth.EncryptedKey);
                            this.Enabled = false;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
