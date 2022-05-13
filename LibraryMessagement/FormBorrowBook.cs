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
    public partial class FormBorrowBook : Form
    {
        User user;

        public FormBorrowBook(string a, string b, int c, string d, string f, string g, string h, int i, string j, string k)
        {
            InitializeComponent();

            user=new User(a,b,c,d,f,g,h,i,j,k);
        }

        private void FormBorrowBook_Load(object sender, EventArgs e)
        {
            Path p = new Path();
            SqlConnection sqlconnection = new SqlConnection(p.link);
            sqlconnection.Open();
            string sql = "select BookName,BookID,Author from BookTable";
            SqlCommand sqlcommand = new SqlCommand(sql, sqlconnection);
            SqlDataReader sqldatereader = sqlcommand.ExecuteReader();

            while (sqldatereader.Read())
            {
                BookNameBox.Items.Add(sqldatereader["BookName"].ToString());
                BookIDBox.Items.Add(sqldatereader["BookID"].ToString());
                AuthorBox.Items.Add(sqldatereader["Author"].ToString());
            }
            sqlconnection.Close();
        }

        bool sym = true;
        private void BookIDBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(sym)
            {
                sym = false;

                IList<string> BookNamelist = new List<string>();
                IList<string> Authorlist = new List<string>();

                Path p = new Path();
                SqlConnection sqlconnection = new SqlConnection(p.link);
                sqlconnection.Open();
                string sql = "select BookName,Author from BookTable where BookID='" + BookIDBox.Text + "'";
                SqlCommand sqlcommand = new SqlCommand(sql, sqlconnection);
                SqlDataReader sqldatereader = sqlcommand.ExecuteReader();

                while (sqldatereader.Read())
                {
                    BookNamelist.Add(sqldatereader["BookName"].ToString());
                    Authorlist.Add(sqldatereader["Author"].ToString());
                }
                sqlconnection.Close();

                BookNameBox.DataSource = BookNamelist;
                AuthorBox.DataSource = Authorlist;

                TimeLimitBox.Enabled = false;
                TimeLimitBox.Text = "";

                sym = true;
            }
        }

        private void BookNameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sym)
            {
                sym = false;

                IList<string> BookIDlist = new List<string>();
                IList<string> Authorlist = new List<string>();

                Path p = new Path();
                SqlConnection sqlconnection = new SqlConnection(p.link);
                sqlconnection.Open();
                string sql = "select BookID,Author from BookTable where BookName=N'" + BookNameBox.Text + "'";
                SqlCommand sqlcommand = new SqlCommand(sql, sqlconnection);
                SqlDataReader sqldatereader = sqlcommand.ExecuteReader();

                while (sqldatereader.Read())
                {
                    BookIDlist.Add(sqldatereader["BookID"].ToString());
                    Authorlist.Add(sqldatereader["Author"].ToString());
                }
                sqlconnection.Close();

                BookIDBox.DataSource = BookIDlist;
                AuthorBox.DataSource = Authorlist;

                TimeLimitBox.Enabled = false;
                TimeLimitBox.Text = "";

                sym = true;
            }
        }

        private void AuthorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sym)
            {
                sym = false;

                IList<string> BookIDlist = new List<string>();
                IList<string> BookNamelist = new List<string>();

                Path p = new Path();
                SqlConnection sqlconnection = new SqlConnection(p.link);
                sqlconnection.Open();
                string sql = "select BookID,BookName from BookTable where Author=N'" + AuthorBox.Text + "'";
                SqlCommand sqlcommand = new SqlCommand(sql, sqlconnection);
                SqlDataReader sqldatereader = sqlcommand.ExecuteReader();

                while (sqldatereader.Read())
                {
                    BookIDlist.Add(sqldatereader["BookID"].ToString());
                    BookNamelist.Add(sqldatereader["BookName"].ToString());
                }
                sqlconnection.Close();

                BookIDBox.DataSource = BookIDlist;
                BookNameBox.DataSource = BookNamelist;

                TimeLimitBox.Enabled = false;
                TimeLimitBox.Text = "";

                sym = true;
            }
        }


        private void FindBookButton_Click(object sender, EventArgs e)
        {
            if(BookIDBox.Text!="" && BookNameBox.Text!="" && AuthorBox.Text!="")
            {
                Book book = new Book(BookIDBox.Text);
                TimeLimitBox.Enabled = true;
                NumNowBox.Text = book.NumNow.ToString();
            }
            else
                MessageBox.Show("请先选择书籍！", "查找失败", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void BorrowBookButton_Click(object sender, EventArgs e)
        {
            if(BookIDBox.Text!="" && BookNameBox.Text!="" && AuthorBox.Text!="" )
            {
                if(TimeLimitBox.Text!="")
                {
                    if (NumNowBox.Text != "0")
                    {
                        Book book = new Book(BookIDBox.Text);
                        string TReturn = user.BorrowBook(book, TimeLimitBox.Text);
                        NumNowBox.Text = book.NumNow.ToString();
                        MessageBox.Show("书籍《" + book.BookName + "》借阅成功！\n书籍需在" + TReturn + "之前归还！", "借阅成功");
                    }
                    else
                        MessageBox.Show("该书籍暂无库存！", "借阅失败");
                }
                else
                    MessageBox.Show("请输入借阅期限！", "借阅失败");
            }
            else
                MessageBox.Show("请先选择书籍！", "借阅失败");
        }

        private void 修改信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChangeInformation form5 = new FormChangeInformation
                (user.Account, user.Password, user.Sex, user.Telephone, user.Address, user.RegisterTime, user.Name, user.ID, user.Question, user.Answer);
            form5.Show();
            this.Close();
        }

        private void 退出登陆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLand form1 = new FormLand();
            form1.Show();
            this.Close();
        }

        private void 借阅记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReturnBook form6 = new FormReturnBook
                (user.Account, user.Password, user.Sex, user.Telephone, user.Address, user.RegisterTime, user.Name, user.ID, user.Question, user.Answer);
            form6.Show();
            this.Close();
        }

        private void CancalButton_Click(object sender, EventArgs e)
        {
            sym = false;

            

            IList<string> BookIDlist = new List<string>();
            IList<string> Authorlist = new List<string>();
            IList<string> BookNamelist = new List<string>();

            Path p = new Path();
            SqlConnection sqlconnection = new SqlConnection(p.link);
            sqlconnection.Open();
            string sql = "select BookName,BookID,Author from BookTable";
            SqlCommand sqlcommand = new SqlCommand(sql, sqlconnection);
            SqlDataReader sqldatereader = sqlcommand.ExecuteReader();

            while (sqldatereader.Read())
            {
                BookNamelist.Add(sqldatereader["BookName"].ToString());
                BookIDlist.Add(sqldatereader["BookID"].ToString());
                Authorlist.Add(sqldatereader["Author"].ToString());
            }
            BookIDBox.DataSource = BookIDlist;
            BookNameBox.DataSource = BookNamelist;
            AuthorBox.DataSource = Authorlist;

            sqlconnection.Close();

            BookIDBox.Text = "";
            BookNameBox.Text = "";
            AuthorBox.Text = "";
            NumNowBox.Text = "";
            TimeLimitBox.Text = "";
            TimeLimitBox.Enabled = false;

            sym = true;
        } 

    }
}
