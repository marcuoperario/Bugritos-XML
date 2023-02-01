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

namespace BugritosXML
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            panel1.Region = Region.FromHrgn(RoundedForms.CreateRoundRect(0, 0, panel1.Width, panel1.Height, 30, 30));
            panel2.Region = Region.FromHrgn(RoundedForms.CreateRoundRect(0, 0, panel2.Width, panel2.Height, 30, 30));
            panel3.Region = Region.FromHrgn(RoundedForms.CreateRoundRect(0, 0, panel3.Width, panel3.Height, 30, 30));
            panel4.Region = Region.FromHrgn(RoundedForms.CreateRoundRect(0, 0, panel4.Width, panel4.Height, 30, 30));
            panel5.Region = Region.FromHrgn(RoundedForms.CreateRoundRect(0, 0, panel5.Width, panel5.Height, 30, 30));
            panel7.Region = Region.FromHrgn(RoundedForms.CreateRoundRect(0, 0, panel7.Width, panel7.Height, 30, 30));
        }

        private void DataSource()
        {

            if (File.Exists("transactions.xml"))
            {
                Auth.ReadKey();
                Auth.DecryptFile("transactions.xml", Auth.EncryptedKey);
                XmlDocument doc = new XmlDocument();
                doc.Load("transactions.xml");
                int transactionsCount = doc.SelectNodes("//Transaction").Count;
                XmlNodeList totalpricelist = doc.SelectNodes("//Transaction");
                XmlNodeList transactionslist = doc.SelectNodes("//Transaction");
                int totalPrice = 0;
                if (totalpricelist != null)
                {
                    foreach (XmlNode xn in totalpricelist)
                    {
                        string TTP = xn["TransactionTotalPrice"].InnerText;
                        string finaltotalprice = TTP.Trim().Trim().Replace("₱", "").Replace(".00", "").Replace(",", "");
                        totalPrice += Convert.ToInt32(finaltotalprice);
                    }
                }
                if (transactionslist != null)
                {
                    foreach (XmlNode xn in transactionslist)
                    {
                        string tid = xn["TransactionID"].InnerText;
                        string td = xn["TransactionDate"].InnerText;
                        string tt = xn["TransactionTime"].InnerText;
                        string ttp = xn["TransactionTotalPrice"].InnerText;
                        string price = ttp.Trim().Replace("₱", "").Replace(".00", "").Replace(",", "");
                        int finalPrice = Convert.ToInt32(price);
                        recenttransactions_label.Text = "ID: " + tid + "\r\n" + "Date: " + td + "\r\n" + "Time: " + tt + "\r\n" + "Total Price: " + "₱ " + finalPrice.ToString("N0") + ".00";
                        break;
                    }
                }
                earnings_label.Text = "₱ " + totalPrice.ToString("N0") + ".00";
                transactions_label.Text = Convert.ToString(transactionsCount);
                Auth.ReadKey();
                Auth.EncryptFile("transactions.xml", Auth.EncryptedKey);
            }

            if (File.Exists("products.xml"))
            {
                Auth.ReadKey();
                Auth.DecryptFile("products.xml", Auth.EncryptedKey);
                XmlDocument docs = new XmlDocument();
                docs.Load("products.xml");
                int productsCount = docs.SelectNodes("//Product").Count;
                XmlNodeList productslist = docs.SelectNodes("//Product");

                if (productslist != null)
                {
                    foreach (XmlNode xn in productslist)
                    {
                        string pn = xn["ProductName"].InnerText;
                        string pt = xn["ProductType"].InnerText;
                        string pp = xn["ProductPrice"].InnerText;
                        int finalprice = Convert.ToInt32(pp.Trim().Replace("₱", "").Replace(".00", "").Replace(",", ""));
                        recentproducts_label.Text = "Name: " + pn + "\r\n" + "Type: " + pt + "\r\n" + "Price: " + "₱ " + finalprice.ToString("N0") + ".00";
                        break;
                    }
                }
                products_label.Text = Convert.ToString(productsCount);
                Auth.ReadKey();
                Auth.EncryptFile("products.xml", Auth.EncryptedKey);
            }

            if (File.Exists("users.xml"))
            {
                Auth.ReadKey();
                Auth.DecryptFile("users.xml", Auth.EncryptedKey);
                XmlDocument docx = new XmlDocument();
                docx.Load("users.xml");
                int employeesCount = docx.SelectNodes("//User").Count;
                employees_label.Text = Convert.ToString(employeesCount);
                Auth.ReadKey();
                Auth.EncryptFile("users.xml", Auth.EncryptedKey);
            }
        }

        private void Home_EnabledChanged(object sender, EventArgs e)
        {
            this.Enabled = true;
            DataSource();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            DataSource();
        }
    }
}
