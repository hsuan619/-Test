using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 系統
{
    internal class Program
    {
        public static mainform f1;
        public static string date = DateTime.Now.ToString();
        public static string phone;
        public static string line;
        public static string name;
        public static string sex;
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainform f1 = new mainform();
            Application.Run(f1);
        }
    }
}
