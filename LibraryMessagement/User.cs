using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace LibraryMessagement
{
    class User
    {
        public string Account; //账号
        public string Password;//密码
        public int    Sex;//性别
        public string Telephone;//联系电话
        public string Address;//地址
        public string RegisterTime;//注册时间
        public string Name;//姓名
        public int    ID;//身份  0为普通用户，1为管理员，2为总管理员
        public string Question;//密保
        public string Answer;//答案


        private bool IndatebaseUser(string sql)
        {
            Path p = new Path();
            SqlConnection sqlconnection = new SqlConnection(p.link);
            sqlconnection.Open();
            SqlCommand sqlcommand = new SqlCommand(sql, sqlconnection);
            SqlDataReader sqldatereader = sqlcommand.ExecuteReader();
            if (sqldatereader.HasRows)//登录成功
            {
                if (sqldatereader.Read())
                {
                    Account = sqldatereader["Account"].ToString(); ;
                    Name = sqldatereader["Name"].ToString();
                    Sex = (int)sqldatereader["Sex"];
                    Telephone = sqldatereader["Telephone"].ToString();
                    Address = sqldatereader["Address"].ToString();
                    RegisterTime = sqldatereader["RegisterTime"].ToString();
                    Password = sqldatereader["Password"].ToString();
                    Question = sqldatereader["Question"].ToString();
                    Answer = sqldatereader["Answer"].ToString();
                    ID = (int)sqldatereader["ID"];
                }
                sqlconnection.Close();
                return true;
            }
            else
            {
                sqlconnection.Close();
                return false;
            }
        }


        public User()
        {
            Account = ""; 
            Password = "";
            Sex = 0;
            Telephone = "";
            Address = "";
            RegisterTime = "";
            Name = "";
            ID = 0;
            Question = "";
            Answer = "";
        }//默认构造函数

        public User(string a, string b, int c, string d, string f, 
            string g, string h, int i, string j, string k)
        {
            Account = a;
            Password = b;
            Sex = c;
            Telephone = d;
            Address = f;
            RegisterTime = g;
            Name = h;
            ID = i;
            Question = j;
            Answer = k;
        }//带参构造函数   
        
        public User(string account)
        {
            string sql = "select * from useTable where Account='" + account + "'";
            IndatebaseUser(sql);
        }//带参构造函数2
        
        public bool Land(string account, string password)
        {
            string sql = "select * from useTable where Account ='" + account + "'and Password='" + password + "'  ";
            return IndatebaseUser(sql);
                
        }//用户登入

        public bool FindPassword()
        {
            string sql = "select * from useTable where Account ='" + Account + "'and Telephone='" + Telephone + "'  ";
            return IndatebaseUser(sql);
        }//找回密码

        public void RegisterUser()
        {
            Path p = new Path();
            Time t = new Time();
            RegisterTime = t.TimeNow;

            SqlConnection sqlconnection = new SqlConnection(p.link);
            sqlconnection.Open();

            string sql = "insert into useTable (Account,Password,Name,Sex,Telephone,Address,RegisterTime,ID,Question,Answer) values (N'"
                + Account + "',N'" + Password + "',N'" + Name + "'," + Sex + ",'" + Telephone + "',N'" + Address + "','" + RegisterTime + "',"
                + ID + ",N'" + Question + "',N'" + Answer + "')";
            SqlCommand sqlcommand = new SqlCommand(sql, sqlconnection);
            sqlcommand.ExecuteNonQuery();
            sqlconnection.Close();
        }//注册

        public string BorrowBook(Book book, string limit)
        {
            Path p = new Path();

            SqlConnection sqlconnection = new SqlConnection(p.link);
            sqlconnection.Open();
            string sql = "select count(*) from RecordTable";
            SqlCommand sqlcommand = new SqlCommand(sql, sqlconnection);
            int i =(int) Convert.ToInt64(sqlcommand.ExecuteScalar());//记录表的索引

            Time tBorrow = new Time();
            Time tReturn = new Time((int)Convert.ToInt64(limit));//相关时间

            sql = "insert into RecordTable (Insex,BookId,BookName,UserName,UserAccount,BorrowTime,BorrowLimt,ReturnTime,IfLose,IfReturn) values (" + (i + 1) + ",'"
                + book.BookId + "',N'" + book.BookName + "',N'" + Name + "'," + Account + ",'" + tBorrow.TimeNow + "'," + limit + ",'" + tReturn.TimeNow + "'," + 0 + "," + 0 + ")";
            sqlcommand = new SqlCommand(sql, sqlconnection);
            sqlcommand.ExecuteNonQuery();//插入数据至记录表
            
            book.NumNow--;
            book.NumBorrow++;
            sql = "update BookTable set NumNow=" + book.NumNow + ",NumBorrow=" + book.NumBorrow + " where BookID ='" + book.BookId + "'  ";
            sqlcommand = new SqlCommand(sql, sqlconnection);
            sqlcommand.ExecuteNonQuery();//更新书籍表

            sqlconnection.Close();

            return tReturn.TimeNow;//返回到期时间
        }//借阅书籍

        public void ChangeInformantion(User u)
        {
            Path p = new Path();
            SqlConnection sqlconnection = new SqlConnection(p.link);
            sqlconnection.Open();
            string sql = "update useTable set Password='" + u.Password + "',Name=N'" + u.Name + "',Sex=" + u.Sex + ",Telephone='" + u.Telephone
                + "',Address=N'" + u.Address + "',Question=N'" + u.Question + "',Answer=N'" + u.Answer + "' where Account='" + u.Account + "'";
            SqlCommand sqlcommand = new SqlCommand(sql, sqlconnection);
            sqlcommand.ExecuteNonQuery();
            sqlconnection.Close();
        }//修改信息

        public void CancelAccount(User u)
        {
            Path p = new Path();
            SqlConnection sqlconnection = new SqlConnection(p.link);
            sqlconnection.Open();
            string sql = "delete useTable where Account='" + u.Account + "'";
            SqlCommand sqlcommand = new SqlCommand(sql, sqlconnection);
            sqlcommand.ExecuteNonQuery();
            sqlconnection.Close();
        }//注销账号

        public void ReturnBook(string bookid, int recordInsex)
        {
            Book book = new Book(bookid);
            Record r = new Record(recordInsex);

            book.NumNow++;            
            r.IfReturn = 1;
            if(r.IfLose==1)
            {
                book.NumLose--;
                r.IfLose = 0;
            }               
            else
                book.NumBorrow--;

            Path p = new Path();
            SqlConnection sqlconnection = new SqlConnection(p.link);
            sqlconnection.Open();
            string sql = "update BookTable set NumNow=" + book.NumNow + ",NumBorrow=" + book.NumBorrow + ",NumLose=" + book.NumLose + " where BookID='" + book.BookId + "'";
            SqlCommand sqlcommand = new SqlCommand(sql, sqlconnection);
            sqlcommand.ExecuteNonQuery();

            Time t = new Time();
            sql = "update RecordTable set IfReturn=" + r.IfReturn + ",IfLose=" + r.IfLose + ",ReturnTime='" + t.TimeNow + "' where Insex=" + recordInsex;
            sqlcommand = new SqlCommand(sql, sqlconnection);
            sqlcommand.ExecuteNonQuery();

            sqlconnection.Close();

        }//还书

        public void LoseBook(string bookid, int recordInsex)
        {
            Book book = new Book(bookid);
            Record r = new Record(recordInsex);

            book.NumHave--;
            book.NumLose++;
            r.IfLose = 1;

            Path p = new Path();
            SqlConnection sqlconnection = new SqlConnection(p.link);
            sqlconnection.Open();
            string sql = "update BookTable set NumHave=" + book.NumHave + ",NumLose=" + book.NumLose + " where BookID='" + book.BookId + "'";
            SqlCommand sqlcommand = new SqlCommand(sql, sqlconnection);
            sqlcommand.ExecuteNonQuery();

            Time t = new Time();
            sql = "update RecordTable set IfLose=" + r.IfLose  + " where Insex=" + recordInsex;
            sqlcommand = new SqlCommand(sql, sqlconnection);
            sqlcommand.ExecuteNonQuery();

            sqlconnection.Close();
        }//书籍挂失

        public bool DalayBook(Record r, string dalayTime,int insex)
        {            
            DateTime start = Convert.ToDateTime(r.ReturnTime);
            DateTime end = Convert.ToDateTime(dalayTime);

            TimeSpan sp = end.Subtract(start);

            if (sp.Days > 0)
            {
                r.BorrowLimit += sp.Days;
                r.ReturnTime = dalayTime;

                Path p = new Path();
                SqlConnection sqlconnection = new SqlConnection(p.link);
                sqlconnection.Open();
                string sql = "update RecordTable set BorrowLimt=" + r.BorrowLimit + ",ReturnTime='" + r.ReturnTime + "' where Insex=" + insex ;
                SqlCommand sqlcommand = new SqlCommand(sql, sqlconnection);
                sqlcommand.ExecuteNonQuery();
                return true;
            }
            else
                return false;
            
        }//延迟归还书籍


    }
}
