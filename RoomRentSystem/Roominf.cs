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
    public partial class Roominf : Form
    {
        
        public Roominf()
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
                comboBox3.SelectedIndex = 0;
                comboBox4.SelectedIndex = 0;

                string sqltext1 = "select * from roominf ";
                roomdataGridView.DataSource = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, sqltext1, null).Tables[0].DefaultView;


                roomdataGridView.Columns["num"].HeaderText = "客房号";
                roomdataGridView.Columns["kind"].HeaderText = "客房类型";
                roomdataGridView.Columns["price"].HeaderText = "价格";
                roomdataGridView.Columns["status"].HeaderText = "状态";
                roomdataGridView.Columns["beizhu"].HeaderText = "备注";
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string chaxunfangshi = "num", sqltext1; ;
                if (comboBox1.SelectedItem.ToString().Equals("客房号"))
                    chaxunfangshi = "num";
                else if (comboBox1.SelectedItem.ToString().Equals("客房类型"))
                    chaxunfangshi = "kind";
                else if (comboBox1.SelectedItem.ToString().Equals("客房状态"))
                    chaxunfangshi = "status";
                sqltext1 = "select * from roominf where " + chaxunfangshi + " like '%" + textBox1.Text + "%'";
                roomdataGridView.DataSource = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, sqltext1, null).Tables[0].DefaultView;
    
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
                string num,  kind, price, status, beizhu,ps="1";
                string sqltext;
                num = textBox2.Text;
                kind = comboBox3.SelectedItem.ToString();
                price = textBox8.Text;
                status = comboBox4.SelectedItem.ToString();
                beizhu = textBox9.Text;
                if ( (!IsNum(price)))
                {
                    MessageBox.Show("客房单价不是数字");
                }
                else
                {
                    sqltext = "insert into roominf(num,kind,price,status,beizhu)values('" + num +  "','" + kind + "','" + price + "','" + status + "','" + beizhu + "')";
                    MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, CommandType.Text, sqltext, null);
                    roomdataGridView.DataSource = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, "select * from roominf ", null).Tables[0].DefaultView;
                }


         
            }
            catch (Exception)
            {
                MessageBox.Show("此房间已录入系统");
                // throw;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string num, sqltext;
                num = textBox18.Text;
                sqltext = "delete from roominf where num='" + num + "'";
                MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, CommandType.Text, sqltext, null);
                roomdataGridView.DataSource = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, "select * from roominf ", null).Tables[0].DefaultView;
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }
    }
}
