<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="admin_add_table.aspx.cs" Inherits="admin_add_table" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
This is admin add table page
<head>
        <title></title>
        <style type="text/css">
            .style1
            {
                height: 30pX;
            }
            .style2
            {
                text-align: left;
            }
            .style3
            {
            }
            .style4
            {
                width: 136px;
                text-align: left;
            }
        </style>
    </head>
    <br />
    <br />

<table border="1" cellpadding="1" cellspacing="1" class="style1">
        <tr>
            <td>
                <b> Email id:</b>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                 <b>Password:</b>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" TextMode ="Password"  runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Button ID="BtnTableAdd"  runat="server" OnClick="BtnTableAdd_Click"  Text="ADD TABLE " />
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
        </tr>
        
    </table>
</asp:Content>

