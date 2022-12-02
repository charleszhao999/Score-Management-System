using System;
using System.Collections;
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
    public partial class ScoreStat : Form
    {
        public ScoreStat()
        {
            InitializeComponent();
            String sql = "select Students.Name,Students.Sid,Scores.Subject,Scores.Score from Scores join Students on Scores.Sid=Students.Sid";
            //dataGridView1.DataSource = DBHelper.GetDataSet(sql).Tables[0];
            sql= "select DISTINCT Sid from Scores";
            //将sql查询结果存入数组中
            int[] sid = DBHelper.GetDataSet(sql).Tables[0].AsEnumerable().Select(r => r.Field<int>("Sid")).ToArray();
            int[] score = new int[sid.Length];
            //为dataGridView1添加三列数据
            dataGridView1.Columns.Add("Name", "姓名");
            dataGridView1.Columns.Add("Sid", "学号");
            dataGridView1.Columns.Add("Score", "总分");
            dataGridView1.Columns.Add("Rank", "排名");
            for (int i = 0; i < sid.Length; i++)
            {
                sql = "select Score from Scores where Sid='" + sid[i] + "'";
                score[i] = DBHelper.GetDataSet(sql).Tables[0].AsEnumerable().Select(r => r.Field<int>("Score")).Sum();
            }
            //往rank数组中存储score数组的大小名次
            int[] rank = scoreRank(score);
            for (int i = 0; i < sid.Length; i++)
            {
                sql = "select Name from Students where Sid='" + sid[i] + "'";
                String name = DBHelper.GetDataSet(sql).Tables[0].AsEnumerable().Select(r => r.Field<String>("Name")).First();
                dataGridView1.Rows.Add(name, sid[i], score[i], rank[i]);
            }
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
        }
        public static int[] scoreRank(int[] score)
        {
            int[] temp = new int[score.Length];
            ArrayList lis = new ArrayList();
            for (int i=0;i< score.Length;i++)   // 添加元素（不重复）
                if (!lis.Contains(score[i])) lis.Add(score[i]);
            lis.Sort();    // 从小到大排序
            lis.Reverse();  // 从大到小排序
            for (int i = 0; i < score.Length; i++) // 下标从 0 开始
                temp[i] = lis.IndexOf(score[i]) + 1;
            // 所以：正常名次 = 取得下标 + 1 
            return temp;
        }
        private void ScoreStat_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
