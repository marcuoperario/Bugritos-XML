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
using System.Xml;
using System.Xml.Serialization;

namespace BugritosXML
{
    public partial class signin : Form
    {
        public string UserFullName, UserEmail, UserFirstName, UserLastName, UserNameDisplay, UserID;
        private string UserEncryptedPassword;
        public int UserPasswordLength;
        public signin()
        {
            InitializeComponent();
            this.ActiveControl = label1;
            this.Region = Region.FromHrgn(RoundedForms.CreateRoundRect(0, 0, this.Width, this.Height, 30, 30));
        }
        public static void Alert(string msg)
        {
            ErrorMessages err = new ErrorMessages();
            err.showAlert(msg);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void create_account_Click(object sender, EventArgs e)
        {
            signup F1 = new signup();
            F1.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit the program?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                Application.Exit();
        }

        private void buttonRadius1_Click(object sender, EventArgs e)
        {
            if (inputChecker1(email_textbox.Texts, password_textbox.Texts) == true)
            {
                signinButton1();
                Alert("Insufficient input given!");
                return;
            }
            else if (inputChecker2(email_textbox.Texts) == false)
            {
                signinButton1();
                Alert("Invalid input given!");
                return;
            }
            else
            {
                if (!File.Exists("users.xml"))
                {
                    Alert("Database is empty!");
                }
                else
                {
                    var encryptedPassword = Auth.MD5Hash(password_textbox.Texts);
                    Auth.ReadKey();
                    Auth.DecryptFile("users.xml", Auth.EncryptedKey);
                    LoadXML("users.xml", email_textbox.Texts);
                    FilterXML();
                    bool input = inputChecker3(UserEncryptedPassword, encryptedPassword);                  
                    switch (input)
                    {
                        case true:
                            Dashboard db = new Dashboard();
                            Auth.ReadKey();
                            Auth.EncryptFile("users.xml", Auth.EncryptedKey);
                            db.UserID = UserID;
                            Program.UserID = UserID;
                            db.UserFullName = UserFullName;
                            db.UserEmail = UserEmail;
                            db.UserPasswordLength = UserPasswordLength;
                            db.profile_button.Text = UserNameDisplay;
                            db.Show();
                            this.Hide();
                            break;
                        default:
                            Alert("Incorrect credentials");
                            Auth.ReadKey();
                            Auth.EncryptFile("users.xml", Auth.EncryptedKey);
                            break;
                    }
                }
            }
        }

        private void create_account_MouseHover(object sender, EventArgs e)
        {
            create_account.Font = new Font(create_account.Font.Name, create_account.Font.Size, FontStyle.Underline);
        }

        private void create_account_MouseLeave(object sender, EventArgs e)
        {
            create_account.Font = new Font(create_account.Font.Name, create_account.Font.Size);
        }

        private void exit_MouseHover(object sender, EventArgs e)
        {
            exit.Font = new Font(exit.Font.Name, exit.Font.Size, FontStyle.Underline);
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.Font = new Font(exit.Font.Name, exit.Font.Size);
        }

        private void signin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ModifierKeys == Keys.Alt || ModifierKeys == Keys.F4)
            {
                e.Cancel = true;
            }
        }

        private void signinButton1()
        {
            signin_button.Enabled = false;
            signin_button.BackColor = Color.Gainsboro;
            signin_button.ForeColor = Color.Gray;
        }

        private void signinButton2()
        {

            signin_button.BackColor = ColorTranslator.FromHtml("#FF1848");
            signin_button.ForeColor = Color.White;
            signin_button.Enabled = true;
        }

        private void email_textbox_Leave(object sender, EventArgs e)
        {
            email_textbox.BorderColor = Color.Black;
            email_textbox.BorderSize = 1;
            if (inputChecker1(email_textbox.Texts, password_textbox.Texts) == true)
                return;
            else
                signinButton2();
        }

        private void password_textbox_Leave(object sender, EventArgs e)
        {
            password_textbox.BorderColor = Color.Black;
            password_textbox.BorderSize = 1;
            if (inputChecker1(email_textbox.Texts, password_textbox.Texts) == true)
                return;
            else
                signinButton2();
        }

        private void signin_MouseHover(object sender, EventArgs e)
        {
            if (inputChecker1(email_textbox.Texts, password_textbox.Texts) == true)
                return;
            else
                signinButton2();
        }
        public static bool inputChecker1(string input1, string input2)
        {
            if (string.IsNullOrEmpty(input1) || string.IsNullOrEmpty(input2))
                return true;
            return false;
        }
        public static bool inputChecker2(string input1)
        {
            try
            {
                MailAddress ma = new MailAddress(input1);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool inputChecker3(string input1, string input2)
        {
            if (string.IsNullOrEmpty(input1) == false)
            {
                if (input1.Trim() == input2.Trim())
                    return true; 
            }
            return false;

        }

        private void email_textbox_Enter(object sender, EventArgs e)
        {
            email_textbox.BorderColor = Color.Crimson;
            email_textbox.BorderSize = 3;
        }

        private void password_textbox_Enter(object sender, EventArgs e)
        {
            password_textbox.BorderColor = Color.Crimson;
            password_textbox.BorderSize = 3;
        }

        private void LoadXML(string input1, string input2)
        {
            DataSet ds = new DataSet();
            ds.CaseSensitive = true;
            ds.ReadXml(input1);
            DataView dv = new DataView(ds.Tables[0]);
            dv.RowFilter = "EmailAddress = '" + input2 +"'";
            dataGridView1.DataSource = dv;
        }

        private void FilterXML()
        {
            if (dataGridView1.Rows != null && dataGridView1.Rows.Count != 0)
            {
                UserID = dataGridView1.Rows[0].Cells[0].Value.ToString();
                UserFirstName = dataGridView1.Rows[0].Cells[1].Value.ToString();
                UserLastName = dataGridView1.Rows[0].Cells[2].Value.ToString();
                UserNameDisplay = UserFirstName + " " + UserLastName[0] + ".";
                UserFullName = UserFirstName + " " + UserLastName;
                UserEmail = dataGridView1.Rows[0].Cells[4].Value.ToString();
                UserEncryptedPassword = dataGridView1.Rows[0].Cells[6].Value.ToString();
            }
        }
    }
}
