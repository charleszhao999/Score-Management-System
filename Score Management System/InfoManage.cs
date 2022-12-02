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
    public partial class InfoManage : Form
    {
        int Tid;
        public InfoManage(int Tid)
        {
            InitializeComponent();
            this.Tid = Tid;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.ReadOnly = true;
            dataGridView2.AllowUserToAddRows = false;
        }


        private void InfoManage_Load(object sender, EventArgs e)
        {
            //将数据库与dataGridView连接
            dataGridView2.DataSource = DBHelper.GetDataSet("select * from Students").Tables[0];

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.ShowDialog();
            dataGridView2.DataSource = DBHelper.GetDataSet("select * from Students").Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int row = dataGridView2.CurrentCellAddress.Y;
            if (row == -1)
            {
                MessageBox.Show("请选择要删除的行");
            }
            else
            {
                if (MessageBox.Show("确定要删除吗？", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    //获取所选行学生的Sid
                    int Sid = Convert.ToInt32(dataGridView2.Rows[row].Cells[0].Value);
                    try
                    {
                        DBHelper.execute("delete from Students where Sid=" + Sid);
                        MessageBox.Show("删除成功！");
                        dataGridView2.DataSource = DBHelper.GetDataSet("select * from Students").Tables[0];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("删除失败！" + ex.Message);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int row = dataGridView2.CurrentCellAddress.Y;
            if (row == -1)
            {
                MessageBox.Show("请选择要删除的行");
            }
            else
            {
                //获取所选行学生的Sid
                int Sid = Convert.ToInt32(dataGridView2.Rows[row].Cells[0].Value);
                Message message = new Message(Tid, Sid);
                message.ShowDialog();
            }
        }
    }
}
