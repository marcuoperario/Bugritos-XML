using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;


namespace BugritosXML
{   
    static class Program
    {
        public static string UserID;
        [STAThread]
        static void Main()
        {
            Auth.RandomEncryptionKey();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new signin());
        }

    }
}
