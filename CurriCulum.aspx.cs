using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Work_0520
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["st"] == null)
            {
                Response.Redirect("Default.aspx");
            }
            this.Title = Request.QueryString["st"] + "班级课表";
            //返回课程表中指定班级的记录
            string SqlSelect = "select * from syllabus where class = N'" + Request.QueryString["st"] + "'";
            DataTable dt = MyClass1.GetDT(SqlSelect);
            Table1.Width = 450;         //设置表格的宽度
            //设置表格的标题
            Table1.Caption = "<b><h2>" + Request.QueryString["st"] + "班课程表</h2></b>";
            Table1.GridLines = GridLines.Both;  //设置单元格的框线
            Table1.Height = 180;
            Table1.CellPadding = 1;             //设置单元格内间距
            Table1.CellSpacing = 3;             //设置单元格之间的距离
            int Num = 1;
            for(int i=0; i<4; i++)
            {
                TableRow TabRow = new TableRow();      //声明一个表格行对象
                for(int j=0; j<6; j++)
                {
                    TableCell TabCell = new TableCell();    //声明一个单元格对象
                    TabCell.HorizontalAlign = HorizontalAlign.Center;
                    if (j == 0)
                    {
                        switch (i)
                        {
                            case 0:
                                TabCell.Text = "&nbsp;";
                                TabRow.Cells.Add(TabCell);
                                break;
                            case 1:
                                TabCell.Text = "<b>1 - 2节</b>";
                                TabRow.Cells.Add(TabCell);
                                break;
                            case 2:
                                TabCell.Text = "<b>3 - 4节</b>";
                                TabRow.Cells.Add(TabCell);
                                break;
                            case 3:
                                TabCell.Text = "<b>5 - 6节</b>";
                                TabRow.Cells.Add(TabCell);
                                break;
                        }
                    }
                    else             //其它各列的设置
                    {
                        if (i == 0)
                        {
                            switch (j)
                            {
                                case 1:
                                    TabCell.Text = "<b>星期一</b>";
                                    TabRow.Cells.Add(TabCell);
                                    break;
                                case 2:
                                    TabCell.Text = "<b>星期二</b>";
                                    TabRow.Cells.Add(TabCell);
                                    break;
                                case 3:
                                    TabCell.Text = "<b>星期三</b>";
                                    TabRow.Cells.Add(TabCell);
                                    break;
                                case 4:
                                    TabCell.Text = "<b>星期四</b>";
                                    TabRow.Cells.Add(TabCell);
                                    break;
                                case 5:
                                    TabCell.Text = "<b>星期五</b>";
                                    TabRow.Cells.Add(TabCell);
                                    break;
                            }
                        }
                    }
                    if(i!=0 && j != 0)          //如果既不是第一行也不是第一列
                    {
                        if (dt.Rows[0][Num].ToString() != "")
                        {
                            //读取dt对象中当前列的数据填写到单元格中
                            TabCell.Text = dt.Rows[0][Num].ToString();
                            TabRow.Cells.Add(TabCell);
                            Num = Num + 1;      //定位到下一列
                        }
                        else
                        {
                            TabCell.Text = "&nbsp;";
                            TabRow.Cells.Add(TabCell);
                            Num = Num + 1;
                        }
                    }
                }
                Table1.Rows.Add(TabRow);
            }
            TableRow FootRow = new TableRow();
            TableCell FtCell = new TableCell();
            FtCell.HorizontalAlign = HorizontalAlign.Center;
            FtCell.ColumnSpan = 6;
            FtCell.Height = 25;
            LinkButton lnk = new LinkButton();          //创建一个LinkButton对象
            lnk.PostBackUrl = "Default.aspx";           //设置LinkButton对象的属性
            lnk.Text = "返回";                          
            FtCell.Controls.Add(lnk);                   //将LinkButton对象添加到单元格
            FootRow.Cells.Add(FtCell);                  //将单元格添加到表格行
            Table1.Rows.Add(FootRow);                   //将表格行添加到表格
            dt = null;
        }
    }
}