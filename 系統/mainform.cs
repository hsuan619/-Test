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
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void mainform_Load(object sender, EventArgs e)
        {
        }

        private void buttonsign_Click(object sender, EventArgs e)
        {
            
            add f = new add();
            f.Show();
           
        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            
            search f = new search();
            f.Show();
        }

        private void outputexcel_Click(object sender, EventArgs e)
        {
            
            excel f = new excel();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
