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
    public partial class EditScore : Form
    {
        int Mid;
        public EditScore(int Mid)
        {
            InitializeComponent();
            this.Mid = Mid;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void editScore()
        {
            if (textBox1.Text != "" && !AddStudent.IsNumber(textBox1.Text))
            {
                MessageBox.Show("请输入正确的学号和成绩！");
            }
            else if (textBox3.Text != "" && !AddStudent.IsNumber(textBox3.Text))
            {
                MessageBox.Show("请输入正确的学号和成绩！");
            }
            else if (AddStudent.IsNumber(textBox3.Text) && Convert.ToInt32(textBox3.Text) > 100)
            {
                MessageBox.Show("请输入正确的学号和成绩！");
            }
            else if (AddStudent.IsNumber(textBox3.Text) && Convert.ToInt32(textBox3.Text) < 0)
            {
                MessageBox.Show("请输入正确的学号和成绩！");
            }
            else if(textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
            {
                MessageBox.Show("内容未修改。");
                this.Hide();
            }
            else
            {
                String sql = "update Scores set ";
                if (textBox1.Text != "")
                {
                    sql += "Sno=" + textBox1.Text;
                }
                if (textBox2.Text != "")
                {
                    if (textBox1.Text != "")
                    {
                        sql += ",";
                    }
                    sql += "Cname='" + textBox2.Text + "'";
                }
                if (textBox3.Text != "")
                {
                    if (textBox1.Text != "" || textBox2.Text != "")
                    {
                        sql += ",";
                    }
                    sql += "Score=" + textBox3.Text;
                }
                sql += " where Mid=" + Mid ;
                try
                {
                    DBHelper.execute(sql);
                    MessageBox.Show("修改成功！");
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("修改失败！" + ex.ToString());
                    this.Hide();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            editScore();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                editScore();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                editScore();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                editScore();
            }
        }
    }
}
