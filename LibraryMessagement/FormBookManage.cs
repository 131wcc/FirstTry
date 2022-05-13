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
    public partial class FormBookManage : Form
    {
        User user;
        public FormBookManage(string a, string b, int c, string d, string f, string g, string h, int i, string j, string k)
        {
            InitializeComponent();

            user = new User(a, b, c, d, f, g, h, i, j, k);
        }

        private void ClearAll()
        {
            BookIdBox1.Text = "";
            BookNameBox1.Text = "";
            AuthorBox1.Text = "";
            TimeBox.Text = "";
            NumHaveBox.Text = "";
            NumNowBox.Text = "";
            NumBorrowBox.Text = "";
            NumLoseBox.Text = "";
            MoneyBox1.Text = "";

            BookIdBox2.Text = "";
            BookNameBox2.Text = "";
            AuthorBox2.Text = "";

            BookIdBox3.Text = "";
            BookNameBox3.Text = "";
            AuthorBox3.Text = "";
            MoneyBox3.Text = "";
            AddNumBox.Text = "";
            MoneyBox3.Text = "";
            BookIdBox3.Enabled = true;
            BookNameBox3.Enabled = true;
            AuthorBox3.Enabled = true;
            AddNumBox.Enabled = true;
            MoneyBox3.Enabled = true;
        }

        private void ShowAll()
        {
            listView1.Items.Clear();

            Path p = new Path();
            SqlConnection sqlconnection = new SqlConnection(p.link);
            sqlconnection.Open();
            string sql = "select * from BookTable";
            SqlCommand sqlcommand = new SqlCommand(sql, sqlconnection);
            SqlDataReader sqldatereader = sqlcommand.ExecuteReader();

            int i = 0;
            while (sqldatereader.Read())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = i.ToString();         //第一列数据必须用Text
                lvi.SubItems.Add(sqldatereader["BookID"].ToString());
                lvi.SubItems.Add(sqldatereader["BookName"].ToString());//添加第二列数据
                lvi.SubItems.Add(sqldatereader["Author"].ToString());
                lvi.SubItems.Add(sqldatereader["NumNow"].ToString());
                lvi.SubItems.Add(sqldatereader["NumHave"].ToString());
                lvi.SubItems.Add(sqldatereader["NumBorrow"].ToString());
                lvi.SubItems.Add(sqldatereader["NumLose"].ToString());
                lvi.SubItems.Add(sqldatereader["Money"].ToString());
                lvi.SubItems.Add(sqldatereader["RegisterTime"].ToString());

                listView1.Items.Add(lvi);
                i++;
            }
        }

        private void FormBookManage_Load(object sender, EventArgs e)
        {
            ShowAll();

            if (user.ID == 2)
            {
                AdminManageButton.Visible = true;
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            Book b = new Book(listView1.SelectedItems[0].SubItems[1].Text);
            BookIdBox1.Text = b.BookId;
            BookNameBox1.Text = b.BookName;
            AuthorBox1.Text = b.Author;
            TimeBox.Text = b.RegisterTime;
            NumHaveBox.Text = b.NumHave.ToString();
            NumNowBox.Text = b.NumNow.ToString();
            NumBorrowBox.Text = b.NumBorrow.ToString();
            NumLoseBox.Text = b.NumLose.ToString();
            MoneyBox1.Text = b.Money.ToString();

            BookIdBox3.Text = b.BookId;
            BookNameBox3.Text = b.BookName;
            AuthorBox3.Text = b.Author;
            MoneyBox3.Text = b.Money.ToString();
            AddNumBox.Text = "";

            BookIdBox3.Enabled = false;
            BookNameBox3.Enabled = false;
            AuthorBox3.Enabled = false;
            MoneyBox3.Enabled = false;


        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                Book b = new Book(listView1.SelectedItems[0].SubItems[1].Text);
                b.CancelBook();
                listView1.Items.Remove(listView1.SelectedItems[0]);

                ClearAll();

                MessageBox.Show("书籍《" + b.BookName + "》删除成功！", "删除成功");
            }
            else
                MessageBox.Show("请先选择书籍！", "删除失败");
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if ( BookNameBox1.Text != "" && AuthorBox1.Text!=""&& NumNowBox.Text != ""
                && NumHaveBox.Text != "" && MoneyBox1.Text != "" && NumBorrowBox.Text!=""&&
                NumLoseBox.Text!="")
            {
                Book b = new Book();
                b.BookId = BookIdBox1.Text;
                b.BookName = BookNameBox1.Text;
                b.Author = AuthorBox1.Text;
                b.NumNow = Convert.ToInt32(NumNowBox.Text);
                b.NumHave = Convert.ToInt32(NumHaveBox.Text);
                b.RegisterTime = TimeBox.Text;
                b.Money = Convert.ToInt32(MoneyBox1.Text);
                b.NumBorrow = Convert.ToInt32(NumBorrowBox.Text);
                b.NumLose = Convert.ToInt32(NumLoseBox.Text);

                b.ChangeBook();

                listView1.SelectedItems[0].SubItems[1].Text = b.BookId;
                listView1.SelectedItems[0].SubItems[2].Text = b.BookName;
                listView1.SelectedItems[0].SubItems[3].Text = b.Author;
                listView1.SelectedItems[0].SubItems[4].Text = b.NumHave.ToString();
                listView1.SelectedItems[0].SubItems[5].Text = b.NumNow.ToString();
                listView1.SelectedItems[0].SubItems[6].Text = b.NumBorrow.ToString();
                listView1.SelectedItems[0].SubItems[7].Text = b.NumLose.ToString();
                listView1.SelectedItems[0].SubItems[8].Text = b.Money.ToString();
                listView1.SelectedItems[0].SubItems[9].Text = b.RegisterTime;

                ClearAll();
                MessageBox.Show("书籍《" + b.BookName + "》修改成功！", "修改成功");
            }
            else
            {
                MessageBox.Show("请填写完整资料！", "修改失败");
            }
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            Path p = new Path();
            SqlConnection sqlconnection = new SqlConnection(p.link);
            sqlconnection.Open();
            string sql = "select * from BookTable where BookName ='" + BookNameBox2.Text + "' or BookID='" + BookIdBox2.Text
                + "' or Author='" + AuthorBox2.Text + "'";
            SqlCommand sqlcommand = new SqlCommand(sql, sqlconnection);
            SqlDataReader sqldatereader = sqlcommand.ExecuteReader();

            if (sqldatereader.Read() )
            {
                listView1.Items.Clear();
                int i = 0;
                do
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = i.ToString();         //第一列数据必须用Text
                    lvi.SubItems.Add(sqldatereader["BookID"].ToString());
                    lvi.SubItems.Add(sqldatereader["BookName"].ToString());//添加第二列数据
                    lvi.SubItems.Add(sqldatereader["Author"].ToString());
                    lvi.SubItems.Add(sqldatereader["NumNow"].ToString());
                    lvi.SubItems.Add(sqldatereader["NumHave"].ToString());
                    lvi.SubItems.Add(sqldatereader["NumBorrow"].ToString());
                    lvi.SubItems.Add(sqldatereader["NumLose"].ToString());
                    lvi.SubItems.Add(sqldatereader["Money"].ToString());
                    lvi.SubItems.Add(sqldatereader["RegisterTime"].ToString());

                    listView1.Items.Add(lvi);
                    i++;
                } while (sqldatereader.Read());
                sqlconnection.Close();
            }
            else
            {
                MessageBox.Show("找不到该书籍！", "查找失败");
                sqlconnection.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ShowAll();

            BookNameBox2.Text = "";
            BookIdBox2.Text = "";
            AuthorBox2.Text = "";
        }

        private void BookIdBox3_Click(object sender, EventArgs e)
        {
            BookIdBox3.Text = "";
            IList<string> BookIDlist = new List<string>();

            Path p = new Path();
            SqlConnection sqlconnection = new SqlConnection(p.link);
            sqlconnection.Open();
            string sql = "select BookID from BookTable where BookName='" + BookNameBox3.Text
                + "' or Author='" + AuthorBox3.Text + "'";
            SqlCommand sqlcommand = new SqlCommand(sql, sqlconnection);
            SqlDataReader sqldatereader = sqlcommand.ExecuteReader();

            while (sqldatereader.Read())
            {
                BookIDlist.Add(sqldatereader["BookID"].ToString());
            }
            sqlconnection.Close();

            BookIdBox3.DataSource = BookIDlist;
        }

        private void BookNameBox3_Click(object sender, EventArgs e)
        {
            BookNameBox3.Text = "";
            IList<string> BookNamelist = new List<string>();

            Path p = new Path();
            SqlConnection sqlconnection = new SqlConnection(p.link);
            sqlconnection.Open();
            string sql = "select BookName from BookTable where BookID='" + BookIdBox3.Text + "'";
            SqlCommand sqlcommand = new SqlCommand(sql, sqlconnection);
            SqlDataReader sqldatereader = sqlcommand.ExecuteReader();

            while (sqldatereader.Read())
            {
                BookNamelist.Add(sqldatereader["BookName"].ToString());
            }
            sqlconnection.Close();

            BookNameBox3.DataSource = BookNamelist;
        }

        private void AuthorBox3_Click(object sender, EventArgs e)
        {
            AuthorBox3.Text = "";
            IList<string> Authorlist = new List<string>();

            Path p = new Path();
            SqlConnection sqlconnection = new SqlConnection(p.link);
            sqlconnection.Open();
            string sql = "select Author from BookTable where BookID='" + BookIdBox3.Text + "'";
            SqlCommand sqlcommand = new SqlCommand(sql, sqlconnection);
            SqlDataReader sqldatereader = sqlcommand.ExecuteReader();

            while (sqldatereader.Read())
            {
                Authorlist.Add(sqldatereader["Author"].ToString());
            }
            sqlconnection.Close();

            AuthorBox3.DataSource = Authorlist;
        }

        private void MoneyBox3_Click(object sender, EventArgs e)
        {
            if(BookIdBox3.Text!="")
            {
                MoneyBox3.Text = "";

                Path p = new Path();
                SqlConnection sqlconnection = new SqlConnection(p.link);
                sqlconnection.Open();
                string sql = "select Money from BookTable where BookID='" + BookIdBox3.Text + "'";
                SqlCommand sqlcommand = new SqlCommand(sql, sqlconnection);
                SqlDataReader sqldatereader = sqlcommand.ExecuteReader();

                if (sqldatereader.Read())
                {
                    MoneyBox3.Text = sqldatereader["Money"].ToString();
                }
                sqlconnection.Close();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            BookIdBox3.Text = "";
            BookNameBox3.Text = "";
            AuthorBox3.Text = "";
            MoneyBox3.Text = "";
            AddNumBox.Text = "";
            BookIdBox3.Enabled = true;
            BookNameBox3.Enabled = true;
            AuthorBox3.Enabled = true;
            MoneyBox3.Enabled = true;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (BookNameBox3.Text != "" && BookIdBox3.Text != "" && AuthorBox3.Text != "" && MoneyBox3.Text != "" && AddNumBox.Text != "")
            {
                if (Convert.ToInt32(AddNumBox.Text) > 0)
                {
                    Book b = new Book(BookIdBox3.Text);
                    Time t = new Time();

                    b.BookId = BookIdBox3.Text;
                    b.BookName = BookNameBox3.Text;
                    b.Author = AuthorBox3.Text;
                    b.Money = Convert.ToInt32(MoneyBox3.Text);
                    b.RegisterTime = t.TimeNow;
                    b.NumHave += Convert.ToInt32(AddNumBox.Text);
                    b.NumNow += Convert.ToInt32(AddNumBox.Text);

                    b.AddBook();
                    MessageBox.Show("书籍《" + b.BookName + "》添加成功！", "添加成功");

                    ClearAll();
                    ShowAll();
                }
                else
                    MessageBox.Show("书籍增加量应该大于0！", "添加失败");

            }
            else
                MessageBox.Show("请输入完整的书籍信息！", "增加失败");
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

    }
}
