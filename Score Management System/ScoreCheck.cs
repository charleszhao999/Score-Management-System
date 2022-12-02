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
    public partial class ScoreCheck : Form
    {
        int Sid;
        public ScoreCheck(int Sid)
        {
            InitializeComponent();
            this.Sid = Sid;
            dataGridView1.DataSource = DBHelper.GetDataSet("select Subject,Score from Scores where Sid=" + Sid).Tables[0];
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ScoreCheck_Load(object sender, EventArgs e)
        {

        }
    }
}
