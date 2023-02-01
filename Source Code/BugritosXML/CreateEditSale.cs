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
    public partial class CreateEditSale : Form
    {
        public int days, year;
        public string TransactionID, TransactionDate, TransactionTime;
        public static List<int> dayslist = new List<int>();
        public static List<string> minuteslist = new List<string>();
        public static List<int> hourslist = new List<int>();
        public List<string> productnamelist = new List<string>();
        public List<string> productpricelist = new List<string>();
        public List<string> productqtylist = new List<string>();
        public readonly Transactions _parent;
        ModalBackground mb = new ModalBackground();

        public CreateEditSale(Transactions parent)
        {
            mb.Show();
            InitializeComponent();
            _parent = parent;
            this.Region = Region.FromHrgn(RoundedForms.CreateRoundRect(0, 0, this.Width, this.Height, 30, 30));
            receipt_table.Region = Region.FromHrgn(RoundedForms.CreateRoundRect(0, 0, receipt_table.Width, receipt_table.Height, 30, 30));
        }

        public static void Alert(string msg)
        {
            ErrorMessages err = new ErrorMessages();
            err.showAlert(msg);
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            DisplayDay(month_combobox.Texts);
            for (int i = 1; i <= days; i++)
            {
                dayslist.Add(i);
            }

            for (int i = 0; i <= 59; i++)
            {
                if (i < 10)
                {
                    string displayMinute = "0" + Convert.ToString(i);
                    minuteslist.Add(displayMinute);
                }
                else
                    minuteslist.Add(Convert.ToString(i));
            }

            for (int i = 1; i <= 12; i++)
            {
                hourslist.Add(i);
            }

            switch (label1.Text)
            {
                case "ADD TRANSACTION":
                    if (inputChecker1(day_textbox.Texts, month_combobox.Texts, year_textbox.Texts, hour_textbox.Texts, min_textbox.Texts, period_combobox.Texts) == true || receipt_table.Rows.Count <= 0)
                    {
                        Alert("Insufficient input given!");
                        return;
                    }

                    else if (inputChecker2(day_textbox.Texts, year_textbox.Texts, hour_textbox.Texts, min_textbox.Texts) == true || inputChecker3(Convert.ToInt32(day_textbox.Texts), Convert.ToInt32(hour_textbox.Texts)) == true || inputChecker4(year_textbox.Texts, min_textbox.Texts) == true)
                    {
                        Alert("Invalid input given!");
                        return;
                    }
                    else
                    {
                        Auth.RandomID(5);
                        var TransactionID = Auth.TransactionID;
                        if (!File.Exists("transactions.xml"))
                        {
                            NewXML(TransactionID);
                        }
                        else
                        {
                            Auth.ReadKey();
                            Auth.DecryptFile("transactions.xml", Auth.EncryptedKey);
                            AddToExistingXML(TransactionID);
                        }
                        MessageBox.Show("Successfully added a transaction!");
                        Auth.ReadKey();
                        Auth.EncryptFile("transactions.xml", Auth.EncryptedKey);
                        _parent.Enabled = false;
                        mb.Hide();
                        this.Hide();
                        break;
                    }
                case "EDIT TRANSACTION":
                    if (inputChecker1(day_textbox.Texts, month_combobox.Texts, year_textbox.Texts, hour_textbox.Texts, min_textbox.Texts, period_combobox.Texts) == true || receipt_table.Rows.Count <= 0)
                    {
                        Alert("Insufficient input given!");
                        return;
                    }
                    else if (inputChecker2(day_textbox.Texts, year_textbox.Texts, hour_textbox.Texts, min_textbox.Texts) == true || inputChecker3(Convert.ToInt32(day_textbox.Texts), Convert.ToInt32(hour_textbox.Texts)) == true || inputChecker4(year_textbox.Texts, min_textbox.Texts) == true)
                    {
                        Alert("Invalid input given!");
                        return;
                    }
                    else
                    {
                        if (!File.Exists("transactions.xml"))
                        {
                            Alert("Database is empty!");
                        }
                        else
                        {
                            Auth.ReadKey();
                            Auth.DecryptFile("transactions.xml", Auth.EncryptedKey);
                            string editdate = month_combobox.Texts + " " + day_textbox.Texts + ", " + year_textbox.Texts;
                            string edittime = hour_textbox.Texts + ":" + min_textbox.Texts + period_combobox.Texts;
                            EditXML1(editdate,edittime,total_price.Text);
                            EditXML2();
                            MessageBox.Show("Successfully edited this transaction!");
                            Auth.ReadKey();
                            Auth.EncryptFile("transactions.xml", Auth.EncryptedKey);
                            _parent.Enabled = false;
                            mb.Hide();
                            this.Hide();
                        }
                    }
                    break;
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                mb.Hide();
                this.Hide();
            }      
        }

        private void NewXML(string input1)
        {
            XmlTextWriter xmlWriter = new XmlTextWriter("transactions.xml", System.Text.Encoding.UTF8);
            xmlWriter.Formatting = Formatting.Indented;
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("Transactions");
            xmlWriter.WriteStartElement("Transaction");
            xmlWriter.WriteElementString("TransactionID", input1);
            xmlWriter.WriteElementString("TransactionDate", month_combobox.Texts + " " + day_textbox.Texts + ", " + year_textbox.Texts);
            xmlWriter.WriteElementString("TransactionTime", hour_textbox.Texts + ":" + min_textbox.Texts + period_combobox.Texts);
            xmlWriter.WriteStartElement("TransactionProducts");
            int i = 1;
            foreach (DataGridViewRow dr in receipt_table.Rows)
            {
                string col1 = Convert.ToString(dr.Cells["ProductName"].Value);
                string col2 = Convert.ToString(dr.Cells["ProductQuantity"].Value);
                string col3 = Convert.ToString(dr.Cells["ProductPrice"].Value);
                xmlWriter.WriteStartElement("TransactionProduct");
                xmlWriter.WriteElementString("ID", Convert.ToString(i));
                xmlWriter.WriteElementString("ProductName", col1);
                xmlWriter.WriteElementString("ProductQuantity", col2);
                xmlWriter.WriteElementString("ProductPrice", col3);
                xmlWriter.WriteEndElement();
                i++;
            }
            xmlWriter.WriteEndElement();
            xmlWriter.WriteElementString("TransactionTotalPrice", total_price.Text);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Flush();
            xmlWriter.Close();
        }

        private void AddToExistingXML(string input1)
        {
            XDocument xDocument = XDocument.Load("transactions.xml");
            XElement root = xDocument.Element("Transactions");
            IEnumerable<XElement> rows = root.Descendants("Transaction");
            XElement firstRow = rows.FirstOrDefault();
            if (firstRow != null)
            {
               firstRow.AddBeforeSelf(
               new XElement("Transaction",
               new XElement("TransactionID", input1),
               new XElement("TransactionDate", month_combobox.Texts + " " + day_textbox.Texts + ", " + year_textbox.Texts),
               new XElement("TransactionTime", hour_textbox.Texts + ":" + min_textbox.Texts + period_combobox.Texts),
               new XElement("TransactionProducts"),
               new XElement("TransactionTotalPrice", total_price.Text)
               ));
                IEnumerable<XElement> products = rows.Descendants("TransactionProducts");
                XElement row = products.FirstOrDefault();
                int i = 1;
                foreach (DataGridViewRow dr in receipt_table.Rows)
                {
                    string col1 = Convert.ToString(dr.Cells["ProductName"].Value);
                    string col2 = Convert.ToString(dr.Cells["ProductQuantity"].Value);
                    string col3 = Convert.ToString(dr.Cells["ProductPrice"].Value);
                    row.Add(
                    new XElement("TransactionProduct",
                    new XElement("ID", Convert.ToString(i)),
                    new XElement("ProductName", col1),
                    new XElement("ProductQuantity", col2),
                    new XElement("ProductPrice", col3)
                    ));
                    i++;
                }
            }
            else
            {
               root.Add(
               new XElement("Transaction",
               new XElement("TransactionID", input1),
               new XElement("TransactionDate", month_combobox.Texts + " " + day_textbox.Texts + ", " + year_textbox.Texts),
               new XElement("TransactionTime", hour_textbox.Texts + ":" + min_textbox.Texts + period_combobox.Texts),
               new XElement("TransactionProducts"),
               new XElement("TransactionTotalPrice", total_price.Text)
               ));
                IEnumerable<XElement> products = rows.Descendants("TransactionProducts");
                XElement row = products.FirstOrDefault();
                int i = 1;
                foreach (DataGridViewRow dr in receipt_table.Rows)
                {
                    string col1 = Convert.ToString(dr.Cells["ProductName"].Value);
                    string col2 = Convert.ToString(dr.Cells["ProductQuantity"].Value);
                    string col3 = Convert.ToString(dr.Cells["ProductPrice"].Value);
                    row.Add(
                    new XElement("TransactionProduct",
                    new XElement("ID", Convert.ToString(i)),
                    new XElement("ProductName", col1),
                    new XElement("ProductQuantity", col2),
                    new XElement("ProductPrice", col3)
                    ));
                }
            }
            xDocument.Save("transactions.xml");
        }

        private void EditXML1(string input1, string input2, string input3)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("transactions.xml");
            doc.SelectSingleNode("/Transactions/Transaction/TransactionID[text() = '" + TransactionID + "']").ParentNode.SelectSingleNode("TransactionDate").InnerText = input1;
            doc.SelectSingleNode("/Transactions/Transaction/TransactionID[text() = '" + TransactionID + "']").ParentNode.SelectSingleNode("TransactionTime").InnerText = input2;
            doc.SelectSingleNode("/Transactions/Transaction/TransactionID[text() = '" + TransactionID + "']").ParentNode.SelectSingleNode("TransactionTotalPrice").InnerText = input3;
            XmlNodeList nodes = doc.SelectNodes("/Transactions/Transaction[TransactionID='" + TransactionID + "']/TransactionProducts");
            foreach (XmlNode node in nodes)
            {
                node.ParentNode.RemoveChild(node);
            }
            doc.Save("transactions.xml");
        }

        private void EditXML2()
        {
            XDocument xDocument = XDocument.Load("transactions.xml");
            XElement root = xDocument.Element("Transactions");
            IEnumerable<XElement> rows = root.Descendants("Transaction").Where(x => (string)x.Element("TransactionID") == TransactionID);
            IEnumerable<XElement> newrows = rows.Descendants("TransactionTotalPrice");
            XElement rowa = newrows.FirstOrDefault();
            rowa.AddBeforeSelf(new XElement("TransactionProducts"));
            xDocument.Save("transactions.xml");
            XDocument xd = XDocument.Load("transactions.xml");
            XElement rootx = xd.Element("Transactions");
            IEnumerable<XElement> rowsx = rootx.Descendants("Transaction").Where(x => (string)x.Element("TransactionID") == TransactionID);
            IEnumerable<XElement> productsx = rowsx.Descendants("TransactionProducts");
            XElement row = productsx.FirstOrDefault();
            int i = 1;
            foreach (DataGridViewRow dr in receipt_table.Rows)
            {
                string col1 = Convert.ToString(dr.Cells["ProductName"].Value);
                string col2 = Convert.ToString(dr.Cells["ProductQuantity"].Value);
                string col3 = Convert.ToString(dr.Cells["ProductPrice"].Value);
                row.Add(
                new XElement("TransactionProduct",
                new XElement("ID", Convert.ToString(i)),
                new XElement("ProductName", col1),
                new XElement("ProductQuantity", col2),
                new XElement("ProductPrice", col3)
                ));
                i++;
            }
            xd.Save("transactions.xml");
        }

        private static bool CalendarDays(string input)
        {
            string [] ThirtyDaysMonth = { "April","June","September","November"};

            foreach (var item in ThirtyDaysMonth)
            {
                if (input.Contains(item)) return true;
            }
            return false;
        }

        private void DisplayDay(string input)
        {
            if (input != "February")
            {
                switch (CalendarDays(input))
                {
                    case true:
                        days = 30;
                        break;
                    case false:
                        days = 31;
                        break;
                }
            }
            else
                days = 29;
        }

        private void day_textbox_Enter(object sender, EventArgs e)
        {
            day_textbox.BorderColor = Color.Crimson;
            day_textbox.BorderSize = 4;
            day_label.ForeColor = Color.Crimson;
            day_textbox.ForeColor = Color.Black;
            if (day_textbox.Texts == "Day")
                day_textbox.Texts = "";
            day_label.Visible = true;
        }

        private void day_textbox_Leave(object sender, EventArgs e)
        {
            day_textbox.BorderColor = Color.FromArgb(128, 134, 139);
            day_textbox.BorderSize = 3;
            day_label.ForeColor = Color.FromArgb(128, 134, 139);
            if (string.IsNullOrEmpty(day_textbox.Texts) == true || day_textbox.Texts == "Day")
            {
                day_textbox.Texts = "Day";
                day_textbox.ForeColor = Color.FromArgb(128, 134, 139);
                day_label.Visible = false;
            }
            else
                day_label.Visible = true;
        }

        private void month_combobox_Enter(object sender, EventArgs e)
        {
            month_combobox.BorderColor = Color.Crimson;
            month_combobox.BorderSize = 4;
            month_label.ForeColor = Color.Crimson;
            month_combobox.ForeColor = Color.Black;
            if (month_combobox.Texts == "Month")
                month_combobox.Texts = "";
            month_label.Visible = true;
        }

        private void month_combobox_Leave(object sender, EventArgs e)
        {
            month_combobox.BorderColor = Color.FromArgb(128, 134, 139);
            month_combobox.BorderSize = 3;
            month_label.ForeColor = Color.FromArgb(128, 134, 139);
            if (string.IsNullOrEmpty(month_combobox.Texts) == true || month_combobox.Texts == "Month")
            {
                month_combobox.Texts = "Month";
                month_combobox.ForeColor = Color.FromArgb(128, 134, 139);
                month_label.Visible = false;
            }
            else
                month_label.Visible = true;
        }

        private void year_textbox_Enter(object sender, EventArgs e)
        {
            year_textbox.BorderColor = Color.Crimson;
            year_textbox.BorderSize = 4;
            year_label.ForeColor = Color.Crimson;
            year_textbox.ForeColor = Color.Black;
            if (year_textbox.Texts == "Year")
                year_textbox.Texts = "";
            year_label.Visible = true;
        }

        private void year_textbox_Leave(object sender, EventArgs e)
        {
            year_textbox.BorderColor = Color.FromArgb(128, 134, 139);
            year_textbox.BorderSize = 3;
            year_label.ForeColor = Color.FromArgb(128, 134, 139);
            if (string.IsNullOrEmpty(year_textbox.Texts) == true || year_textbox.Texts == "Year")
            {
                year_textbox.Texts = "Year";
                year_textbox.ForeColor = Color.FromArgb(128, 134, 139);
                year_label.Visible = false;
            }
            else
                year_label.Visible = true;
        }

        private void hour_textbox_Enter(object sender, EventArgs e)
        {
            hour_textbox.BorderColor = Color.Crimson;
            hour_textbox.BorderSize = 4;
            hour_label.ForeColor = Color.Crimson;
            hour_textbox.ForeColor = Color.Black;
            if (hour_textbox.Texts == "Hour")
                hour_textbox.Texts = "";
            hour_label.Visible = true;
        }

        private void hour_textbox_Leave(object sender, EventArgs e)
        {
            hour_textbox.BorderColor = Color.FromArgb(128, 134, 139);
            hour_textbox.BorderSize = 3;
            hour_label.ForeColor = Color.FromArgb(128, 134, 139);
            if (string.IsNullOrEmpty(hour_textbox.Texts) == true || hour_textbox.Texts == "Hour")
            {
                hour_textbox.Texts = "Hour";
                hour_textbox.ForeColor = Color.FromArgb(128, 134, 139);
                hour_label.Visible = false;
            }
            else
                hour_label.Visible = true;
        }

        private void min_textbox_Enter(object sender, EventArgs e)
        {
            min_textbox.BorderColor = Color.Crimson;
            min_textbox.BorderSize = 4;
            min_label.ForeColor = Color.Crimson;
            min_textbox.ForeColor = Color.Black;
            if (min_textbox.Texts == "Min")
                min_textbox.Texts = "";
            min_label.Visible = true;
        }

        private void min_textbox_Leave(object sender, EventArgs e)
        {
            min_textbox.BorderColor = Color.FromArgb(128, 134, 139);
            min_textbox.BorderSize = 3;
            min_label.ForeColor = Color.FromArgb(128, 134, 139);
            if (string.IsNullOrEmpty(min_textbox.Texts) == true || min_textbox.Texts == "Min")
            {
                min_textbox.Texts = "Min";
                min_textbox.ForeColor = Color.FromArgb(128, 134, 139);
                min_label.Visible = false;
            }
            else
                min_label.Visible = true;
        }

        private void period_combobox_Enter(object sender, EventArgs e)
        {
            period_combobox.BorderColor = Color.Crimson;
            period_combobox.BorderSize = 4;
            period_label.ForeColor = Color.Crimson;
            period_combobox.ForeColor = Color.Black;
            if (period_combobox.Texts == "AM/PM")
                period_combobox.Texts = "";
            period_label.Visible = true;
        }

        private void period_combobox_Leave(object sender, EventArgs e)
        {
            period_combobox.BorderColor = Color.FromArgb(128, 134, 139);
            period_combobox.BorderSize = 3;
            period_label.ForeColor = Color.FromArgb(128, 134, 139);
            if (string.IsNullOrEmpty(period_combobox.Texts) == true || period_combobox.Texts == "AM/PM")
            {
                period_combobox.Texts = "AM/PM";
                period_combobox.ForeColor = Color.FromArgb(128, 134, 139);
                period_label.Visible = false;
            }
            else
                period_label.Visible = true;
        }

        public static bool inputChecker1(string input1, string input2, string input3, string input4, string input5, string input6)
        {
            if (string.IsNullOrEmpty(input1) || string.IsNullOrEmpty(input2) || string.IsNullOrEmpty(input3) || string.IsNullOrEmpty(input4) || string.IsNullOrEmpty(input5) || string.IsNullOrEmpty(input6))
                return true;
            return false;
        }

        public static bool inputChecker2(string input1, string input2, string input3, string input4)
        {
            bool digitsOnly1 = input1.All(char.IsDigit);
            bool digitsOnly2 = input2.All(char.IsDigit);
            bool digitsOnly3 = input3.All(char.IsDigit);
            bool digitsOnly4 = input4.All(char.IsDigit);
            if (digitsOnly1 == false || digitsOnly2 == false || digitsOnly3 == false || digitsOnly4 == false)
                return true;
            return false;
        }

        private static bool inputChecker3(int input1, int input2)
        {
            foreach (var item in dayslist)
            {
                if (dayslist.Contains(input1) == false)
                    return true;
            }
            foreach (var item in hourslist)
            {
                if (hourslist.Contains(input2) == false)
                    return true;
            }
            return false;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            bool digitsonly = quantity_textbox.Texts.All(Char.IsDigit);
            if (string.IsNullOrEmpty(products_combobox.Texts) || string.IsNullOrEmpty(quantity_textbox.Texts) || products_combobox.SelectedIndex < 0)
            {
                Alert("Insufficient input!");
                return;
            }
            else if (digitsonly == false || Convert.ToInt32(quantity_textbox.Texts) < 0)
            {
                Alert("Invalid input!");
                return;
            }
            else
            {   
                int k = products_combobox.Items.IndexOf(products_combobox.Texts);
                string price = productpricelist.ElementAt(k);
                string finalPrice = price.Trim().Replace("₱", "").Replace(".00", "").Replace(",", "");
                if (receipt_table.Rows.Count > 0)
                {
                    int newquantity = 0;
                    int newprice = 0;
                    foreach (DataGridViewRow dr in receipt_table.Rows)
                    {
                        string col1 = Convert.ToString(dr.Cells["ProductName"].Value);
                        string col2 = Convert.ToString(dr.Cells["ProductQuantity"].Value);
                        string col3 = Convert.ToString(dr.Cells["ProductPrice"].Value);
                        string FP = col3;
                        string PP = FP.Trim().Replace("₱", "").Replace(".00", "").Replace(",", "");
                        if (dr.Cells[0].Value.ToString() == products_combobox.Texts)
                        {
                            newquantity = Convert.ToInt32(quantity_textbox.Texts) + Convert.ToInt32(col2);
                            label2.Text = newquantity.ToString();
                            newprice =  Convert.ToInt32(finalPrice) * newquantity;
                            dr.Cells["ProductQuantity"].Value = newquantity;
                            string finalprice = "₱ " + newprice.ToString("N0") + ".00";
                            dr.Cells["ProductPrice"].Value = finalprice;
                            quantity_label.Visible = false;
                            quantity_textbox.Texts = "Qty.";
                            quantity_textbox.ForeColor = Color.FromArgb(128, 134, 139);
                            MessageBox.Show("Added product!");
                            label2.Enabled = false;
                            return;
                        }
                    }
                }
                int lastprice = Convert.ToInt32(quantity_textbox.Texts) * Convert.ToInt32(finalPrice);
                AddReceipt(products_combobox.Texts, quantity_textbox.Texts, "₱ " + lastprice.ToString("N0") + ".00");
                receipt_table.ClearSelection();
                quantity_label.Visible = false;
                quantity_textbox.Texts = "Qty.";
                quantity_textbox.ForeColor = Color.FromArgb(128, 134, 139);
                MessageBox.Show("Added product!");
                label2.Enabled = false;
            }
        }

        private static bool inputChecker4(string input1, string input2)
        {
            if (input1.Length != 4 || minuteslist.Contains(input2) == false)
                return true;
            return false;
        }

        private void products_combobox_Enter(object sender, EventArgs e)
        {
            products_combobox.BorderColor = Color.Crimson;
            products_combobox.BorderSize = 4;
            products_label.ForeColor = Color.Crimson;
            products_combobox.ForeColor = Color.Black;
            if (products_combobox.Texts == "Product")
                products_combobox.Texts = "";
            products_label.Visible = true;
        }

        private void products_combobox_Leave(object sender, EventArgs e)
        {
            products_combobox.BorderColor = Color.FromArgb(128, 134, 139);
            products_combobox.BorderSize = 3;
            products_label.ForeColor = Color.FromArgb(128, 134, 139);
            if (string.IsNullOrEmpty(products_combobox.Texts) == true || products_combobox.Texts == "Product")
            {
                products_combobox.Texts = "Product";
                products_combobox.ForeColor = Color.FromArgb(128, 134, 139);
                products_label.Visible = false;
            }
            else
                products_label.Visible = true;
        }

        private void quantity_textbox_Enter(object sender, EventArgs e)
        {
            quantity_textbox.BorderColor = Color.Crimson;
            quantity_textbox.BorderSize = 4;
            quantity_label.ForeColor = Color.Crimson;
            quantity_textbox.ForeColor = Color.Black;
            if (quantity_textbox.Texts == "Qty.")
                quantity_textbox.Texts = "";
            quantity_label.Visible = true;
        }

        private void quantity_textbox_Leave(object sender, EventArgs e)
        {
            quantity_textbox.BorderColor = Color.FromArgb(128, 134, 139);
            quantity_textbox.BorderSize = 3;
            quantity_label.ForeColor = Color.FromArgb(128, 134, 139);
            if (string.IsNullOrEmpty(quantity_textbox.Texts) == true || quantity_textbox.Texts == "Qty.")
            {
                quantity_textbox.Texts = "Qty.";
                quantity_textbox.ForeColor = Color.FromArgb(128, 134, 139);
                quantity_label.Visible = false;
            }
            else
                quantity_label.Visible = true;
        }

        public void DataSource()
        {
            if (!File.Exists("products.xml"))
            {
                return;
            }
            else
            {
                Auth.ReadKey();
                Auth.DecryptFile("products.xml", Auth.EncryptedKey);
                dataGridView1.DataSource = null;
                products_combobox.DataSource = null;
                dataGridView1.Rows.Clear();
                LoadXML1();
                LoadXML2();
                receipt_table.ClearSelection();
                Auth.ReadKey();
                Auth.EncryptFile("products.xml", Auth.EncryptedKey);
            }
        }

        private void receipt_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                switch (e.ColumnIndex)
                {
                    case 3:
                        if (MessageBox.Show("Are you sure you want to delete this Product?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            receipt_table.Rows.RemoveAt(e.RowIndex);
                            receipt_table.Cursor = Cursors.Hand;
                            MessageBox.Show("Product deleted!");
                            label2.Enabled = false;
                        }
                        break;
                }
            }
            
        }

        private void LoadXML2()
        {
            if (receipt_table.Rows.Count == 0)
            {
                foreach (DataGridViewRow dr in receipt_table.Rows)
                {
                    string col1 = Convert.ToString(dr.Cells["ProductName"].Value);
                    string col2 = Convert.ToString(dr.Cells["ProductQuantity"].Value);
                    string col3 = Convert.ToString(dr.Cells["ProductPrice"].Value);
                    if (!string.IsNullOrEmpty(col1 + col2 + col3))
                    {
                        receipt_table.Rows.Add(col1, col2 + col3);
                    }
                }
            }
        }

        private void CreateEditSale_Load(object sender, EventArgs e)
        {
            DataSource();
        }

        private void LoadXML1()
        {
            DataSet ds = new DataSet();
            ds.Clear();
            ds.CaseSensitive = true;
            ds.ReadXml("products.xml");
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataView dv = new DataView(ds.Tables[0]);
                dataGridView1.DataSource = dv;
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
               productnamelist.Add(dataGridView1.Rows[i].Cells[1].Value?.ToString());
               productpricelist.Add(dataGridView1.Rows[i].Cells[3].Value?.ToString());
            }
            products_combobox.DataSource = productnamelist;
        }

        private void label2_EnabledChanged(object sender, EventArgs e)
        {
            label2.Enabled = true;
            DataSource();
            int sum = 0;
            if (receipt_table.Rows.Count > 0)
            {
                for (int i = 0; i < receipt_table.Rows.Count; i++)
                {
                    string FP = receipt_table.Rows[i].Cells[2].Value?.ToString();
                    if (FP != null)
                    {
                        string finalprice = FP.Trim().Replace("₱", "").Replace(".00", "").Replace(",", "");
                        sum += Convert.ToInt32(finalprice);
                    }
                    else
                    {
                        break;
                    }

                }
                total_price.Text = "₱ " + sum.ToString("N0") + ".00";
            }
            else
            {
                total_price.Text = "₱ 0.00";
            }
        }

        public void LoadCurrentTime()
        {
            DateTime now = DateTime.Now;
            day_textbox.Texts = now.ToString("dd");
            month_combobox.Texts = now.ToString("MMMM");
            year_textbox.Texts = now.ToString("yyyy");
            hour_textbox.Texts = now.ToString("hh");
            min_textbox.Texts = now.ToString("mm");
            period_combobox.Texts = now.ToString("tt");
        }

        public void AddReceipt(string input1, string input2, string input3)
        {
            int index = receipt_table.Rows.Add();
            receipt_table.Rows[index].Cells[0].Value = input1;
            receipt_table.Rows[index].Cells[1].Value = input2;
            receipt_table.Rows[index].Cells[2].Value = input3;
        }

        public void LoadReceipt(string input)
        {
            Auth.ReadKey();
            Auth.DecryptFile("transactions.xml", Auth.EncryptedKey);
            XmlDocument xml = new XmlDocument();
            xml.Load("transactions.xml");
            XmlNodeList xnList = xml.SelectNodes("/Transactions/Transaction[TransactionID='" + input + "']/TransactionProducts/TransactionProduct");
            int i = 0;
            foreach (XmlNode xn in xnList)
            {
                string pn = xn["ProductName"].InnerText;
                string pq = xn["ProductQuantity"].InnerText;
                string pp = xn["ProductPrice"].InnerText;
                receipt_table.Rows.Add();
                receipt_table.Rows[i].Cells[0].Value = pn;
                receipt_table.Rows[i].Cells[1].Value = pq;
                receipt_table.Rows[i].Cells[2].Value = pp;
                i++;
            }
            receipt_table.ClearSelection();
            Auth.ReadKey();
            Auth.EncryptFile("transactions.xml", Auth.EncryptedKey);
            label2.Enabled = false;
        }
    }
}
