using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMessagement
{
    class Record
    {
        public string BookName;//书名
        public string BookId;//书号
        public string UserName;//用户姓名
        public string UserAccount;//用户账号
        public string BorrowTime;//借书时间
        public int    BorrowLimit;//借书期限
        public string ReturnTime;//归还时间
        public int    BorrowNum;//借书数量
        public int    IfReturn;//是否归还
        public int    IfLose;//是否挂失


        public Record()
        {
            BookName = "";
            BookId = "";
            UserName = "";
            UserAccount = "";
            BorrowTime = "0000/00/00";
            BorrowLimit = 0;
            ReturnTime = "0000/00/00";
            BorrowNum = 1;
            IfReturn = 0;
            IfLose = 0;
        }

        public Record(int insex)
        {
            Path p = new Path();
            SqlConnection sqlconnection = new SqlConnection(p.link);
            sqlconnection.Open();
            string sql = "select * from RecordTable where Insex=" + insex ;
            SqlCommand sqlcommand = new SqlCommand(sql, sqlconnection);
            SqlDataReader sqldatereader = sqlcommand.ExecuteReader();

            if (sqldatereader.Read())
            {
                BookId = sqldatereader["BookId"].ToString(); ;
                BookName = sqldatereader["BookName"].ToString();
                UserName = sqldatereader["UserName"].ToString();
                UserAccount = sqldatereader["UserAccount"].ToString();
                BorrowTime = sqldatereader["BorrowTime"].ToString();
                BorrowLimit = (int)sqldatereader["BorrowLimt"];
                ReturnTime = sqldatereader["ReturnTime"].ToString();
                IfReturn = (int)sqldatereader["IfReturn"];
                IfLose = (int)sqldatereader["IfLose"];
            }
            sqlconnection.Close();
        }


    }

    

}
