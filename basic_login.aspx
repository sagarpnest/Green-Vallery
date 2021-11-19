<%@ Page Title="" Language="C#" MasterPageFile="~/basic.master" AutoEventWireup="true"
    CodeFile="basic_login.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">
    <style type="text/css">
        .style1
        {
        }
        .style2
        {
            width: 303px;
        }
        .style3
        {
            text-align: left;
        }
        .style4
        {
            width: 100px;
            height: 32px;
        }
        .style5
        {
            height: 23px;
        }
        .style6
        {
            height: 32px;
        }
    </style>
   

    <div class="single_stuff wow fadeInDown">

         <table class="style1">
        <tr>
            <td colspan="2">
                <strong><span class="style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <span class="style3">&nbsp; Login Page&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" style="color: #FF0000" Text="*"></asp:Label>
                </span></span></strong></td>
        </tr>
        <tr>
            <td class="style4">
                Email ID:</td>
            <td>
                
                <asp:TextBox ID="TextBox1" runat="server" Width="187px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                Password:</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Width="186px" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="login" onclick="Button1_Click" />
            &nbsp;&nbsp;
         

            </td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td>
                <asp:LinkButton ID="frgt_btn" runat="server" onclick="frgt_btn_Click">Forget password </asp:LinkButton>
            </td>
        </tr>
      
    </table>
    </div>
    
</asp:Content>
