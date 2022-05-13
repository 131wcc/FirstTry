using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace LibraryMessagement
{
    class Book
    {
        public string BookId = "";//书号
        public string BookName = "";//书名
        public string Author = "";//作者
        public int    NumNow = 0;//现存量
        public int    NumHave = 0;//库存量
        public int    NumBorrow = 0;//借阅量
        public int    NumLose = 0;//挂失量
        public double Money = 0;//书籍丢失赔偿金额
        public string RegisterTime = "";//书籍加入系统时间

        public Book()
        {
            BookId = "";
            BookName = "";
            Author = "";
            NumNow = 0;
            NumHave = 0;
            RegisterTime = "";
            Money = 0;
            NumBorrow = 0;
            NumLose = 0;
        }

        public Book(string bookid)
        {
            Path p = new Path();
            SqlConnection sqlconnection = new SqlConnection(p.link);
            sqlconnection.Open();
            string sql = "select * from BookTable where BookID='" + bookid + "'";
            SqlCommand sqlcommand = new SqlCommand(sql, sqlconnection);
            SqlDataReader sqldatereader = sqlcommand.ExecuteReader();

            if (sqldatereader.Read())
            {
                BookId = bookid;
                BookName = sqldatereader["BookName"].ToString();
                Author = sqldatereader["Author"].ToString();
                NumNow = (int)sqldatereader["NumNow"];
                NumHave = (int)sqldatereader["NumHave"];
                RegisterTime = sqldatereader["RegisterTime"].ToString();
                Money = (double)sqldatereader["Money"];
                NumBorrow = (int)sqldatereader["NumBorrow"];
                NumLose = (int)sqldatereader["NumLose"];
            }
            sqlconnection.Close();
        }

        public void CancelBook()
        {
            Path p = new Path();
            SqlConnection sqlconnection = new SqlConnection(p.link);
            sqlconnection.Open();
            string sql = "delete BookTable where BookID='" + BookId + "'";
            SqlCommand sqlcommand = new SqlCommand(sql, sqlconnection);
            sqlcommand.ExecuteNonQuery();
            sqlconnection.Close();
        }//删除书籍

        public void ChangeBook()
        {
            Path p = new Path();
            SqlConnection sqlconnection = new SqlConnection(p.link);
            sqlconnection.Open();
            string sql = "update BookTable set BookName=N'" + BookName + "',Author=N'" + Author + "',NumNow=" + NumNow + ",NumHave=" + NumHave
                + ",RegisterTime='" + RegisterTime + "',Money=" + Money + ",NumBorrow=" + NumBorrow + ",NumLose=" + NumLose
                + " where BookID='" + BookId + "'";
            SqlCommand sqlcommand = new SqlCommand(sql, sqlconnection);
            sqlcommand.ExecuteNonQuery();
            sqlconnection.Close();
        }//修改书籍信息

        public void AddBook()
        {
            Path p = new Path();
            SqlConnection sqlconnection = new SqlConnection(p.link);
            sqlconnection.Open();
            string sql = "select * from BookTable where BookID='" + BookId + "'";        
            SqlCommand sqlcommand = new SqlCommand(sql, sqlconnection);
            SqlDataReader sqldatereader = sqlcommand.ExecuteReader();
            if(sqldatereader.HasRows)
                sql = "update BookTable set NumNow=" + NumNow + ",NumHave=" + NumHave
                    + ",NumBorrow=" + NumBorrow + ",NumLose=" + NumLose + " where BookID='" + BookId + "'";   
            else
                sql = "insert into BookTable (BookName,BookID,Author,NumNow,NumHave,RegisterTime,Money,NumBorrow,NumLose) values ("
                    + "N'" + BookName + "','" + BookId + "',N'" + Author + "'," + NumNow + "," + NumHave + ",'" + RegisterTime
                    + "'," + Money + "," + NumBorrow + "," + NumLose + ")";
            sqldatereader.Close();
            sqlcommand = new SqlCommand(sql, sqlconnection);
            sqlcommand.ExecuteReader();
            sqlconnection.Close();
        }
    }
}
