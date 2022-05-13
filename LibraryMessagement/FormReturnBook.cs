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
    public partial class FormReturnBook : Form
    {
        User user;
        public FormReturnBook(string a, string b, int c, string d, string f, string g, string h, int i, string j, string k)
        {
            InitializeComponent();

            user = new User(a, b, c, d, f, g, h, i, j, k);            
        }

        private void 查找书籍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBorrowBook form3 = new FormBorrowBook
                (user.Account, user.Password, user.Sex, user.Telephone, user.Address, user.RegisterTime, user.Name, user.ID, user.Question, user.Answer);
            form3.Show();
            this.Close();
        }

        private void 退出登陆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLand form1 = new FormLand();
            form1.Show();
            this.Close();
        }

        private void 修改信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChangeInformation form5 = new FormChangeInformation
                (user.Account, user.Password, user.Sex, user.Telephone, user.Address, user.RegisterTime, user.Name, user.ID, user.Question, user.Answer);
            form5.Show();
            this.Close();
        }

        private void ClearAll(string sql)
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
                lvi.Text = sqldatereader["Insex"].ToString();         //第一列数据必须用Text
                lvi.SubItems.Add(sqldatereader["BookId"].ToString());//添加第二列数据
                lvi.SubItems.Add(sqldatereader["BookName"].ToString());
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

        private void FormReturnBook_Load(object sender, EventArgs e)
        {
            string sql = "select * from RecordTable where UserAccount ='" + user.Account + 
                "'and UserName='" + user.Name + "'  ";
            ClearAll(sql);

            Time t=new Time();
            DalayTimeBox.Text = t.TimeNow;
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            Book b = new Book(listView1.SelectedItems[0].SubItems[1].Text);
            MoneyBox.Text = b.Money.ToString();
            Record r = new Record(Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text));
            ReturnTimeBox.Text = r.ReturnTime;

            ReturnButton.Enabled = true;
            DalayButton.Enabled = true;
            LoseButton.Enabled = true;
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Record r = new Record(Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text));
            if (r.IfReturn == 0)
            {
                if (r.IfLose == 1)
                    listView1.SelectedItems[0].SubItems[6].Text = "";

                user.ReturnBook(listView1.SelectedItems[0].SubItems[1].Text,
                    Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text));

                MessageBox.Show("书籍《" + listView1.SelectedItems[0].SubItems[2].Text + "》归还成功！", "归还成功");
                Time t = new Time();
                listView1.SelectedItems[0].SubItems[5].Text = t.TimeNow;
            }
            else
                MessageBox.Show("书籍《" + listView1.SelectedItems[0].SubItems[2].Text + "》已经归还！", "归还失败");
        }

        private void LoseButton_Click(object sender, EventArgs e)
        {
            Record r = new Record(Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text));
            if (r.IfReturn == 0)
            {
                if (r.IfLose == 0)
                {
                    user.LoseBook(listView1.SelectedItems[0].SubItems[1].Text,
                    Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text));

                    MessageBox.Show("书籍《" + listView1.SelectedItems[0].SubItems[2].Text + "》挂失成功！\n您需要赔偿人民币"
                        + MoneyBox.Text + "元", "挂失成功");
                    listView1.SelectedItems[0].SubItems[6].Text = "挂失";
                }
                else
                    MessageBox.Show("书籍《" + listView1.SelectedItems[0].SubItems[2].Text + "》已经挂失！", "挂失失败");
            }
            else
                MessageBox.Show("书籍《" + listView1.SelectedItems[0].SubItems[2].Text + "》已经归还！", "挂失失败");
        }

        private void DalayButton_Click(object sender, EventArgs e)
        {
            Record r = new Record(Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text));
            if (r.IfReturn == 0)
            {
                if (r.IfLose == 0)
                {
                    if (user.DalayBook(r,
                            DalayTimeBox.Text,
                            Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text)))
                    {
                        MessageBox.Show("书籍《" + listView1.SelectedItems[0].SubItems[2].Text + "》成功延迟到" + r.ReturnTime + "归还", "延迟成功");
                        listView1.SelectedItems[0].SubItems[4].Text = r.BorrowLimit.ToString();
                        ReturnTimeBox.Text = r.ReturnTime;
                    }
                    else
                        MessageBox.Show("延迟的时间应大于该书籍的归还时间！", "延迟失败");
                }
                else
                    MessageBox.Show("书籍《" + listView1.SelectedItems[0].SubItems[2].Text + "》已经挂失！", "延迟失败");
            }
            else
                MessageBox.Show("书籍《" + listView1.SelectedItems[0].SubItems[2].Text + "》已经归还！", "延迟失败");
        }

        private void ReturnedButton_Click(object sender, EventArgs e)
        {
            string sql = "select * from RecordTable where UserAccount ='" + user.Account
                + "'and UserName='" + user.Name + "'and IfReturn=" + 1;
            ClearAll(sql);

            ReturnButton.Enabled = false;
            DalayButton.Enabled = false;
            LoseButton.Enabled = false;
        }

        private void LosedButton_Click(object sender, EventArgs e)
        {
            string sql = "select * from RecordTable where UserAccount ='" + user.Account
                + "'and UserName='" + user.Name + "'and IfLose=" + 1;
            ClearAll(sql);

            ReturnButton.Enabled = false;
            DalayButton.Enabled = false;
            LoseButton.Enabled = false;
        }

        private void NoReturnButton_Click(object sender, EventArgs e)
        {
            string sql = "select * from RecordTable where UserAccount ='" + user.Account
                + "'and UserName='" + user.Name + "'and IfReturn=" + 0 + " and IfLose=" + 0;
            ClearAll(sql);

            ReturnButton.Enabled = false;
            DalayButton.Enabled = false;
            LoseButton.Enabled = false;
        }

        private void AllButton_Click(object sender, EventArgs e)
        {
            string sql = "select * from RecordTable where UserAccount ='" + user.Account +
                "'and UserName='" + user.Name + "'  ";
            ClearAll(sql);

            ReturnButton.Enabled = false;
            DalayButton.Enabled = false;
            LoseButton.Enabled = false;
        }
    }
}
