using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;
using System.Security.Cryptography;

namespace BugritosXML
{
    public partial class signup : Form
    {
        public static string UserEmail;
        public int days, year;
        public static List<int> dayslist = new List<int>();
        public signup()
        {
            InitializeComponent();
            next_button.Enabled = false;
            next_button2.Enabled = false;
            next_button2.Visible = false;
            signup_button.Enabled = false;
            password_textbox.Visible = false;
            email_textbox.Visible = false;
            gender_input.Visible = false;
            day_textbox.Visible = false;
            month_combobox.Visible = false;
            year_textbox.Visible = false;
            this.ActiveControl = label1;
            this.Region = Region.FromHrgn(RoundedForms.CreateRoundRect(0, 0, this.Width, this.Height, 30, 30));
        }

        public static void Alert(string msg)
        {
            ErrorMessages err = new ErrorMessages();
            err.showAlert(msg);
        }

        private void login_account_Click(object sender, EventArgs e)
        {
            signin F1 = new signin();
            F1.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_account_MouseHover(object sender, EventArgs e)
        {
            login_account.Font = new Font(login_account.Font.Name, login_account.Font.Size, FontStyle.Underline);
        }

        private void login_account_MouseLeave(object sender, EventArgs e)
        {
            login_account.Font = new Font(login_account.Font.Name, login_account.Font.Size);
        }

        private void exit_MouseHover(object sender, EventArgs e)
        {
            exit.Font = new Font(exit.Font.Name, exit.Font.Size, FontStyle.Underline);
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.Font = new Font(exit.Font.Name, exit.Font.Size);
        }

        private void fname_textbox_Leave(object sender, EventArgs e)
        {
            fname_textbox.BorderColor = Color.Black;
            fname_textbox.BorderSize = 2;
            if (inputChecker1(fname_textbox.Texts, lname_textbox.Texts) == true)
                return;
            else
                nextButton2();
        }

        private void lname_textbox_Leave(object sender, EventArgs e)
        {
            lname_textbox.BorderColor = Color.Black;
            lname_textbox.BorderSize = 2;
            if (inputChecker1(fname_textbox.Texts, lname_textbox.Texts) == true)
                return;
            else
                nextButton2();
        }

        private void signup_MouseHover(object sender, EventArgs e)
        {
            if (inputChecker1(fname_textbox.Texts, lname_textbox.Texts) == true)
            {
                return;
            }
            else
            {
                nextButton2();
            }
            if (gender_input.SelectedIndex < 0 || inputChecker5(month_combobox.Texts, day_textbox.Texts, year_textbox.Texts) == true || month_combobox.SelectedIndex < 0)
            {
                return;
            }
            else
            {
                nextButton4();
            }

            if (inputChecker1(email_textbox.Texts, password_textbox.Texts) == true)
            {
                return;
            }
            else
            {
                signupButton2();
            }
        }

        private void email_textbox_Leave(object sender, EventArgs e)
        {
            email_textbox.BorderColor = Color.Black;
            email_textbox.BorderSize = 2;
            if (inputChecker1(email_textbox.Texts, password_textbox.Texts) == true)
                return;
            else
                signupButton2();
        }

        private void password_textbox_Leave(object sender, EventArgs e)
        {
            password_textbox.BorderColor = Color.Black;
            password_textbox.BorderSize = 2;
            if (inputChecker1(email_textbox.Texts, password_textbox.Texts) == true)
                return;
            else
                signupButton2();
        }


        private void fname_textbox_Enter(object sender, EventArgs e)
        {
            fname_textbox.BorderColor = Color.Crimson;
            fname_textbox.BorderSize = 3;
        }

        private void lname_textbox_Enter(object sender, EventArgs e)
        {
            lname_textbox.BorderColor = Color.Crimson;
            lname_textbox.BorderSize = 3;
        }

        private void password_textbox_Enter(object sender, EventArgs e)
        {
            password_textbox.BorderColor = Color.Crimson;
            password_textbox.BorderSize = 3;
        }

        private void email_textbox_Enter(object sender, EventArgs e)
        {
            email_textbox.BorderColor = Color.Crimson;
            email_textbox.BorderSize = 3;
        }

        private void gender_input_Enter(object sender, EventArgs e)
        {
            gender_input.BorderColor = Color.Crimson;
            gender_input.BorderSize = 3;
        }

        private void gender_input_Leave(object sender, EventArgs e)
        {
            gender_input.BorderColor = Color.Black;
            gender_input.BorderSize = 1;
            if (gender_input.SelectedIndex < 0 || inputChecker5(month_combobox.Texts, day_textbox.Texts, year_textbox.Texts) == true)
                return;
            else
                nextButton4();
        }
        private void nextButton1()
        {
            next_button.Enabled = false;
            next_button.BackColor = Color.Gainsboro;
            next_button.ForeColor = Color.Gray;
        }


        private void nextButton2()
        {
            next_button.BackColor = Color.DarkSlateBlue;
            next_button.ForeColor = Color.White;
            next_button.Enabled = true;
        }

        private void nextButton3()
        {
            next_button2.Enabled = false;
            next_button2.BackColor = Color.Gainsboro;
            next_button2.ForeColor = Color.Gray;
        }

        private void nextButton4()
        {
            next_button2.BackColor = Color.DarkSlateBlue;
            next_button2.ForeColor = Color.White;
            next_button2.Enabled = true;
        }

        private void signupButton1()
        {
            signup_button.Enabled = false;
            signup_button.BackColor = Color.Gainsboro;
            signup_button.ForeColor = Color.Gray;
        }

        private void signupButton2()
        {
            signup_button.BackColor = ColorTranslator.FromHtml("#FF1848");
            signup_button.ForeColor = Color.White;
            signup_button.Enabled = true;
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

        private static bool NotEmail(string input)
        {
            try
            {
                MailAddress ma = new MailAddress(input);
                return false;
            }
            catch
            {
                return true;
            }
        }

        private static bool EmailTaken(string input)
        {
            if (input == UserEmail)
                return true;
            return false;
        }

        private static bool NoDates(string input1, string input2, string input3)
        {
            if (string.IsNullOrEmpty(input1) == true || string.IsNullOrEmpty(input2) == true || string.IsNullOrEmpty(input3) || input1 == "Day" || input2 == "Month" || input3 == "Year")
                return true;
            return false;
        }

        private static bool LengthDates(string input1, string input2)
        {
            if (input1.Length < 1|| input1.Length > 2 || input2.Length != 4)
                return true;
            return false;
        }
        private void LoadXML(string input1, string input2)
        {
            DataSet ds = new DataSet();
            ds.CaseSensitive = true;
            ds.ReadXml(input1);
            DataView dv = new DataView(ds.Tables[0]);
            dv.RowFilter = "EmailAddress = '" + input2 + "'";
            dataGridView1.DataSource = dv;
        }

        private void FilterXML()
        {
            if (dataGridView1.Rows != null && dataGridView1.Rows.Count != 0)
            {
                UserEmail = dataGridView1.Rows[0].Cells[4].Value.ToString();
            }
        }


        private static bool inputChecker1(string input1, string input2)
        {
            if (string.IsNullOrEmpty(input1) || string.IsNullOrEmpty(input2))
                return true;
            return false;
        }

        private static bool inputChecker2(string input1, string input2)
        {
            if (hasSpecialChar(input1) == true || hasSpecialChar(input2) == true || hasDigit(input1) == true || hasDigit(input2) == true)
                return true;
            return false;
        }

        private static bool inputChecker3(string input)
        {
            if (NotEmail(input) == true)
                return true;
            return false;
        }

        private static bool inputChecker4(string input)
        {
            if (EmailTaken(input) == true)
                return true;
            return false;
        }

        private static bool inputChecker5(string input1, string input2, string input3)
        {
            if (NoDates(input1, input2, input3) == true)
                return true;
            return false;
        }

        private static bool inputChecker6(string input1, string input2)
        {
            if (LengthDates(input1, input2) == true)
                return true;
            return false;
        }

        private void NewXML(string input1, string input2)
        {
            XmlTextWriter xmlWriter = new XmlTextWriter("users.xml", System.Text.Encoding.UTF8);
            xmlWriter.Formatting = Formatting.Indented;
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("Users");
            xmlWriter.WriteStartElement("User");
            xmlWriter.WriteElementString("UserID", input1);
            xmlWriter.WriteElementString("FirstName", fname_textbox.Texts);
            xmlWriter.WriteElementString("LastName", lname_textbox.Texts);
            xmlWriter.WriteElementString("Gender", gender_input.Texts);
            xmlWriter.WriteElementString("EmailAddress", email_textbox.Texts);
            xmlWriter.WriteElementString("Birthday", month_combobox.Texts + " " + day_textbox.Texts + ", " + year_textbox.Texts);
            xmlWriter.WriteElementString("EncryptedPassword", input2);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Flush();
            xmlWriter.Close();
        }
        
        private void AddToExistingXML(string input1, string input2)
        {
            XDocument xDocument = XDocument.Load("users.xml");
            XElement root = xDocument.Element("Users");
            IEnumerable<XElement> rows = root.Descendants("User");
            XElement firstRow = rows.First();
            firstRow.AddBeforeSelf(
               new XElement("User",
               new XElement("UserID", input1),
               new XElement("FirstName", fname_textbox.Texts),
               new XElement("LastName", lname_textbox.Texts),
               new XElement("Gender", gender_input.Texts),
               new XElement("EmailAddress", email_textbox.Texts),
               new XElement("Birthday", month_combobox.Texts + " " + day_textbox.Texts + ", " + year_textbox.Texts),
               new XElement("EncryptedPassword", input2)
               ));
            xDocument.Save("users.xml");
        }

        private void next_button2_Click(object sender, EventArgs e)
        {
            DisplayDay(month_combobox.Texts);
            for (int i = 1; i <= days; i++)
            {
                dayslist.Add(i);
            }
            if (gender_input.SelectedIndex < 0 || inputChecker5(month_combobox.Texts, day_textbox.Texts,year_textbox.Texts) == true || month_combobox.SelectedIndex < 0)
            {
                nextButton3();
                Alert("Insufficient input given!");
                return;
            }
            else if (inputChecker6(day_textbox.Texts, year_textbox.Texts) == true)
            {
                nextButton3();
                Alert("Invalid input given!");
                return;
            }
            else
            {
                h1.Text = "Email";
                h2.Text = "Password";
                day_textbox.Enabled = false;
                month_combobox.Enabled = false;
                year_textbox.Enabled = false;
                day_textbox.Visible = true;
                month_combobox.Visible = true;
                year_textbox.Visible = true;
                gender_input.Enabled = false;
                day_textbox.Visible = false ;
                month_combobox.Visible = false;
                year_textbox.Visible = false;
                gender_input.Visible = false;
                email_textbox.Visible = true;
                password_textbox.Visible = true;
                next_button2.Enabled = false;
                next_button2.Visible = false;
            }
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            if (inputChecker1(fname_textbox.Texts, lname_textbox.Texts) == true)
            {
                nextButton1();
                Alert("Insufficient input given!");
                return;
            }
            else if (inputChecker2(fname_textbox.Texts, lname_textbox.Texts) == true)
            {
                nextButton1();
                Alert("Invalid input given!");
                return;
            }
            else
            {
                h1.Text = "Gender";
                h2.Text = "Birthday";
                fname_textbox.Enabled = false;
                lname_textbox.Enabled = false;
                fname_textbox.Visible = false;
                lname_textbox.Visible = false;
                gender_input.Visible = true;
                day_textbox.Visible = true;
                month_combobox.Visible = true;
                year_textbox.Visible = true;
                next_button.Enabled = false;
                next_button.Visible = false;
                next_button2.Visible = true;
            }
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            if (inputChecker1(email_textbox.Texts, password_textbox.Texts) == true)
            {
                signupButton1();
                Alert("Insufficient input given!");
                return;
            }
            else if (inputChecker3(email_textbox.Texts) == true)
            {
                signupButton1();
                Alert("Invalid input given!");
                return;
            }
            else
            {
                Auth.RandomID(15);
                var UserID = Auth.UserID;
                var encryptedPassword = Auth.MD5Hash(password_textbox.Texts);
                if (!File.Exists("users.xml"))
                {
                    NewXML(UserID, encryptedPassword);
                }
                else
                {
                    Auth.ReadKey();
                    Auth.DecryptFile("users.xml", Auth.EncryptedKey);
                    LoadXML("users.xml", email_textbox.Texts);
                    FilterXML();
                    if (inputChecker4(email_textbox.Texts) == true)
                    {
                        signupButton1();
                        Alert("Email already registered!");
                        Auth.ReadKey();
                        Auth.EncryptFile("users.xml", Auth.EncryptedKey);
                        return;
                    }
                    AddToExistingXML(UserID, encryptedPassword);
                }
                MessageBox.Show("Successfully created an account!");
                signin F1 = new signin();
                F1.Show();
                this.Hide();
                Auth.ReadKey();
                Auth.EncryptFile("users.xml", Auth.EncryptedKey);
            }
        }

        private void day_textbox_Enter(object sender, EventArgs e)
        {
            day_textbox.BorderColor = Color.Crimson;
            day_textbox.BorderSize = 3;
            if (day_textbox.Texts == "Day")
                day_textbox.Texts = "";
        }

        private void day_textbox_Leave(object sender, EventArgs e)
        {
            day_textbox.BorderColor = Color.Black;
            day_textbox.BorderSize = 2;
            if (day_textbox.Texts == "")
                day_textbox.Texts = "Day";
        }

        private void month_combobox_Enter(object sender, EventArgs e)
        {
            month_combobox.BorderColor = Color.Crimson;
            month_combobox.BorderSize = 3;
            if (month_combobox.Texts == "Month")
                month_combobox.Texts = "";
        }

        private void month_combobox_Leave(object sender, EventArgs e)
        {
            month_combobox.BorderColor = Color.Black;
            month_combobox.BorderSize = 2;
            if (month_combobox.Texts == "")
                month_combobox.Texts = "Month";
        }

        private void year_textbox_Enter(object sender, EventArgs e)
        {
            year_textbox.BorderColor = Color.Crimson;
            year_textbox.BorderSize = 3;
            if (year_textbox.Texts == "Year")
                year_textbox.Texts = "";
        }

        private void year_textbox_Leave(object sender, EventArgs e)
        {
            year_textbox.BorderColor = Color.Black;
            year_textbox.BorderSize = 2;
            if (year_textbox.Texts == "")
                year_textbox.Texts = "Year";
        }

        private void signup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ModifierKeys == Keys.Alt || ModifierKeys == Keys.F4)
            {
                e.Cancel = true;
            }
        }

        private static bool CalendarDays(string input)
        {
            string[] ThirtyDaysMonth = { "April", "June", "September", "November" };

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
    }
}
