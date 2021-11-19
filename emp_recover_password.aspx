<%@ Page Title="" Language="C#" MasterPageFile="~/emp.master" AutoEventWireup="true" CodeFile="emp_recover_password.aspx.cs" Inherits="emp_recover_password" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
<div class="single_stuff wow fadeInDown">
<br />
         <table class="style1">
        <tr>
            <td colspan="2">
                <strong><span class="style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <span class="style3">&nbsp; Password Recovery Page&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" style="color: #FF0000" Text="*"></asp:Label>
                </span></span></strong></td>
        </tr>
        
        <tr>
            <td class="style4">
                <b>Email ID:</b></td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="187px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
               <b> Mobile Number:</b>
               </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Width="187px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Recovery" onclick="Button1_Click" />
           </td>
        </tr>
        <asp:Label
                    ID="Label2" runat="server" Text="Label"></asp:Label>
    </table>
    </div>

</asp:Content>

