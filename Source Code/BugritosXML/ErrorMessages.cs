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
    public partial class ErrorMessages : Form
    {
        public ErrorMessages()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }
        public enum enmAction
        {
            wait,
            start,
            close
        }
        private ErrorMessages.enmAction action;
        private int x, y;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enmAction.close;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    timer1.Interval = 5000;
                    action = enmAction.close;
                    break;
                case enmAction.start:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = enmAction.wait;
                        }
                    }
                    break;
                case enmAction close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ErrorMessages_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ModifierKeys == Keys.Alt || ModifierKeys == Keys.F4)
            {
                e.Cancel = true;
            }
        }

        public void showAlert(string msg)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                ErrorMessages frm = (ErrorMessages)Application.OpenForms[fname];
                this.Name = fname;
                this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width - 420;
                this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i + 450;
                this.Location = new Point(this.x, this.y);

            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width;
            this.label1.Text = msg;
            this.Show();
            this.action = enmAction.start;
            this.timer1.Interval = 1;
            timer1.Start();
        }
    }
}
