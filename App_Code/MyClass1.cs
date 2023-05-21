using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.OleDb;
using System.Data;  

namespace Work_0520
{
    public class MyClass1
    {
        //获取连接字符串
        static string ConnStr = ConfigurationManager.ConnectionStrings["ConnString"].ToString();
        //创建连接对象
        static OleDbConnection conn = new OleDbConnection(ConnStr);
        //创建返回一个DataTable的GetDT()方法,声明为静态方法,可在调用时不必进行实例化
        public static DataTable GetDT(string sql)
        {
            conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
            DataTable dt = new DataTable();         //创建DataTable对象
            da.Fill(dt);                            //填充DataTable对象
            conn.Close();
            return dt;
        }

        //创建一个用于判断班级名是否已存在的ClassIsExist()静态方法
        public static bool ClassIsExist(string classname)
        {
            conn.Open();
            string sql = "select * from syllabus where class ='" + classname + "'";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.ExecuteNonQuery();                  //执行sql语句,清除上次执行录取操作的结果
            OleDbDataReader dr = cmd.ExecuteReader();   //调用ExecuteReader()方法得到dr对象
            dr.Read();                                  //调用Read()方法得到返回记录集
            if (dr.HasRows)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }

        //创建一个将修改后的课程表更新到数据库的Updata()静态方法
        public static string Updata(string[] row)
        {
            string SqlStr = "select * from syllabus where class = '" + row[0] + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(SqlStr, conn);
            DataTable dt = new DataTable();
            OleDbCommandBuilder builder = new OleDbCommandBuilder(da);
            da.Fill(dt);
            DataRow MyRow = dt.Rows[0];     //从数据表中提取第一行(第一条记录)
            for(int i=0; i<16; i++)
            {
                MyRow[i] = row[i];
            }
            string msg;
            try
            {
                da.Update(dt);
                msg = "数据更新成功!";
            }
            catch(Exception e)
            {
                msg = e.Message;
            }
            finally
            {
                conn.Close();
            }
            return msg;
        }

        //创建一个用于向数据库插入新纪录的Insert()静态方法
        public static string Insert(string[] newrow)
        {
            string SqlStr = "select * from syllabus";
            OleDbDataAdapter da = new OleDbDataAdapter(SqlStr, conn);
            DataTable dt = new DataTable();
            OleDbCommandBuilder builder = new OleDbCommandBuilder(da);
            da.Fill(dt);
            DataRow MyRow = dt.NewRow();
            for(int i=0; i<16; i++)
            {
                MyRow[i] = newrow[i];
            }
            string msg;
            try
            {
                dt.Rows.Add(MyRow);
                da.Update(dt);
                msg = "数据添加成功!";
            }
            catch(Exception e)
            {
                msg = e.Message;
            }
            finally
            {
                conn.Close();
            }
            return msg;
        }
    }
}