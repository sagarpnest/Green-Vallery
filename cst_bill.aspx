<%@ Page Title="" Language="C#" MasterPageFile="~/cst.master" AutoEventWireup="true" CodeFile="cst_bill.aspx.cs" Inherits="cst_bill" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
<div >
<br />
        <br />
        <asp:Label ID="Label2" runat="server" ForeColor="Red" 
            Text="Payment cart..."></asp:Label>
        <br />
        <br />
        <table border="1" cellpadding="0" cellspacing="0" class="style1">
            <tr>
                <td class="style2">
                    Order Id:</td>
                <td>
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Order Date:</td>
                <td>
                    <asp:Label ID="Label4" runat="server"></asp:Label>
                </td>
            </tr>
        </table>


    
    </div>
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" 
        CellPadding="3" CellSpacing="2" ShowFooter="True">
        <Columns>
            <asp:BoundField DataField="sno" HeaderText="S.No" />
            <asp:BoundField DataField="food_id" HeaderText="Prodcut ID" />
            <asp:BoundField DataField="name" HeaderText="Prodcut Name" />
            <asp:BoundField DataField="price" HeaderText="Price" />
            <asp:BoundField DataField="quantity" HeaderText="Quantity" />
            <asp:BoundField DataField="totalprice" HeaderText="Total Price" />
        </Columns>
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FFF1D4" />
        <SortedAscendingHeaderStyle BackColor="#B95C30" />
        <SortedDescendingCellStyle BackColor="#F1E5CE" />
        <SortedDescendingHeaderStyle BackColor="#93451F" />
    </asp:GridView>
    <br />
    <table border="1" cellpadding="0" cellspacing="0" class="style3">
        <tr>
            <td class="style6">
                feedback:</td>
            <td class="style4">
                <asp:TextBox ID="TextBox1" runat="server" Height="102px" TextMode="MultiLine" 
                    Width="351px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style7">
                Mobile Number:</td>
            <td class="style5">
                <asp:TextBox ID="TextBox2" runat="server" Width="307px"></asp:TextBox>
            </td>
            <tr>
            <td class="style7">
                Payment Taken By:</td>
            <td class="style5">
                <asp:TextBox ID="TextBox3" runat="server" Width="307px"></asp:TextBox>
            </td>
        </tr>
       
    </table>
    <br />
    <asp:Button ID="Button1" runat="server" BackColor="#FFCC00" 
        onclick="Button1_Click" Text="Complete" Width="122px" />
</asp:Content>

