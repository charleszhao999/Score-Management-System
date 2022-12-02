using System.Data;
namespace Score_Management_System;


public partial class Login : Form
{
    public Login()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        login();
    }

    private void Login_Load(object sender, EventArgs e)
    {

    }

    private void textBox1_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            login();
        }
    }

    private void textBox2_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            login();
        }
    }
    private void login()
    {
        string username = textBox1.Text;
        string password = textBox2.Text;
        string sql = "select * from Teachers where Username='" + username + "' and Password='" + password + "'";
        DataSet ds = DBHelper.GetDataSet(sql);
        if (ds.Tables[0].Rows.Count > 0)
        {
            String name = ds.Tables[0].Rows[0]["Name"].ToString();
            name=name.Replace(" ", "");
            MessageBox.Show("登录成功，欢迎回来，" + name + " 老师。");
            this.Hide();
            int Tid = int.Parse(ds.Tables[0].Rows[0]["Tid"].ToString());
            TeacherUI teacherUI = new TeacherUI(Tid);
            teacherUI.Show();
        }
        else
        {
            sql = "select * from Students where Username='" + username + "' and Password='" + password + "'";
            ds = DBHelper.GetDataSet(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                String name = ds.Tables[0].Rows[0]["Name"].ToString();
                name = name.Replace(" ", "");
                MessageBox.Show("登录成功，欢迎回来，" + name + " 同学。");
                this.Hide();
                int Sid = int.Parse(ds.Tables[0].Rows[0]["Sid"].ToString());
                StudentUI studentUI = new StudentUI(Sid);
                studentUI.Show();
            }
            else
            {
                MessageBox.Show("用户名或密码错误");
            }
        }

    }

}