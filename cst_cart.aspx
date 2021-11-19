<%@ Page Title="" Language="C#" MasterPageFile="~/cst.master" AutoEventWireup="true" CodeFile="cst_cart.aspx.cs" Inherits="cst_cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">

        <br />
        You select in your cart :

        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Larger" 
            ForeColor="Red"></asp:Label>
&nbsp;in your cart.&nbsp;&nbsp;

        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/cst_menu.aspx">continue Order,...</asp:HyperLink>
        <br />
        <br />
        <br />

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            CellPadding="4" ForeColor="#333333" GridLines="None" Height="229px" 
            onrowdeleting="GridView1_RowDeleting" ShowFooter="True" Width="700px"
            onselectedindexchanged="GridView1_SelectedIndexChanged">

            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="sno" HeaderText="S.No">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>

                <asp:BoundField DataField="food_id" HeaderText="ID">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>

                <asp:BoundField DataField="sub_menu" HeaderText=" Name" />

                <asp:BoundField DataField="price" HeaderText="Price" />

                <asp:BoundField DataField="quantity" HeaderText="quantity" />

                <asp:BoundField DataField="totalprice" HeaderText="Total Price" />

                <asp:CommandField SelectText="Confirm" ShowSelectButton="True" />
                
                <asp:CommandField DeleteText="Remove" ShowDeleteButton="True" />
            </Columns>

            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333"  />

            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <br />
        <%--<asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="order place" />--%>
      <%--  <asp:Button ID="Button1" runat="server" BackColor="#FFCC00" 
            onclick="Button1_Click" Text="check out" Width="126px" />--%>
        <br />
</asp:Content>

