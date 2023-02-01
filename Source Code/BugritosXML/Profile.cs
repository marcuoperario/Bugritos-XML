using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BugritosXML
{
    public partial class Profile : UserControl
    {
        public string UserFullName, UserEmail, UserFirstName, UserLastName, UserID;
        public string UserGender, UserBirthday, UserBDDay, UserBDMonth, UserBDYear;

        private void Profile_Load(object sender, EventArgs e)
        {
            UserID = Program.UserID;
            DataSource();
        }
        private void Profile_EnabledChanged(object sender, EventArgs e)
        {
            this.Enabled = true;
            BringToFront();
            DataSource();
        }
        public Profile()
        {
            InitializeComponent();
            panel1.Region = Region.FromHrgn(RoundedForms.CreateRoundRect(0, 0, panel1.Width, panel1.Height, 30, 30));
            panel7.Region = Region.FromHrgn(RoundedForms.CreateRoundRect(0, 0, panel7.Width, panel7.Height, 30, 30));
        }

        private void DataSource()
        {
            Auth.ReadKey();
            Auth.DecryptFile("users.xml", Auth.EncryptedKey);
            XmlDocument docx = new XmlDocument();
            docx.Load("users.xml");
            XmlNodeList userinfo = docx.SelectNodes(String.Format("//User[UserID ='{0}']", UserID));
            if (userinfo != null)
            {
                foreach (XmlNode xn in userinfo)
                {
                    UserFirstName = xn["FirstName"].InnerText;
                    UserLastName = xn["LastName"].InnerText;
                    UserGender = xn["Gender"].InnerText;
                    UserBirthday = xn["Birthday"].InnerText;
                    UserEmail = xn["EmailAddress"].InnerText;
                }
                string date = UserBirthday;
                string secondDate = date.Trim().Replace(",", " ");
                string[] finalDate = secondDate.Split();
                string finalyear = secondDate.Substring(secondDate.Length - 4, 4);
                name_button.Text = "Name: " + UserFirstName + " " + UserLastName;
                gender_button.Text = "Gender: " + UserGender;
                email_button.Text = "Email Address: " + UserEmail;
                birthdate_button.Text = "Birth Date: " + UserBirthday;
                UserBDDay = finalDate[1];
                UserBDMonth = finalDate[0];
                UserBDYear = finalyear;
            }
            Auth.ReadKey();
            Auth.EncryptFile("users.xml", Auth.EncryptedKey);
        }
    }
}
