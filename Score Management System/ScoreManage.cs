using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Score_Management_System
{
    public partial class ScoreManage : Form
    {
        public ScoreManage()
        {
            InitializeComponent();
            //将数据库中的Scores表连接到dataGridView1中
            dataGridView1.DataSource = DBHelper.GetDataSet("select * from Scores").Tables[0];
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void ScoreManage_Load(object sender, EventArgs e)
        {

        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddScore addScore = new AddScore();
            addScore.ShowDialog();
            dataGridView1.DataSource = DBHelper.GetDataSet("select * from Scores").Tables[0];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentCellAddress.Y;
            if (row == -1)
            {
                MessageBox.Show("请选择要修改的行");
            }
            else
            {
                //获取所选行学生的Sid
                int Mid = Convert.ToInt32(dataGridView1.Rows[row].Cells[0].Value);
                EditScore editScore = new EditScore(Mid);
                editScore.ShowDialog();
                dataGridView1.DataSource = DBHelper.GetDataSet("select * from Scores").Tables[0];
            }
        }
    }
}
