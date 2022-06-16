using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;





namespace 系統
{
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connetStr = "server=127.0.0.1;port=3306;user=root;password=; database=mom";
           
            MySqlConnection conn = new MySqlConnection(connetStr);
            try
            {
                
                if ((textBox1.Text == "") || (textBox2.Text == ""))
                {
                    MessageBox.Show("請輸入完整！！！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (textBox3.Text == "")
                {
                    Program.line = "無";
                }
                else if (textBox3.Text != "")
                {
                    Program.line = textBox3.Text.Trim();
                }
                else
                {
                    if ((textBox1.Text.Length != 0) && textBox2.Text.Length == 10)
                    {
                        Program.name = textBox1.Text.Trim();
                        Program.phone = textBox2.Text.Trim();
                        string name = Program.name;
                        string phone = Program.phone;
                        string sex = Program.sex;
                        conn.Open();
                        string msg = "確定加入 " + name + " 嗎？";
                        if ((int)MessageBox.Show(msg, "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == 1)
                        {

                            MySqlCommand checkcmd = new MySqlCommand(string.Format("select Count(*) from member where username= '{0}'",name), conn);
                            object check = checkcmd.ExecuteScalar();
                            int count = Convert.ToInt32(check.ToString());

                            if (count == 0)
                            {
                                string localname;
                                try
                                {
                                    string sql0 = "SELECT localtion FROM ip WHERE phonenumber = @phonenumber";//?

                                    MySqlParameter parameter0 = new MySqlParameter("@phonenumber", phone.Substring(0, 9));
                                    MySqlCommand queryip = new MySqlCommand(sql0, conn);
                                    queryip.Parameters.Add(parameter0);
                                    localname = queryip.ExecuteScalar().ToString();
                                }
                                catch
                                {
                                    localname = "未知";
                                }


                                string sql = "INSERT INTO member (username,phone,sex,dateTime)" +
                                "VALUES(@username, @phone, @sex ,@local, @dateTime)";
                                MySqlParameter parameter1 = new MySqlParameter("@username", name);
                                MySqlParameter parameter2 = new MySqlParameter("@phonenumber", phone);
                                MySqlParameter parameter3 = new MySqlParameter("@dateTime", GetTimeStamp());
                                MySqlParameter parameter4 = new MySqlParameter("@sex", sex);
                                MySqlParameter parameter5 = new MySqlParameter("@local", localname);


                                MySqlCommand cmd = new MySqlCommand(sql, conn);
                                cmd.Parameters.Add(parameter1);
                                cmd.Parameters.Add(parameter2);
                                cmd.Parameters.Add(parameter3);
                                cmd.Parameters.Add(parameter4);

                                int result = cmd.ExecuteNonQuery();
                                if (result == 1)
                                {
                                    this.Close();
                                    成功 f = new 成功();
                                    f.Show();
                                }
                                else
                                {
                                    MessageBox.Show(name + "失敗", "提示");
                                }
                            }
                            else
                            {
                                string updatesql = string.Format("update `member` set `grade` = `grade`+ 10 WHERE `phonenumber` = '{0}'", phone);
                                MySqlCommand updataCmd = new MySqlCommand(updatesql, conn);
                                int upResult = updataCmd.ExecuteNonQuery();
                                if (upResult != 0)
                                {
                                    MessageBox.Show(name + "已存在,次數+1", "提示");
                                }
                                else
                                {
                                    MessageBox.Show(name + "次數無法增加", "提示");
                                }
                            }

                        }
                    }

                }
                
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("無法連接,請找你女兒", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        break;
                    case 1045:
                        MessageBox.Show("電話輸入錯誤", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        break;
                    default:
                        MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        break;
                }
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainform f = new mainform();
            this.Close();
            f.Show();
        }
        public string GetTimeStamp()
        {

            return DateTime.Now.ToShortDateString().ToString();
        }
    }

}
