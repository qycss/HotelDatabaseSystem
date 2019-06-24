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
    public partial class Rentinf : Form
    {
        public Rentinf()
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
        private void Rentinf_Load(object sender, EventArgs e)
        {
            try
            {
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                string sqltext2 = "select sfzid from userinf ";
                string sqltext1 = "select num from roominf ";
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                ds = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, sqltext1, null);
                dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        comboBox1.Items.Add(dt.Rows[i][0].ToString());
                    }
                }
                ds = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, sqltext2, null);
                dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        comboBox2.Items.Add(dt.Rows[i][0].ToString());
                    }
                }

                comboBox1.SelectedIndex = 0;
                comboBox2.SelectedIndex = 0;
                rentdataGridView.DataSource = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, "select * from roomrent ", null).Tables[0].DefaultView;
                rentdataGridView.Columns["roomnum"].HeaderText = "客房编号";
                rentdataGridView.Columns["username"].HeaderText = "住户";
                rentdataGridView.Columns["sfznum"].HeaderText = "身份证号";
                rentdataGridView.Columns["starttime"].HeaderText = "入住日期";
                /////////////////////
         
            }
            catch (Exception)
            {
                MessageBox.Show("客房数据初始化错误！");
                //throw;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            {
                string roomnum, sfznum, username, date, sqltext,sqltext1;
                DataSet ds = new DataSet();
                roomnum = comboBox1.SelectedItem.ToString();
                sfznum = comboBox2.SelectedItem.ToString();
                date = dateTimePicker1.Text;
                username = textBox1.Text;

                sqltext = "select username from userinf where sfzid='" + sfznum + "'";
                ds = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, sqltext, null);
                if (ds.Tables[0].Rows.Count < 1)
                {
                    MessageBox.Show("请先填写房客信息");
                }
                else
                {
                    string trueusername = ds.Tables[0].Rows[0]["username"].ToString();
                    if (trueusername.CompareTo(username) == 0)
                    {

                        sqltext = "select starttime from roomrent where roomnum='" + roomnum + "'";
                        ds = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, sqltext, null);
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            string starttime = ds.Tables[0].Rows[0]["starttime"].ToString();
                            if (starttime.CompareTo(date) == 0)
                            {
                                MessageBox.Show("此房间已入住，请更换房间！");
                            }
                            else
                            {
                                sqltext = "insert into roomrent values('" + roomnum + "','" + username + "','" + sfznum + "','" + date + "')";
                                MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, CommandType.Text, sqltext, null);
                                rentdataGridView.DataSource = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, "select * from roomrent ", null).Tables[0].DefaultView;


                                sqltext1 = "update roominf set status='" + "已住" + "' where num='" + roomnum + "'";
                                MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, CommandType.Text, sqltext1, null);

                            }
                        }
                        else
                        {
                            sqltext = "insert into roomrent values('" + roomnum + "','" + username + "','" + sfznum + "','" + date + "')";
                            MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, CommandType.Text, sqltext, null);
                            rentdataGridView.DataSource = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, "select * from roomrent ", null).Tables[0].DefaultView;

                            sqltext1 = "update roominf set status='" + "已住" + "' where num='" + roomnum + "'";
                            MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, CommandType.Text, sqltext1, null);
                        }
                    }
                    else
                    {
                        MessageBox.Show("身份证与姓名信息不匹配，请重新输入！");
                    }
                }
            }
            /*catch (Exception)
            {
                MessageBox.Show("此房间已入住，请更换房间！");
        //      throw;
            }*/
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string roomnum, sfznum, sqltext,sqltext1;
                roomnum = comboBox1.SelectedItem.ToString();
                sfznum = comboBox2.SelectedItem.ToString();
                sqltext = "delete from roomrent where roomnum='" + roomnum + "' and sfznum='" + sfznum + "'";
                MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, CommandType.Text, sqltext, null);
                rentdataGridView.DataSource = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, "select * from roomrent ", null).Tables[0].DefaultView;

                sqltext1 = "update roominf set status='" + "未住" + "' where num='" + roomnum + "'";
                MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, CommandType.Text, sqltext1, null);
            }
            catch (Exception)
            {
                MessageBox.Show("欲退客房不存在，请检查！");
            //    throw;
            }
        }
    }
}
