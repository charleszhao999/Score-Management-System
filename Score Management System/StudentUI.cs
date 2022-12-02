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
    public partial class StudentUI : Form
    {
        int Sid;
        public StudentUI(int Sid)
        {
            InitializeComponent();
            this.Sid = Sid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ScoreCheck scoreCheck = new ScoreCheck(Sid);
            scoreCheck.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MsgCheck msgCheck = new MsgCheck(Sid);
            msgCheck.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要退出吗？", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }

        private void StudentUI_Load(object sender, EventArgs e)
        {

        }
    }
}
