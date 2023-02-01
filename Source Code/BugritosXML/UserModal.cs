using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugritosXML
{
    public partial class UserModal : UserControl
    {
        public UserModal()
        {
            InitializeComponent();
            this.BorderStyle = BorderStyle.None;
            this.Region = Region.FromHrgn(RoundedForms.CreateRoundRect(0, 0, this.Width, this.Height, 30, 30));
        }

        private void viewprofile_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void signout_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to sign out?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                signin si = new signin();
                si.Show();
                this.Enabled = false;
                this.Hide();
            }
        }
    }
}
