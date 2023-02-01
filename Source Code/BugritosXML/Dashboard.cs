using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugritosXML
{
    public partial class Dashboard : Form
    {
        public string UserFullName, UserEmail, UserID;
        public int UserPasswordLength;

        public Dashboard()
        {
            InitializeComponent();
            this.ActiveControl = home_button;
            this.Region = Region.FromHrgn(RoundedForms.CreateRoundRect(0, 0, this.Width, this.Height, 30, 30));
        }

        private void transactions_button_Click(object sender, EventArgs e)
        {
            content_panel.Controls.Clear();
            content_panel.HorizontalScroll.Maximum = 0;
            content_panel.AutoScroll = false;
            content_panel.HorizontalScroll.Visible = false;
            content_panel.AutoScroll = true;
            transactions1.Enabled = false;
            home1.Enabled = false;
            products1.Enabled = false;
            content_panel.Controls.Add(transactions1);
            url_textbox.Texts = "https://www.bugritosapp.com/transactions";
        }

        private void products_button_Click(object sender, EventArgs e)
        {
            content_panel.Controls.Clear();
            content_panel.HorizontalScroll.Maximum = 0;
            content_panel.AutoScroll = false;
            content_panel.HorizontalScroll.Visible = false;
            content_panel.AutoScroll = true;
            transactions1.Enabled = false;
            home1.Enabled = false;
            products1.Enabled = false;
            content_panel.Controls.Add(products1);
            url_textbox.Texts = "https://www.bugritosapp.com/products";
        }
        public static void Alert(string msg)
        {
            ErrorMessages err = new ErrorMessages();
            err.showAlert(msg);
            ActiveForm.BringToFront();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ModifierKeys == Keys.Alt || ModifierKeys == Keys.F4 || ModifierKeys == Keys.Tab)
            {
                e.Cancel = true;
            }
        }

        private void employees_button_Click(object sender, EventArgs e)
        {
            content_panel.Controls.Clear();
            content_panel.HorizontalScroll.Maximum = 0;
            content_panel.AutoScroll = false;
            content_panel.HorizontalScroll.Visible = false;
            content_panel.AutoScroll = true;
            transactions1.Enabled = false;
            home1.Enabled = false;
            products1.Enabled = false;
            content_panel.Controls.Add(employees1);
            url_textbox.Texts = "https://www.bugritosapp.com/employees";
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            content_panel.Controls.Clear();
            content_panel.HorizontalScroll.Maximum = 0;
            content_panel.AutoScroll = false;
            content_panel.HorizontalScroll.Visible = false;
            content_panel.AutoScroll = true;
            transactions1.Enabled = false;
            home1.Enabled = false;
            products1.Enabled = false;
            content_panel.Controls.Add(home1);
            url_textbox.Texts = "https://www.bugritosapp.com/home/dashboard";
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            home_button.PerformClick();
            userModal1.name_label.Text = UserFullName;
            userModal1.email_label.Text = UserEmail;
        }

        private void profile_button_Click(object sender, EventArgs e)
        {
            userModal1.Location = new Point(755, 51);
            if (userModal1.Visible == false)
            {
                userModal1.Visible = true;
                userModal1.BringToFront();
            }
            else
            {
                userModal1.Visible = false;
                userModal1.SendToBack();
            }
        }

        private void siteinfo_button_Click(object sender, EventArgs e)
        {
            browserModal1.Location = new Point(220, 51);
            if (browserModal1.Visible == false)
            {
                browserModal1.Visible = true;
                browserModal1.BringToFront();
            }
            else
            {
                browserModal1.Visible = false;
                browserModal1.SendToBack();
            }
        }

        private void userModal1_EnabledChanged(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void userModal1_Leave(object sender, EventArgs e)
        {
            content_panel.Controls.Clear();
            content_panel.HorizontalScroll.Enabled = false;
            content_panel.AutoScroll = false;
            content_panel.HorizontalScroll.Visible = false;
            content_panel.AutoScroll = true;
            content_panel.Controls.Add(profile1);
            url_textbox.Texts = "https://www.bugritosapp.com/profile/user/" + UserID;
        }

        private void products1_EnabledChanged(object sender, EventArgs e)
        {
            transactions1.Enabled = false;
        }

        private void fbpage_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/bugritosPH");
        }

        private void webapp_button_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("https://bugritostore.herokuapp.com/");
        }
    }
}
