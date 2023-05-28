using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Work_0520
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Title = "课程表查询系统";
            if (!IsPostBack)
            {
                string sql = "select class from syllabus";
                //调用MyClass静态类中的GetClasses()方法得到班级表
                DataTable dt = MyClass1.GetDT(sql);
                dropClass.DataSource = dt;          //将班级表作为下拉列表框空间的数据源
                dropClass.DataTextField = "class";  //指定下拉列表框绑定到的字段
                dropClass.DataBind();
                dropClass.Items.Add("新建课程表");
                dropClass.Items.Add("--请选择--");
                dropClass.Text = "--请选择--";
                dt = null;
            }
        }

        protected void dropClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropClass.SelectedItem.Text != "新建课程表")     //若选择的不是"新建课程表"
            {
                //跳转到课程表查询页面,并传递用户选择的班级名称
                Response.Redirect("CurriCulum.aspx?st=" + dropClass.SelectedItem.Text);
            }
            else
            {
                Response.Redirect("admin.aspx");        //否则跳转到管理员页面
            }
        }
    }
}