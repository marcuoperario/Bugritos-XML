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
    public partial class ModalBackground : Form
    {
        public ModalBackground()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(RoundedForms.CreateRoundRect(0, 0, this.Width, this.Height, 30, 30));
        }

        private void ModalBackground_Load(object sender, EventArgs e)
        {

        }
    }
}
