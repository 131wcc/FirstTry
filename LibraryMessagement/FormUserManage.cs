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
    public partial class FormUserManage : Form
    {
        User user;
        public FormUserManage(string a, string b, int c, string d, string f, string g, string h, int i, string j, string k)
        {
            InitializeComponent();

            user = new User(a, b, c, d, f, g, h, i, j, k);            
        }

        private void ClearAll(string sql)
        {
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

        private void FormUserManage_Load(object sender, EventArgs e)
        {
            string sql = "select * from useTable where ID=0";
            ClearAll(sql);

            if (user.ID == 2)
                AdminManageButton.Visible = true;
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

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormRecordManage f = new FormRecordManage
                (user.Account, user.Password, user.Sex, user.Telephone, user.Address, user.RegisterTime, user.Name, user.ID, user.Question, user.Answer);
            f.Show();
            this.Close();
        }

        private void 管理员管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAdminManage f=new FormAdminManage(user.Account, user.Password, user.Sex, 
                user.Telephone, user.Address, user.RegisterTime, user.Name, user.ID, user.Question, user.Answer);
            f.Show();
            this.Close();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            User u = new User(listView1.SelectedItems[0].SubItems[2].Text);

            NameBox.Text = u.Name;
            if (u.Sex == 0)
                BoyButton.Checked = true;
            else
                GirlButton.Checked = true;
            phoneBox.Text = u.Telephone;
            AddressBox.Text = u.Address;
        }

        private void Changebutton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                User u = new User(listView1.SelectedItems[0].SubItems[2].Text);

                u.Name = NameBox.Text;
                if (BoyButton.Checked == true)
                    u.Sex = 0;
                else
                    u.Sex = 1;
                u.Telephone = phoneBox.Text;
                u.Address = AddressBox.Text;

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
                MessageBox.Show("请先选择账号！", "修改失败");
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                User u = new User(listView1.SelectedItems[0].SubItems[2].Text);
                user.CancelAccount(u);
                listView1.Items.Remove(listView1.SelectedItems[0]);
                NameBox.Text = "";
                BoyButton.Checked = false;
                GirlButton.Checked = false;
                phoneBox.Text = "";
                AddressBox.Text = "";
                MessageBox.Show("账号<" + u.Account + ">注销成功！", "注销成功");
            }
            else
                MessageBox.Show("请先选择账号！", "注销失败");
            
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            Path p = new Path();
            SqlConnection sqlconnection = new SqlConnection(p.link);
            sqlconnection.Open();
            string sql = "select * from useTable where ID=0 and Account ='" + AccountBox.Text + "' or Name='" + NBox.Text + "'";
            SqlCommand sqlcommand = new SqlCommand(sql, sqlconnection);
            SqlDataReader sqldatereader = sqlcommand.ExecuteReader();

            if(sqldatereader.Read())
            {
                listView1.Items.Clear();
                int i = 0;
                do
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
                } while (sqldatereader.Read());
                sqlconnection.Close();
            }
            else
            {
                MessageBox.Show("找不到该账号！", "查找失败");
                sqlconnection.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            string sql = "select * from useTable where ID=0";
            ClearAll(sql);

            AccountBox.Text = "";
            NBox.Text = "";
        }

        

        

        
    }
}
