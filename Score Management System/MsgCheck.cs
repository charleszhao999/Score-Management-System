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
    public partial class MsgCheck : Form
    {
        int Sid;
        public MsgCheck(int Sid)
        {
            InitializeComponent();
            this.Sid = Sid;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;

        }

        private void MsgCheck_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DBHelper.GetDataSet("select Teachers.Name,Msgs.Message from Msgs  join Teachers on Msgs.Tid=Teachers.Tid where Msgs.Sid="+Sid).Tables[0];

        }
    }
}
