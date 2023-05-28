using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// MyClass 的摘要说明
/// </summary>
public class MyClass1
{
    static string ConnStr = ConfigurationManager.ConnectionStrings["ConnString"].ToString();
    static SqlConnection conn = new SqlConnection(ConnStr);

    public static DataTable GetDT(string sql)//返回一个DataTable
    {
       // conn.Open();
        SqlDataAdapter da = new SqlDataAdapter(sql, conn);    //按用户选择的学号返回记录集
        DataTable dt = new DataTable();     //创建DataTable对象
        da.Fill(dt);        //填充DataTable对象
        conn.Close();
        return dt;
    }

    public static bool ClassIsExist(string classname)//判断班级名否已存在
    {
        conn.Open();
        string sql = "select * from syllabus where class =N'" + classname + "'";
        SqlCommand cmd = new SqlCommand(sql, conn);
        cmd.ExecuteNonQuery();//执行sql语句,清除上次执行录取操作的结果
        SqlDataReader dr = cmd.ExecuteReader();	//调用ExecuteReader()方法得到dr对象
        dr.Read();		//调用Read()方法得到返回记录集           
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

    public static string Updata(string[] row)//将修改后的课程表更新到数据库
    {
        string SqlStr = "select * from syllabus where class=N'" + row[0] + "'";
        SqlDataAdapter da = new SqlDataAdapter(SqlStr, conn);
        DataTable dt = new DataTable();
        SqlCommandBuilder builder = new SqlCommandBuilder(da);
        da.Fill(dt);
        DataRow MyRow = dt.Rows[0];	//从数据表中提取第1行（第一条记录）
        for (int i = 0; i < 16; i++)
        {
            MyRow[i] = row[i];
        }
        string msg;
        try
        {
            da.Update(dt);
            
            msg = "数据更新成功！";
        }
        catch (Exception ex)
        {
            msg = ex.Message;
        }
        finally
        {
            conn.Close();
        }
        return msg;
    }



    public static string Insert(string[] newrow)
    {
        string SqlStr = "select * from syllabus";
        SqlDataAdapter da = new SqlDataAdapter(SqlStr, conn);
        DataTable dt = new DataTable();
        SqlCommandBuilder builder = new SqlCommandBuilder(da);
        da.Fill(dt);
        DataRow MyRow = dt.NewRow();	//从数据表中提取第1行（第一条记录）
        for (int i = 0; i < 16; i++)
        {
            MyRow[i] = newrow[i];
        }
        string msg;
        try
        {
            dt.Rows.Add(MyRow);
            da.Update(dt);
            msg = "数据添加成功！";
        }
        catch (Exception ex)
        {
            msg = ex.Message;
        }
        finally
        {
            conn.Close();
        }
        return msg;
    }
}