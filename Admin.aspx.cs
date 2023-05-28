using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Work_0520
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        //声明静态字符串型数组,存放下拉列表框中的选项
        static string[] DropText = new string[16];
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Title = "课程表管理";
            txtPwd.Focus();
            if (!IsPostBack)
            {
                Panel2.Visible = false;     //隐藏密码输入文本框
            }
        }

        //确定按钮点击事件
        protected void btnOK_Click(object sender, EventArgs e)
        {
            if(txtPwd.Text != "123456")     //此处设置的密码用户不能更改
            {
                ClientScript.RegisterStartupScript(GetType(), "Waring", "<script>alter('密码错误!')</script>");
                return;
            }
            Panel2.Visible = true;
            Panel1.Visible = false;
            DropDownList[] drop = new DropDownList[16];     //创建控件数组
            drop[1] = DropDownList1; drop[2] = DropDownList2; drop[3] = DropDownList3;
            drop[4] = DropDownList4; drop[5] = DropDownList5; drop[6] = DropDownList6;
            drop[7] = DropDownList7; drop[8] = DropDownList8; drop[9] = DropDownList9;
            drop[10] = DropDownList10; drop[11] = DropDownList11; drop[12] = DropDownList12;
            drop[13] = DropDownList13; drop[14] = DropDownList14; drop[15] = DropDownList15;
            string sql = "select * from course";
            //调用GetDT()方法获取包含所有供选课程名称的DataTable对象
            DataTable dt = MyClass1.GetDT(sql);
            for(int i=1; i<16; i++)     //将dt对象绑定到15个下拉列表框
            {
                drop[i].DataSource = dt;
                drop[i].DataTextField = "curriculumname";   //设置下拉列表框的绑定字段
                drop[i].DataBind();     //填充下拉列表框中的选项内容(绑定)
            }
            dt = null;
        }

        //提交按钮点击事件
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtClass.Text == "")
            {
                ClientScript.RegisterStartupScript(GetType(), "Warning", "<script>alter('班级名称不能为空!')</script>");
                return;
            }
            //调用ClassIsExist()方法检查班级名是否已存在
            if (MyClass.ClassIsExist(txtClass.Text.Trim())) //如果指定班级已存在,则执行更新操作
            {
                string[] row = new string[16];      //用于存放班级名和15个课程名
                row[0] = txtClass.Text.Trim();
                for(int i=1; i<16; i++)
                {
                    if(DropText[i] == "无")
                    {
                        row[i] = "";
                    }
                    else
                    {
                        row[i] = DropText[i];
                    }
                }
                string msg = MyClass1.Updata(row);   //调用Updata()方法将数组中的数据更新到数据库
                ClientScript.RegisterStartupScript(GetType(), "Infomation", "<script>alter('" + msg + "')</script>");
            }
            else       //班级名称不存在时执行插入记录操作
            {
                string[] newrow = new string[16];
                newrow[0] = txtClass.Text;
                for(int i=1; i<16; i++)
                {
                    if(DropText[i] == "无")
                    {
                        newrow[i] = "";
                    }
                    else
                    {
                        newrow[i] = DropText[i];
                    }
                }
                //调用Insert()方法将数据插入到数据库
                string msg = MyClass1.Insert(newrow);
                ClientScript.RegisterStartupScript(GetType(), "Infomation", "<script>alter('" + msg + "')</script>");
            }
        }

        //下拉列表框控件组共享事件
        protected void DropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList[] drop = new DropDownList[16];
            drop[1] = DropDownList1; drop[2] = DropDownList2; drop[3] = DropDownList3;
            drop[4] = DropDownList4; drop[5] = DropDownList5; drop[6] = DropDownList6;
            drop[7] = DropDownList7; drop[8] = DropDownList8; drop[9] = DropDownList9;
            drop[10] = DropDownList10; drop[11] = DropDownList11; drop[12] = DropDownList12;
            drop[13] = DropDownList13; drop[14] = DropDownList14; drop[15] = DropDownList15;
            for(int i=1; i<16; i++)
            {
                DropText[i] = drop[i].SelectedItem.Text;    //通过循环保护用户在下拉列表框中的选择
            }
        }
    }
}