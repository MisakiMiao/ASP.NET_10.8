<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="Work_0520.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>

    <style>
        *{
            text-align:center;
            margin:0 auto;
        }
        body {
            font-family: Arial, sans-serif;
            background-color: #f5f5f5;
        }

        .container {
            width: 750px;
            margin: 0 auto;
            padding: 20px;
            background-color: #fff;
            border-radius: 5px;
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
        }

        h1 {
            text-align: center;
            margin-top: 0;
        }

        table {
            text-align:center;
            width: 100%;
            border-collapse: collapse;
            margin-top: 20px;
        }

        table td {
            width:auto;
            height:50px;
            border: 1px solid #ddd;
            text-align: center;
            margin-left:10px;
            margin-right:10px;
            padding:0 10px 0 10px;
        }

        .btn-container {
            text-align: center;
            margin-top: 20px;
        }

        .btn-container .btn {
            padding: 10px 20px;
            background-color: #4CAF50;
            color: #fff;
            border: none;
            border-radius: 3px;
            cursor: pointer;
        }

        .btn-container .btn-back {
            background-color: #ccc;
            margin-left: 10px;
        }
        
        .image-container {
            text-align: center;
            margin:0 auto;
            margin-top: 20px;
            margin-bottom:20px;
            height:150px;
            width:150px;
        }

        .image-container img {
            height:150px;
            width:150px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="image-container">
                <img src="/images/gg.jpg" alt="Logo"/>
            </div>
            <div id="d1">
                <asp:Panel ID="Panel1" runat="server">
                    请输入密码:<asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnOK" runat="server" Text="确定" OnClick="btnOK_Click" />
                </asp:Panel>
                <asp:Panel ID="Panel2" runat="server">
                    <h1 style="margin-bottom:20px">新建课程表</h1>
                    <div id="tbd">
                        <table>
                            <tr>
                                <asp:TextBox ID="txtClass" runat="server"></asp:TextBox>班课程表
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
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
                                    <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList_SelectedIndexChanged"></asp:DropDownList>
                                </td>
                                <td>
                                    <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList_SelectedIndexChanged"></asp:DropDownList>
                                </td>
                                <td>
                                    <asp:DropDownList ID="DropDownList3" runat="server" OnSelectedIndexChanged="DropDownList_SelectedIndexChanged"></asp:DropDownList>
                                </td>
                                <td>
                                    <asp:DropDownList ID="DropDownList4" runat="server" OnSelectedIndexChanged="DropDownList_SelectedIndexChanged"></asp:DropDownList>
                                </td>
                                <td>
                                    <asp:DropDownList ID="DropDownList5" runat="server" OnSelectedIndexChanged="DropDownList_SelectedIndexChanged"></asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td>3 - 4节</td>
                                <td>
                                    <asp:DropDownList ID="DropDownList6" runat="server" OnSelectedIndexChanged="DropDownList_SelectedIndexChanged"></asp:DropDownList>
                                </td>
                                <td>
                                    <asp:DropDownList ID="DropDownList7" runat="server" OnSelectedIndexChanged="DropDownList_SelectedIndexChanged"></asp:DropDownList>
                                </td>
                                <td>
                                    <asp:DropDownList ID="DropDownList8" runat="server" OnSelectedIndexChanged="DropDownList_SelectedIndexChanged"></asp:DropDownList>
                                </td>
                                <td>
                                    <asp:DropDownList ID="DropDownList9" runat="server" OnSelectedIndexChanged="DropDownList_SelectedIndexChanged"></asp:DropDownList>
                                </td>
                                <td>
                                    <asp:DropDownList ID="DropDownList10" runat="server" OnSelectedIndexChanged="DropDownList_SelectedIndexChanged"></asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td>5 - 6节</td>
                                <td>
                                    <asp:DropDownList ID="DropDownList11" runat="server" OnSelectedIndexChanged="DropDownList_SelectedIndexChanged"></asp:DropDownList>
                                </td>
                                <td>
                                    <asp:DropDownList ID="DropDownList12" runat="server" OnSelectedIndexChanged="DropDownList_SelectedIndexChanged"></asp:DropDownList>
                                </td>
                                <td>
                                    <asp:DropDownList ID="DropDownList13" runat="server" OnSelectedIndexChanged="DropDownList_SelectedIndexChanged"></asp:DropDownList>
                                </td>
                                <td>
                                    <asp:DropDownList ID="DropDownList14" runat="server" OnSelectedIndexChanged="DropDownList_SelectedIndexChanged"></asp:DropDownList>
                                </td>
                                <td>
                                    <asp:DropDownList ID="DropDownList15" runat="server" OnSelectedIndexChanged="DropDownList_SelectedIndexChanged"></asp:DropDownList>
                                </td>
                            </tr>
                        </table>
                        <br />
                        <asp:Button ID="btnSubmit" runat="server" Text="提交" OnClick="btnSubmit_Click" CssClass="btn" />&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnBack" runat="server" Text="返回" PostBackUrl="~/Default.aspx" CssClass="btn btn-back" />
                    </div>
                </asp:Panel>
            </div>
        </div>
    </form>
</body>
</html>
