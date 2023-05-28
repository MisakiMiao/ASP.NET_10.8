<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="Work_0520.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <style>
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="d1">
            <asp:Panel ID="Panel1" runat="server">
                请输入密码:<asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>
                <asp:Button ID="btnOK" runat="server" Text="确定" OnClick="btnOK_Click" />
            </asp:Panel>
            <asp:Panel ID="Panel2" runat="server">
                <h1>新建课程表</h1>
                <div id="tbd">
                    <table>
                        <tr>
                            <asp:TextBox ID="txtClass" runat="server"></asp:TextBox>班课程表
                            <asp:Button ID="btnSubmit" runat="server" Text="提交" OnClick="btnSubmit_Click" />
                            <asp:Button ID="btnBack" runat="server" Text="返回" PostBackUrl="~/Default.aspx" />
                        </tr>
                        <tr>
                            <td></td>
                            <td>星期一</td>
                            <td>星期二</td>
                            <td>星期三</td>
                            <td>星期四</td>
                            <td>星期五</td>
                        </tr>
                        <tr>
                            <td>1 - 2节</td>
                            <td>
                                <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged ="DropDownList_SelectedIndexChanged"></asp:DropDownList></td>
                            <td>
                                <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged ="DropDownList_SelectedIndexChanged"></asp:DropDownList></td>
                            <td>
                                <asp:DropDownList ID="DropDownList3" runat="server" OnSelectedIndexChanged ="DropDownList_SelectedIndexChanged"></asp:DropDownList></td>
                            <td>
                                <asp:DropDownList ID="DropDownList4" runat="server" OnSelectedIndexChanged ="DropDownList_SelectedIndexChanged"></asp:DropDownList></td>
                            <td>
                                <asp:DropDownList ID="DropDownList5" runat="server" OnSelectedIndexChanged ="DropDownList_SelectedIndexChanged"></asp:DropDownList></td>
                        </tr>
                        <tr>
                            <td>3 - 4节</td>
                            <td>
                                <asp:DropDownList ID="DropDownList6" runat="server" OnSelectedIndexChanged ="DropDownList_SelectedIndexChanged"></asp:DropDownList></td>
                            <td>
                                <asp:DropDownList ID="DropDownList7" runat="server" OnSelectedIndexChanged ="DropDownList_SelectedIndexChanged"></asp:DropDownList></td>
                            <td>
                                <asp:DropDownList ID="DropDownList8" runat="server" OnSelectedIndexChanged ="DropDownList_SelectedIndexChanged"></asp:DropDownList></td>
                            <td>
                                <asp:DropDownList ID="DropDownList9" runat="server" OnSelectedIndexChanged ="DropDownList_SelectedIndexChanged"></asp:DropDownList></td>
                            <td>
                                <asp:DropDownList ID="DropDownList10" runat="server" OnSelectedIndexChanged ="DropDownList_SelectedIndexChanged"></asp:DropDownList></td>
                        </tr>
                        <tr>
                            <td>5 - 6节</td>
                            <td>
                                <asp:DropDownList ID="DropDownList11" runat="server" OnSelectedIndexChanged ="DropDownList_SelectedIndexChanged"></asp:DropDownList></td>
                            <td>
                                <asp:DropDownList ID="DropDownList12" runat="server" OnSelectedIndexChanged ="DropDownList_SelectedIndexChanged"></asp:DropDownList></td>
                            <td>
                                <asp:DropDownList ID="DropDownList13" runat="server" OnSelectedIndexChanged ="DropDownList_SelectedIndexChanged"></asp:DropDownList></td>
                            <td>
                                <asp:DropDownList ID="DropDownList14" runat="server" OnSelectedIndexChanged ="DropDownList_SelectedIndexChanged"></asp:DropDownList></td>
                            <td>
                                <asp:DropDownList ID="DropDownList15" runat="server" OnSelectedIndexChanged ="DropDownList_SelectedIndexChanged"></asp:DropDownList></td>
                        </tr>
                    </table>

                </div>
                
            </asp:Panel>
        </div>
    </form>
</body>
</html>
