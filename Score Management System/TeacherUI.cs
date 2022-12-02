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
    public partial class TeacherUI : Form
    {
        int Tid;
        public TeacherUI(int Tid)
        {
            InitializeComponent();
            this.Tid = Tid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InfoManage infoManage = new InfoManage(Tid);
            infoManage.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ScoreManage scoreManage = new ScoreManage();
            scoreManage.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ScoreStat scoreStat = new ScoreStat();
            scoreStat.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要退出吗？", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }
    }
}
