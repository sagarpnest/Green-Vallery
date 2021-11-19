<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="admin_add_item.aspx.cs" Inherits="admin_add_item" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
<div>
    
        <table border="1" cellpadding="0" cellspacing="0" style="width:100%;">
            <tr>
                <td class="style9">
                    Food_id:</td>
                <td class="style5">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style6">
                    Menu:</td>
                <td class="style7">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10">
                    Sub_menu :</td>
                <td class="style9">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    &nbsp;</td>
            </tr>
          
       
            <tr>
                <td class="style3">
                    Food Picture :</td>
                <td class="style2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
            </tr>

  <tr>
                <td class="style10">
                    Ingredients :</td>
                <td class="style9">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    &nbsp;</td>
            </tr>
  <tr>
                <td class="style10">
                    Serve people :</td>
                <td class="style9">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    &nbsp;</td>
            </tr>          
            <tr>
                <td class="style10">
                    price :</td>
                <td class="style9">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10">
                    Spicyfood :</td>
                <td class="style9">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1" align="center" colspan="2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" Height="42px" onclick="Button1_Click" 
                        Text="Save" Width="79px" />
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
</asp:Content>

