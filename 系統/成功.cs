using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 系統
{
    public partial class 成功 : Form
    { 
        public 成功()
        {
            InitializeComponent();
        }

        private void 成功_Load(object sender, EventArgs e)
        {

            textBox1.Text += "姓名：" + Program.name + "\r\n\n";
            textBox1.Text += "\r性別：" + Program.sex + "\r\n\n";
            textBox1.Text += "\r電話：" + Program.phone + "\r\n\n";
            textBox1.Text += "\rLINE ID：" + Program.line + "\r\n\n";
            textBox1.Text += "\r加入時間：" + Program.date + "\r\n\n";

        }


        private void button1_Click(object sender, EventArgs e)
        {
            mainform f = new mainform();
            this.Close();
            f.Show();
        }
    }
}
