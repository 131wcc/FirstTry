using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMessagement
{
    public partial class FormRecordManage : Form
    {
        User user;
        public FormRecordManage(string a, string b, int c, string d, string f, string g, string h, int i, string j, string k)
        {
            InitializeComponent();

            user = new User(a, b, c, d, f, g, h, i, j, k);
        }

        private void 退出登入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLand form1 = new FormLand();
            form1.Show();
            this.Close();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FormChangeInformation form5 = new FormChangeInformation
                (user.Account, user.Password, user.Sex, user.Telephone, user.Address, user.RegisterTime, user.Name, user.ID, user.Question, user.Answer);
            form5.Show();
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormBookManage f = new FormBookManage
                (user.Account, user.Password, user.Sex, user.Telephone, user.Address, user.RegisterTime, user.Name, user.ID, user.Question, user.Answer);
            f.Show();
            this.Close();
        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUserManage f = new FormUserManage
                (user.Account, user.Password, user.Sex, user.Telephone, user.Address, user.RegisterTime, user.Name, user.ID, user.Question, user.Answer);
            f.Show();
            this.Close();
        }

        private void 管理员管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAdminManage f = new FormAdminManage(user.Account, user.Password, user.Sex,
                user.Telephone, user.Address, user.RegisterTime, user.Name, user.ID, user.Question, user.Answer);
            f.Show();
            this.Close();
        }


        private void ShowAll(string sql)
        {
            listView1.Items.Clear();

            Path p = new Path();
            SqlConnection sqlconnection = new SqlConnection(p.link);
            sqlconnection.Open();
            
            SqlCommand sqlcommand = new SqlCommand(sql, sqlconnection);
            SqlDataReader sqldatereader = sqlcommand.ExecuteReader();

            while (sqldatereader.Read())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = sqldatereader["Insex"].ToString();     //第一列数据必须用Text
                lvi.SubItems.Add(sqldatereader["BookId"].ToString());
                lvi.SubItems.Add(sqldatereader["BookName"].ToString());//添加第二列数据
                lvi.SubItems.Add(sqldatereader["UserName"].ToString());
                lvi.SubItems.Add(sqldatereader["UserAccount"].ToString());
                lvi.SubItems.Add(sqldatereader["BorrowTime"].ToString());
                lvi.SubItems.Add(sqldatereader["BorrowLimt"].ToString());

                if ((int)sqldatereader["IfReturn"]==0)
                    lvi.SubItems.Add("未归还");
                else
                    lvi.SubItems.Add(sqldatereader["ReturnTime"].ToString());

                if ((int)sqldatereader["IfLose"] == 0)
                    lvi.SubItems.Add("");
                else
                    lvi.SubItems.Add("挂失");

                listView1.Items.Add(lvi);
            }
        }

        private void FormRecordManage_Load(object sender, EventArgs e)
        {
            string sql = "select * from RecordTable";
            ShowAll(sql);

            if (user.ID == 2)
                AdminManageButton.Visible = true;
        }

        private void ReturnB_Click(object sender, EventArgs e)
        {
            string sql = "select * from RecordTable where IfReturn=1";
            ShowAll(sql);
        }

        private void NoReturnB_Click(object sender, EventArgs e)
        {
            string sql = "select * from RecordTable where IfReturn=0";
            ShowAll(sql);
        }

        private void LoseB_Click(object sender, EventArgs e)
        {
            string sql = "select * from RecordTable where IfLose = 1";
            ShowAll(sql);
        }

        private void NoLoseB_Click(object sender, EventArgs e)
        {
            string sql = "select * from RecordTable where IfLose = 0";
            ShowAll(sql);
        }

        private void AllB_Click(object sender, EventArgs e)
        {
            string sql = "select * from RecordTable";
            ShowAll(sql);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            BookIdBox.Text = "";
            BookNameBox.Text = "";
            UserNameBox.Text = "";
            UserAccountBox.Text="";
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            if (BookIdBox.Text != "" || BookNameBox.Text != "" || UserNameBox.Text != "" || UserAccountBox.Text != "")
            {
                string sql = "select * from RecordTable where BookId='" + BookIdBox.Text + "' or BookName='" + BookNameBox.Text +
                "' or UserName='" + UserNameBox.Text + "' or UserAccount='" + UserAccountBox.Text + "'";
                ShowAll(sql);
            }
            else
                MessageBox.Show("请输入需要查找的书籍信息！", "查找失败");
        }

        private void OverdueButton_Click(object sender, EventArgs e)
        {
            Time t = new Time();
            DateTime start = Convert.ToDateTime(t.TimeNow);
            

            

            


            listView1.Items.Clear();

            Path p = new Path();
            SqlConnection sqlconnection = new SqlConnection(p.link);
            sqlconnection.Open();
            string sql = "select * from RecordTable where IfReturn = 1";
            SqlCommand sqlcommand = new SqlCommand(sql, sqlconnection);
            SqlDataReader sqldatereader = sqlcommand.ExecuteReader();

            while (sqldatereader.Read())
            {
                DateTime end = Convert.ToDateTime(sqldatereader["ReturnTime"].ToString());
                TimeSpan sp = end.Subtract(start);
                if(sp.Days>0)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = sqldatereader["Insex"].ToString();     //第一列数据必须用Text
                    lvi.SubItems.Add(sqldatereader["BookId"].ToString());
                    lvi.SubItems.Add(sqldatereader["BookName"].ToString());//添加第二列数据
                    lvi.SubItems.Add(sqldatereader["UserName"].ToString());
                    lvi.SubItems.Add(sqldatereader["UserAccount"].ToString());
                    lvi.SubItems.Add(sqldatereader["BorrowTime"].ToString());
                    lvi.SubItems.Add(sqldatereader["BorrowLimt"].ToString());

                    if ((int)sqldatereader["IfReturn"] == 0)
                        lvi.SubItems.Add("未归还");
                    else
                        lvi.SubItems.Add(sqldatereader["ReturnTime"].ToString());

                    if ((int)sqldatereader["IfLose"] == 0)
                        lvi.SubItems.Add("");
                    else
                        lvi.SubItems.Add("挂失");

                    listView1.Items.Add(lvi);
                }

            }
        }

        

        
    }
}
