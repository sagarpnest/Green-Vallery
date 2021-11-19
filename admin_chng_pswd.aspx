<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="admin_chng_pswd.aspx.cs" Inherits="admin_chng_pswd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
<head>
        <title></title>
        <style type="text/css">
            .style1
            {
                height: 30px;
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
                <b> Email id</b>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                 <b>Old Password</b>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" TextMode ="Password"  runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <b> New Password</b>
            </td>
            <td>
                <asp:TextBox ID="TextBox3" TextMode ="Password" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <b>Confirm password</b>
            </td>
            <td>
                <asp:TextBox ID="TextBox4" TextMode ="Password" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Button ID="Button1"  runat="server" OnClick="Button1_Click"  Text="Change password " />
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
        </tr>
         <tr>
            <td align="center" colspan="2">
                <asp:Button ID="Button2"  runat="server" OnClick="Button2_Click"  Text="Recover password " />
            </td>
        </tr>
    </table>
</asp:Content>

