using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RoomRentSystem
{
    public partial class MainForm : Form
    {
        static string usernamestr;
        public MainForm()
        {
            usernamestr = "admin";
            InitializeComponent();
        }

        public MainForm(string user)
        {
            usernamestr = user;
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = usernamestr + "  欢迎您！" ;

            if (usernamestr.Equals("admin"))
                toolStripButton3.Visible = false;
                
            else
                toolStripButton2.Visible = false;
           
               
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Roominf roominf = new Roominf();
            roominf.TopLevel = false;
            roominf.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            roominf.WindowState = FormWindowState.Normal;
            roominf.Dock = DockStyle.Fill;
            roominf.KeyPreview = true;
            roominf.Parent = splitContainer1.Panel2;
            roominf.Show();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Userinf userinf = new Userinf();
            userinf.TopLevel = false;
            userinf.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            userinf.WindowState = FormWindowState.Normal;
            userinf.Dock = DockStyle.Fill;
            userinf.KeyPreview = true;
            userinf.Parent = splitContainer1.Panel2;
            userinf.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Currentuserpwdedit cupe = new Currentuserpwdedit(usernamestr);
            cupe.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Managerinf minf = new Managerinf();
            minf.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Rentinf rentinf = new Rentinf();
            rentinf.TopLevel = false;
            rentinf.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            rentinf.WindowState = FormWindowState.Normal;
            rentinf.Dock = DockStyle.Fill;
            rentinf.KeyPreview = true;
            rentinf.Parent = splitContainer1.Panel2;
            rentinf.Show();
        }


        private void Button4_Click_1(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm(usernamestr);
            this.Hide();
            mainform.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
/*
        private void Button6_Click(object sender, EventArgs e)
        {

            string sfzid, username, sex, tel;

            string[] tel1 = new string[] { "130","131","132","133","134","135","136","137","138","139" ,
                                           "150","151","152","153","154","155","156","157","158","159",
                                            "180","181","182","183","184","185","186","187","188","189"};
            string[] name = new string[] {"赵", "钱", "孙", "李", "周", "吴", "郑", "王", "冯", "陈",
                                          "楮", "卫", "蒋", "沈", "韩", "杨", "朱", "秦", "尤", "许",
                                          "何", "吕", "施", "严", "金", "陶", "姜", "戚", "谢", "喻" };

            string[] id = new string[] { "163790", "180374", "121356", "812759", "925188", "467129", "954007", "180670", "254176", "854190",
                                         "345130", "385187", "189156", "896179", "188968", "347199", "896180", "178276", "097190", "906621",
                                         "137820", "137787", "156691", "160179", "134598", "179167", "112850", "156516", "191560", "312546" };
            Random rad1 = new Random();//实例化随机数产生器rad；
            Random rad2 = new Random();
            Random rad3 = new Random();
            for (int i = 0; i < 10; i++)
            {
                sfzid = (111111111111111112 + i).ToString();

                username = name[rad1.Next(0, 29)] + name[rad2.Next(0, 29)] + name[rad3.Next(0, 29)];
                if (rad1.Next(0, 29) % 2 == 0)
                    sex = "男";
                else
                    sex = "女";
                tel = tel[rad1.Next(0, 29)] + tel[rad2.Next(0, 29)] + tel[rad3.Next(0, 29)];


                string sqltext = "insert into userinf(sfzid,username,sex,tel)values('" + sfzid + "','" + username + "','" + sex + "','" + tel + "')";
                MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, CommandType.Text, sqltext, null);
            }

            MessageBox.Show("插入成功！");

        }*/
    }
}
