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
    public partial class FormAdminManage : Form
    {
        User user;
        public FormAdminManage(string a, string b, int c, string d, string f, string g, string h, int i, string j, string k)
        {
            InitializeComponent();

            user = new User(a, b, c, d, f, g, h, i, j, k);
        }

        private void ShowAll(string sql)
        {
            boy.Checked = true;
            listView1.Items.Clear();

            Path p = new Path();
            SqlConnection sqlconnection = new SqlConnection(p.link);
            sqlconnection.Open();

            SqlCommand sqlcommand = new SqlCommand(sql, sqlconnection);
            SqlDataReader sqldatereader = sqlcommand.ExecuteReader();

            int i = 0;
            while (sqldatereader.Read())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = i.ToString();         //第一列数据必须用Text
                lvi.SubItems.Add(sqldatereader["Name"].ToString());//添加第二列数据
                lvi.SubItems.Add(sqldatereader["Account"].ToString());
                if ((int)sqldatereader["Sex"] == 0)
                    lvi.SubItems.Add("男");
                else
                    lvi.SubItems.Add("女");
                lvi.SubItems.Add(sqldatereader["Telephone"].ToString());
                lvi.SubItems.Add(sqldatereader["Address"].ToString());
                lvi.SubItems.Add(sqldatereader["RegisterTime"].ToString());

                listView1.Items.Add(lvi);
                i++;
            }
        }

        private void ClearAll()
        {
            accountText.Text = "";
            phoneText.Text = "";
            passwordText.Text = "";
            questionText.Text = "";
            answerText.Text = "";
            nameText.Text = "";
            boy.Checked = true;
            girl.Checked = false;
            addressText.Text = "";

            accountText.Enabled = true;
            ChangeButton.Enabled = false;
        }

        private void FormAdminManage_Load(object sender, EventArgs e)
        {
            string sql = "select * from useTable where ID = 1";
            ShowAll(sql);
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            User u = new User(listView1.SelectedItems[0].SubItems[2].Text);
            accountText.Text = u.Account;
            phoneText.Text = u.Telephone;
            passwordText.Text = u.Password;
            questionText.Text = u.Question;
            answerText.Text = u.Answer;
            nameText.Text = u.Name;
            if (u.Sex == 0)
                boy.Checked = true;
            else
                girl.Checked = true;

            accountText.Enabled = false;
            boy.Checked = true;
            ChangeButton.Enabled = true;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0 && accountText.Text!="")
            {
                User u = new User(accountText.Text);
                user.CancelAccount(u);
                listView1.Items.Remove(listView1.SelectedItems[0]);
                ClearAll();
                MessageBox.Show("账号<" + u.Account + ">注销成功！", "注销成功");
            }
            else
                MessageBox.Show("请先选择账号！", "注销失败");
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0 && accountText.Text!="")
            {
                if (phoneText.Text != "" && passwordText.Text != "" && questionText.Text != "" &&
                    answerText.Text != "" && nameText.Text != "")
                {
                    User u = new User(accountText.Text);
                    u.Telephone = phoneText.Text;
                    u.Name = nameText.Text;
                    u.Password = passwordText.Text;
                    u.Question = questionText.Text;
                    u.Answer = answerText.Text;
                    if (boy.Checked == true)
                        u.Sex = 0;
                    else
                        u.Sex = 1;
                    u.Address = addressText.Text;

                    user.ChangeInformantion(u);

                    listView1.SelectedItems[0].SubItems[1].Text = u.Name;
                    if (u.Sex == 0)
                        listView1.SelectedItems[0].SubItems[3].Text = "男";
                    else
                        listView1.SelectedItems[0].SubItems[3].Text = "女";
                    listView1.SelectedItems[0].SubItems[4].Text = u.Telephone;
                    listView1.SelectedItems[0].SubItems[5].Text = u.Address;

                    MessageBox.Show("账号<" + u.Account + ">信息修改成功！", "修改成功");
                }
                else
                    MessageBox.Show("请将信息补充完整！", "修改失败");
            }
            else
                MessageBox.Show("请先选择账号！", "修改失败");
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (phoneText.Text != "" && passwordText.Text != "" && questionText.Text != "" &&
                    answerText.Text != "" && nameText.Text != "" && accountText.Text != "")
            {
                User u1 = new User(accountText.Text);
                if (u1.Name != null)
                {
                    MessageBox.Show("账号已被注册成用户！", "添加失败");
                    return;
                }
                else
                {
                    int sex;
                    if (boy.Checked == true)
                        sex = 0;
                    else
                        sex = 1;

                    Time t = new Time();

                    User u = new User(accountText.Text, passwordText.Text, sex, phoneText.Text,
                        addressText.Text, t.TimeNow, nameText.Text, 1, questionText.Text,
                        answerText.Text);
                    u.RegisterUser();

                    ClearAll();
                    ShowAll("select * from useTable where ID = 1");
                    MessageBox.Show("管理员<" + u.Name + ">添加成功！", "添加成功");
                }
                
            }
            else
                MessageBox.Show("请将信息填写完整！", "添加失败");

        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUserManage f = new FormUserManage
                (user.Account, user.Password, user.Sex, user.Telephone, user.Address, user.RegisterTime, user.Name, user.ID, user.Question, user.Answer);
            f.Show();
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormBookManage f = new FormBookManage
                (user.Account, user.Password, user.Sex, user.Telephone, user.Address, user.RegisterTime, user.Name, user.ID, user.Question, user.Answer);
            f.Show();
            this.Close();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormRecordManage f = new FormRecordManage
                (user.Account, user.Password, user.Sex, user.Telephone, user.Address, user.RegisterTime, user.Name, user.ID, user.Question, user.Answer);
            f.Show();
            this.Close();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FormChangeInformation form5 = new FormChangeInformation
                (user.Account, user.Password, user.Sex, user.Telephone, user.Address, user.RegisterTime, user.Name, user.ID, user.Question, user.Answer);
            form5.Show();
            this.Close();
        }

        private void 退出登入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLand form1 = new FormLand();
            form1.Show();
            this.Close();
        }
    }
}
