using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Score_Management_System
{
    public partial class AddStudent : Form
    {
        String gender=null;
        public AddStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public static bool IsNumber(string str)
        {
            if (str == null || str.Length == 0)    //验证这个参数是否为空
                return false;                           //是，就返回False
            ASCIIEncoding ascii = new ASCIIEncoding();//new ASCIIEncoding 的实例
            byte[] bytestr = ascii.GetBytes(str);         //把string类型的参数保存到数组里

            foreach (byte c in bytestr)                   //遍历这个数组里的内容
            {
                if (c < 48 || c > 57)                          //判断是否为数字
                {
                    return false;                              //不是，就返回False
                }
            }
            return true;                                        //是，就返回True
        }
        private void button1_Click(object sender, EventArgs e)
        {
            addStudent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                gender = "男";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                gender = "女";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addStudent();
            }
        }
        private void addStudent()
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || gender == null)
            {
                MessageBox.Show("请填写完整信息！");
            }
            else if (!IsNumber(textBox1.Text))
            {
                MessageBox.Show("学号必须为纯数字！");
            }
            else
            {

                string sql = "insert into Students values(" + textBox1.Text + ",'" + textBox2.Text + "','" + gender + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                try
                {
                    DBHelper.execute(sql);
                    MessageBox.Show("添加成功！");
                    this.Hide();
                }
                catch
                {
                    MessageBox.Show("添加失败！");
                }
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addStudent();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addStudent();
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addStudent();
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addStudent();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
