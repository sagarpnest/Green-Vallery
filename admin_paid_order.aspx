<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="admin_paid_order.aspx.cs" Inherits="admin_paid_order" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
 <br />
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" 
        ForeColor="Red" Text="All Paid orders are given below:"></asp:Label>
    <br />
  <br />   

    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" 
        BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" width="500px"
        DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="order_id" HeaderText="Order Id" 
                SortExpression="orderid" />
            <asp:BoundField DataField="feedback" HeaderText="Feedback" 
                SortExpression="address" />
            <asp:BoundField DataField="mobile_no" HeaderText="Mobile" 
                SortExpression="mobilenumber" />
            <asp:BoundField DataField="total_price" HeaderText="Bill" 
                SortExpression="total_price" />
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
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
        SelectCommand="SELECT [order_id], [feedback], [mobile_no], [total_price] FROM [bill_payment] WHERE ([bill_status] = 1)">
        <SelectParameters>
            <asp:Parameter DefaultValue="1" Name="emp_payment" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>

