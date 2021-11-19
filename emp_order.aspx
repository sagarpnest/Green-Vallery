<%@ Page Title="" Language="C#" MasterPageFile="~/emp.master" AutoEventWireup="true" CodeFile="emp_order.aspx.cs" Inherits="emp_order" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
<div>
    
        <asp:Button ID="Button2" runat="server" onclick="Button1_Click" Text="Place" />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" 
            CellPadding="3" CellSpacing="2" DataKeyNames="order_no" 
            DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="order_no" HeaderText="orderno" ReadOnly="True" 
                    SortExpression="order_no" />
                <asp:BoundField DataField="order_id" HeaderText="orderid" 
                    SortExpression="order_id" />
                <asp:BoundField DataField="sn_ro" HeaderText="sno" SortExpression="sno" />
                <asp:BoundField DataField="food_id" HeaderText="id" 
                    SortExpression="food_id" />
                <asp:BoundField DataField="sub_menu" HeaderText="name" 
                    SortExpression="sub_menu" />
                <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                <asp:BoundField DataField="quantity" HeaderText="quantity" 
                    SortExpression="quantity" />
                <asp:BoundField DataField="dateoforder" HeaderText="dateoforder" 
                    SortExpression="dateoforder" />
                <asp:TemplateField HeaderText="order_status" SortExpression="order_status">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("order_status") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="ck1" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
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
            SelectCommand="SELECT * FROM [orderdetail] WHERE ([order_status] = @order_status)">
            <SelectParameters>
                <asp:Parameter DefaultValue="0" Name="order_status" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <br />
        
    
    </div>

</asp:Content>

