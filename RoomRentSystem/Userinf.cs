using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace RoomRentSystem
{
    public partial class Userinf : Form
    {
        public Userinf()
        {
            InitializeComponent();
        }
        public bool IsNum(String strNumber) 
        { 
            Regex objNotNumberPattern = new Regex("[^0-9.-]");
            Regex objTwoDotPattern = new Regex("[0-9]*[.][0-9]*[.][0-9]*"); 
            Regex objTwoMinusPattern = new Regex("[0-9]*[-][0-9]*[-][0-9]*"); 
            String strValidRealPattern = "^([-]|[.]|[-.]|[0-9])[0-9]*[.]*[0-9]+$"; 
            String strValidIntegerPattern = "^([-]|[0-9])[0-9]*$";
            Regex objNumberPattern = new Regex("(" + strValidRealPattern + ")|(" + strValidIntegerPattern + ")"); 
            return !objNotNumberPattern.IsMatch(strNumber) && !objTwoDotPattern.IsMatch(strNumber) && !objTwoMinusPattern.IsMatch(strNumber) && objNumberPattern.IsMatch(strNumber); 
        }
        private void Roominf_Load(object sender, EventArgs e)
        {
            try
            {
                comboBox1.SelectedIndex = 0;
                comboBoxsex.SelectedIndex = 0;
                string sqltext1 = "select * from userinf ";
                userdataGridView.DataSource = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, sqltext1, null).Tables[0].DefaultView;
                userdataGridView.Columns["sfzid"].HeaderText = "身份证号";
                userdataGridView.Columns["username"].HeaderText = "姓名";
                userdataGridView.Columns["sex"].HeaderText = "性别";
                userdataGridView.Columns["tel"].HeaderText = "电话";
            }
            catch (Exception)
            {
                MessageBox.Show("数据初始化错误！");
                throw;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string chaxunfangshi= "num",sqltext1;
            if (comboBox1.SelectedItem.ToString().Equals("身份证号"))
                chaxunfangshi = "sfzid";
            else if (comboBox1.SelectedItem.ToString().Equals("姓名"))
                chaxunfangshi = "username";
            else if (comboBox1.SelectedItem.ToString().Equals("电话"))
                chaxunfangshi = "tel";
            try
            {
                sqltext1 = "select * from userinf where " + chaxunfangshi + " like '%" + textBox1.Text + "%'";
                userdataGridView.DataSource = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, sqltext1, null).Tables[0].DefaultView;
            }
            catch (Exception)
            {
                
                throw;
            }

        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            try
            {
                string sfzid, username, sex, tel;
                string sqltext;
                sfzid = textBoxsfzid.Text;
                username = textBoxname.Text;
                sex = comboBoxsex.SelectedItem.ToString();
                tel = textBoxdianhua.Text;
                if ((!IsNum(sfzid)) || (!IsNum(tel)))
                {
                    MessageBox.Show("身份证号或电话号码不是数字！");
                }
                else
                {
                    sqltext = "insert into userinf(sfzid,username,sex,tel)values('" + sfzid + "','" + username + "','" + sex + "','" + tel + "')";
                    MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, CommandType.Text, sqltext, null);
                    userdataGridView.DataSource = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, "select * from userinf ", null).Tables[0].DefaultView;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("该房客已存在！");
                throw;
            }
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string sfzid, sqltext;
                sfzid = textBox18.Text;
                sqltext = "delete from userinf where sfzid='" + sfzid + "'";
                MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, CommandType.Text, sqltext, null);
                userdataGridView.DataSource = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, "select * from userinf ", null).Tables[0].DefaultView;
            }
            catch (Exception)
            {
                MessageBox.Show("要删除的房客不存在！");
                throw;
            }
            
        }
        private void buttonupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string sfzid, username, sex, tel;
                string sqltext;
                sfzid = textBox4.Text;
                username = textBox3.Text;
                sex = comboBox2.SelectedItem.ToString();
                tel = textBox2.Text;
                if ((!IsNum(sfzid)))
                {
                    MessageBox.Show("请输入正确的身份证号！");
                }
                else
                {
                    sqltext = "update userinf set username='" + username + "',sex='" + sex + "',tel='" + tel + "' where sfzid='" + sfzid + "'";
                    MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, CommandType.Text, sqltext, null);
                    userdataGridView.DataSource = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, "select * from userinf ", null).Tables[0].DefaultView;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("请输入正确的身份证号！");
              //  throw;
            }
            
        }

        private void buttonjiazai_Click(object sender, EventArgs e)
        {
            try
            {
                string sfzid = textBox4.Text;
                string sqltext;
                sqltext = "select * from userinf where sfzid='" + sfzid + "'";
                DataSet ds = new DataSet();
                ds = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, sqltext, null);
                textBox4.Text = ds.Tables[0].Rows[0][0].ToString();
                textBox3.Text = ds.Tables[0].Rows[0][1].ToString();
                comboBox2.Text = ds.Tables[0].Rows[0][2].ToString();
                textBox2.Text = ds.Tables[0].Rows[0][3].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("请输入正确的身份证号！");
                //throw;
            }
            
        }

        private void Button6_Click(object sender, EventArgs e)
        {

            string sfzid, username, sex, tel;

            string[] tel1 = new string[] { "130","131","132","133","134","135","136","137","138","139" ,
                                           "150","151","152","153","154","155","156","157","158","159",
                                            "180","181","182","183","184","185","186","187","188","189"};
            string[] name = new string[] {"赵", "钱", "孙", "李", "周", "吴", "郑", "王", "冯", "陈",
                                          "楮", "卫", "蒋", "沈", "韩", "杨", "朱", "秦", "尤", "许",
                                          "何", "吕", "施", "严", "金", "陶", "姜", "戚", "谢", "喻",
                                          "袁", "柳", "酆", "鲍", "史", "唐", "费", "廉", "岑", "薛",
                                          "雷", "贺", "倪", "汤", "滕", "殷", "罗", "毕", "郝", "邬",
                                          "安", "常", "乐", "于", "时", "傅", "皮", "卞", "齐", "康" };

            Random rad1 = new Random();
            Random rad2 = new Random();
            Random rad3 = new Random();
            Random rad4 = new Random();
            Random rad5 = new Random();
            Random rad6 = new Random();
            for (int i = 0; i < 100000; i++)
            {
                username = name[rad1.Next(0, 59)];
                username += name[rad1.Next(0, 59)];
                username += name[rad1.Next(0, 59)];

                if (rad1.Next(0, 29) % 2 == 0)
                    sex = "男";
                else
                    sex = "女";

                tel = tel1[rad1.Next(0, 29)] +(rad2.Next(0,9)).ToString()+tel1[rad3.Next(0, 29)] + (rad4.Next(0, 9)).ToString()+ tel1[rad5.Next(0, 29)];

                sfzid = (rad1.Next(100000, 999999)).ToString();
                sfzid += (rad1.Next(100000, 999999)).ToString();
                sfzid += (rad1.Next(100000, 999999)).ToString();


                string sqltext = "insert into userinf(sfzid,username,sex,tel)values('" + sfzid + "','" + username + "','" + sex + "','" + tel + "')";
                MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, CommandType.Text, sqltext, null);
                userdataGridView.DataSource = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, "select * from userinf ", null).Tables[0].DefaultView;
            }

            MessageBox.Show("插入成功！");

        }

