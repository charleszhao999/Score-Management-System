using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Score_Management_System
{
    public partial class AddScore : Form
    {
        public AddScore()
        {
            InitializeComponent();
        }
        private void addScore()
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("请输入完整信息！");
            }
            else if (AddStudent.IsNumber(textBox1.Text) && AddStudent.IsNumber(textBox3.Text) && Convert.ToInt32(textBox3.Text) <= 100 && Convert.ToInt32(textBox3.Text) >= 0)
            {
                //向Scores表中新增数据
                String sql = "insert into Scores values(" + textBox1.Text + ",'" + textBox2.Text + "'," + textBox3.Text + ")";

                try
                {
                    DBHelper.execute(sql);
                    MessageBox.Show("添加成功！");
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("添加失败！" + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("请输入正确的学号和成绩！");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            addScore();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addScore();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addScore();
            }
        }
    }
}
