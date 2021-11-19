<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="admin_show_menu.aspx.cs" Inherits="admin_show_menu" %>

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

    <div>
        Search:&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <table border="1" cellpadding="0" cellspacing="0" class="style1">
            <tr>
                <td class="style1">
                    <b>Food_id:</b>
                </td>
                <td>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    <b>Name:</b>
                </td>
                <td>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    <b>Price:</b>
                </td>
                <td>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    <b>Serve People:</b>
                </td>
                <td>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <br />
        &nbsp;<asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="SEARCH" />
    &nbsp;<asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
            Text="DETELE" />
            <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
            Text="Update_price" />
    </div>

</asp:Content>

