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
    public partial class Message : Form
    {
        int Sid, Tid;

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("请输入评价内容！");
            }
            else
            {
                //向Msgs插入新行
                try
                {
                    DBHelper.execute("insert into Msgs values(" + Sid + "," + Tid + ",'" + richTextBox1.Text + "')");
                    MessageBox.Show("评价成功！");
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("评价失败！"+ex.ToString());
                }
            }
        }

        public Message(int Tid, int Sid)
        {
            InitializeComponent();
            this.Tid = Tid;
            this.Sid = Sid;
        }
    }
}
