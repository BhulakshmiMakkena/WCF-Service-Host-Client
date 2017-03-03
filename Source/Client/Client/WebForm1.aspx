﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Client.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table style="font-family:Arial; border:1px solid black;">
    <tr>
        <td>
            <b>ID</b>
        </td>
        <td>
            <asp:TextBox ID="txtID" runat="server">
            </asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <b>Name</b>
        </td>
        <td>
            <asp:TextBox ID="txtName" runat="server">
            </asp:TextBox>
        </td>
    </tr>
    <%--<tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>--%>
    <tr>
        <td class="auto-style1">
            <asp:Button ID="btnGetEmployee" runat="server" 
                                 Text="Get Employee" 
                                 onclick="btnGetEmployee_Click" />                                    
        </td>
        <td class="auto-style1">
            <asp:Button ID="btnSave" runat="server" 
                        Text="Save Employee" 
                        onclick="btnSave_Click" />
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Label ID="lblMessage" runat="server" 
                        ForeColor="Green" Font-Bold="true">
            </asp:Label>
        </td>
    </tr>
</table>
    </div>
    </form>
</body>
</html>