/// /////////////////////////////////////////////////////////////////////////////////

        private void Button6_Click(object sender, EventArgs e)
        {

            string sfzid, namee, sex, tel;

            string[] tel1 = new string[] { "130","131","132","133","134","135","136","137","138","139" ,
                                           "150","151","152","153","154","155","156","157","158","159",
                                            "180","181","182","183","184","185","186","187","188","189"};
            string[] name = new string[] {"赵", "钱", "孙", "李", "周", "吴", "郑", "王", "冯", "陈",
                                          "楮", "卫", "蒋", "沈", "韩", "杨", "朱", "秦", "尤", "许",
                                          "何", "吕", "施", "严", "金", "陶", "姜", "戚", "谢", "喻",
                                          "袁", "柳", "酆", "鲍", "史", "唐", "费", "廉", "岑", "薛",
                                          "雷", "贺", "倪", "汤", "滕", "殷", "罗", "毕", "郝", "邬",
                                          "安", "常", "乐", "于", "时", "傅", "皮", "卞", "齐", "康" };

            Random rad1 = new Random();
            Random rad2 = new Random();
            Random rad3 = new Random();
            Random rad4 = new Random();
            Random rad5 = new Random();
            Random rad6 = new Random();
            for (int i = 0; i < 100000; i++)
            {
                namee = name[rad1.Next(0, 59)];
                namee += name[rad1.Next(0, 59)];
                namee += name[rad1.Next(0, 59)];

                if (rad1.Next(0, 29) % 2 == 0)
                    sex = "男";
                else
                    sex = "女";

                tel = tel1[rad1.Next(0, 29)] + (rad2.Next(0, 9)).ToString() + tel1[rad3.Next(0, 29)] + (rad4.Next(0, 9)).ToString() + tel1[rad5.Next(0, 29)];

                sfzid = (rad1.Next(100000, 999999)).ToString();
                sfzid += (rad1.Next(100000, 999999)).ToString();
                sfzid += (rad1.Next(100000, 999999)).ToString();


                string sqltext = "insert into lodger(sfzid,name,sex,tel)values('" + sfzid + "','" + namee + "','" + sex + "','" + tel + "')";
                MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, CommandType.Text, sqltext, null);
                userdataGridView.DataSource = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, "select * from lodger ", null).Tables[0].DefaultView;
            }

            MessageBox.Show("插入成功！");

        }
    }
}
