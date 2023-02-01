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
    public partial class CreateEditProduct : Form
    {
        public string ProductID, ProductNamex, ProductType, ProductPrice;
        public readonly Products _parent;
        ModalBackground mb = new ModalBackground();
        public CreateEditProduct(Products parent)
        {
            mb.Show();
            InitializeComponent();
            _parent = parent;
            this.Region = Region.FromHrgn(RoundedForms.CreateRoundRect(0, 0, this.Width, this.Height, 30, 30));

        }


        public static void Alert(string msg)
        {
            ErrorMessages err = new ErrorMessages();
            err.showAlert(msg);
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                mb.Hide();
                this.Hide();
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            switch(label1.Text)
            {
                case "ADD PRODUCT":
                    if (inputChecker1(name_textbox.Texts, type_combobox.Texts, price_textbox.Texts) == true || type_combobox.SelectedIndex < 0 || name_textbox.Texts == "Name" || type_combobox.Texts == "Type" || price_textbox.Texts == "Price")
                    {
                        Alert("Insufficient input!");
                        return;
                    }
                    else if (inputChecker2(price_textbox.Texts, name_textbox.Texts) == true)
                    {
                        Alert("Invalid input given!");
                        return;
                    }
                    else
                    {
                        Auth.RandomID(5);
                        var ProductID = Auth.ProductID;
                        if (!File.Exists("products.xml"))
                        {
                            NewXML(ProductID);
                        }
                        else
                        {
                            Auth.ReadKey();
                            Auth.DecryptFile("products.xml", Auth.EncryptedKey);
                            LoadXML("products.xml", name_textbox.Texts);
                            FilterXML();
                            if (inputChecker3(ProductNamex, name_textbox.Texts) == true)
                            {
                                Alert("Product already edxists!");
                                Auth.ReadKey();
                                Auth.EncryptFile("products.xml", Auth.EncryptedKey);
                                return;
                            }
                            AddToExistingXML(ProductID);
                        }
                        MessageBox.Show("Successfully added a product!");
                        Auth.ReadKey();
                        Auth.EncryptFile("products.xml", Auth.EncryptedKey);
                        _parent.Enabled = false;
                        mb.Hide();
                        this.Hide();
                    }
                    break;
                case "EDIT PRODUCT":
                    if (inputChecker1(name_textbox.Texts, type_combobox.Texts, price_textbox.Texts) == true || type_combobox.SelectedIndex < 0 || name_textbox.Texts == "Name" || type_combobox.Texts == "Type" || price_textbox.Texts == "Price")
                    {
                        Alert("Insufficient input!");
                        return;
                    }
                    else if (inputChecker2(price_textbox.Texts, name_textbox.Texts) == true)
                    {
                        Alert("Invalid input given!");
                        return;
                    }
                    else
                    {
                        if (!File.Exists("products.xml"))
                        {
                            Alert("Database is empty!");
                        }
                        else
                        {
                            int price = Convert.ToInt32(price_textbox.Texts);
                            Auth.ReadKey();
                            Auth.DecryptFile("products.xml", Auth.EncryptedKey);
                            EditXML(name_textbox.Texts, type_combobox.Texts, price.ToString("N0"));
                            MessageBox.Show("Successfully edited this product!");
                            Auth.ReadKey();
                            Auth.EncryptFile("products.xml", Auth.EncryptedKey);
                            _parent.Enabled = false;
                            mb.Hide();
                            this.Hide();
                        }
                    }
                    break;
            }    
        }
        private void CreateEditProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ModifierKeys == Keys.Alt || ModifierKeys == Keys.F4)
            {
                e.Cancel = true;
            }
        }

        private void name_textbox_Enter(object sender, EventArgs e)
        {
            name_textbox.BorderColor = Color.Crimson;
            name_label.Visible = true;
            name_textbox.BorderSize = 4;
            name_label.ForeColor = Color.Crimson;
            if (name_textbox.Texts == "Name")
                name_textbox.Texts = "";
            name_textbox.ForeColor = Color.Black;
        }

        private void name_textbox_Leave(object sender, EventArgs e)
        {
            name_textbox.BorderColor = Color.FromArgb(128, 134, 139);
            name_textbox.BorderSize = 3;
            name_label.ForeColor = SystemColors.ControlText;
            if (string.IsNullOrEmpty(name_textbox.Texts) == true || name_textbox.Texts == "Name")
            {
                name_textbox.Texts = "Name";
                name_textbox.ForeColor = Color.FromArgb(128, 134, 139);
                name_label.Visible = false;
            }
            else
                name_label.Visible = true;
        }

        private void type_combobox_Enter(object sender, EventArgs e)
        {
            type_combobox.BorderColor = Color.Crimson;
            type_label.Visible = true;
            type_combobox.BorderSize = 4;
            type_label.ForeColor = Color.Crimson;
            if (type_combobox.Texts == "Type")
                type_combobox.Texts = "";
            type_combobox.ForeColor = Color.Black;
        }

        private void type_combobox_Leave(object sender, EventArgs e)
        {
            type_combobox.BorderColor = Color.FromArgb(128, 134, 139);
            type_combobox.BorderSize = 3;
            type_label.ForeColor = SystemColors.ControlText;
            if (string.IsNullOrEmpty(type_combobox.Texts) == true || type_combobox.Texts == "Type")
            {
                type_combobox.Texts = "Type";
                type_combobox.ForeColor = Color.FromArgb(128, 134, 139);
                type_label.Visible = false;
            }
            else
                type_label.Visible = true;
        }

        private void price_textbox_Enter(object sender, EventArgs e)
        {
            price_textbox.BorderColor = Color.Crimson;
            price_label.Visible = true;
            price_textbox.BorderSize = 4;
            price_label.ForeColor = Color.Crimson;
            if (price_textbox.Texts == "Price")
                price_textbox.Texts = "";
            price_textbox.ForeColor = Color.Black;
        }

        private void price_textbox_Leave(object sender, EventArgs e)
        {
            price_textbox.BorderColor = Color.FromArgb(128, 134, 139);
            price_textbox.BorderSize = 3;
            price_label.ForeColor = SystemColors.ControlText;
            if (string.IsNullOrEmpty(price_textbox.Texts) == true || price_textbox.Texts == "Price")
            {
                price_textbox.Texts = "Price";
                price_textbox.ForeColor = Color.FromArgb(128, 134, 139);
                price_label.Visible = false;
            }
            else
                price_label.Visible = true;
        }

        private void NewXML(string input1)
        {
            int price = Convert.ToInt32(price_textbox.Texts);
            XmlTextWriter xmlWriter = new XmlTextWriter("products.xml", System.Text.Encoding.UTF8);
            xmlWriter.Formatting = Formatting.Indented;
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("Products");
            xmlWriter.WriteStartElement("Product");
            xmlWriter.WriteElementString("ProductID", input1);
            xmlWriter.WriteElementString("ProductName", name_textbox.Texts);
            xmlWriter.WriteElementString("ProductType", type_combobox.Texts);
            xmlWriter.WriteElementString("ProductPrice", "₱ " + price.ToString("N0") + ".00");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Flush();
            xmlWriter.Close();
        }

        private void AddToExistingXML(string input)
        {
            int price = Convert.ToInt32(price_textbox.Texts);
            XDocument xDocument = XDocument.Load("products.xml");
            XElement root = xDocument.Element("Products");
            IEnumerable<XElement> rows = root.Descendants("Product");
            XElement firstRow = rows.FirstOrDefault();
            if (firstRow != null)
            {
               firstRow.AddBeforeSelf(
               new XElement("Product",
               new XElement("ProductID", input),
               new XElement("ProductName", name_textbox.Texts),
               new XElement("ProductType", type_combobox.Texts),
               new XElement("ProductPrice", "₱ " + price.ToString("N0") + ".00")
               ));
            }
            else
            {
                   root.Add(
                   new XElement("Product",
                   new XElement("ProductID", input),
                   new XElement("ProductName", name_textbox.Texts),
                   new XElement("ProductType", type_combobox.Texts),
                   new XElement("ProductPrice", "₱ " + price.ToString("N0") + ".00")
                   ));
            }
            
            xDocument.Save("products.xml");
        }

        private void LoadXML(string input1, string input2)
        {
            DataSet ds = new DataSet();
            ds.CaseSensitive = true;
            ds.ReadXml(input1);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataView dv = new DataView(ds.Tables[0]);
                dv.RowFilter = "ProductName = '" + input2 + "'";
                dataGridView1.DataSource = dv;
            }
        }

        private void FilterXML()
        {
            if (dataGridView1.Rows != null && dataGridView1.Rows.Count != 0)
                ProductNamex = dataGridView1.Rows[0].Cells[1].Value?.ToString();
        }

        private void EditXML(string input1, string input2, string input3)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("products.xml");
            doc.SelectSingleNode("/Products/Product/ProductID[text() = '" + ProductID + "']").ParentNode.SelectSingleNode("ProductName").InnerText = input1;
            doc.SelectSingleNode("/Products/Product/ProductID[text() = '" + ProductID + "']").ParentNode.SelectSingleNode("ProductType").InnerText = input2;
            doc.SelectSingleNode("/Products/Product/ProductID[text() = '" + ProductID + "']").ParentNode.SelectSingleNode("ProductPrice").InnerText = "₱ " + input3 + ".00";
            doc.Save("products.xml");
        }

        private static bool hasSpecialChar(string input)
        {
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,[]`" + '"' + "@";
            foreach (var item in specialChar)
            {
                if (input.Contains(item)) return true;
            }

            return false;
        }

        private static bool hasDigit(string input)
        {
            bool isDigitPresent = input.Any(c => char.IsDigit(c));
            if (isDigitPresent == true)
                return true;
            return false;
        }

        private void CreateEditProduct_Load(object sender, EventArgs e)
        {
            if (name_textbox.Texts != "Name")
                name_textbox.ForeColor = Color.Black;
            if (type_combobox.Texts != "Type")
                type_combobox.ForeColor = Color.Black;
            if(price_textbox.Texts != "Price")
                price_textbox.ForeColor = Color.Black;
        }

        public static bool inputChecker1(string input1, string input2, string input3)
        {
            if (string.IsNullOrEmpty(input1) ||  string.IsNullOrEmpty(input2) || string.IsNullOrEmpty(input3))
                return true;
            return false;
        }

        public static bool inputChecker2(string input1, string input2)
        {
            bool digitsOnly = input1.All(char.IsDigit);
            if (digitsOnly == false|| hasSpecialChar(input1) == true || hasDigit(input2) == true || hasSpecialChar(input2) == true)
                return true;
            return false;
        }

        public static bool inputChecker3(string input1, string input2)
        {
            if (input1 == input2)
                return true;
            return false;
        }
    }
}
