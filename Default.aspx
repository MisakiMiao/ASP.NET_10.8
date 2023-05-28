<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Work_0520.WebForm1" %>

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
        <div>
            <h2>欢迎使用课表查询系统</h2>
            请选择一个班级:
            <asp:DropDownList ID="dropClass" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dropClass_SelectedIndexChanged"></asp:DropDownList>
        </div>
    </form>
</body>
</html>