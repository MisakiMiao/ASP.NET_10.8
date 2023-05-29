<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Work_0520.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>课表查询系统</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-size: cover;
            background-position: center;
        }

        .container {
            max-width: 500px;
            margin: 0 auto;
            padding: 20px;
            background-color: rgba(255, 255, 255, 0.8);
            border-radius: 5px;
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
        }

        h2 {
            text-align: center;
            margin-bottom: 20px;
            color: #333;
            font-size: 24px;
            text-shadow: 1px 1px 2px rgba(0, 0, 0, 0.3);
        }

        label {
            display: block;
            margin-bottom: 10px;
            font-weight: bold;
            color: #333;
            font-size: 16px;
        }

        .dropdown-container {
            text-align: center;
        }

        .dropdown-container .dropdown-label {
            margin-bottom: 10px;
        }

        .dropdown-container .dropdown-list {
            display: inline-block;
            padding: 8px 16px;
            font-size: 16px;
            border-radius: 4px;
            border: 1px solid #ccc;
            background-color: #fff;
            color: #333;
            cursor: pointer;
            transition: background-color 0.3s ease;
        }

        .dropdown-container .dropdown-list:hover {
            background-color: #f5f5f5;
        }
        .image-container {
            text-align: center;
            margin:0 auto;
            margin-top: 20px;
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
            <h2>欢迎使用课表查询系统</h2>
            <div class="dropdown-container">
                <label for="dropClass" class="dropdown-label">请选择一个班级:</label>
                <asp:DropDownList ID="dropClass" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dropClass_SelectedIndexChanged" CssClass="dropdown-list">
                </asp:DropDownList>
            </div>
        </div>
    </form>
</body>
</html>
