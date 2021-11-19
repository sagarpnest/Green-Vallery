<%@ Page Title="" Language="C#" MasterPageFile="~/cst.master" AutoEventWireup="true" CodeFile="cst_menu.aspx.cs" Inherits="Cst_menu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
 you have products in your cart:<asp:Label ID="Label3" runat="server" Font-Bold="True"
            Font-Size="X-Large" ForeColor="Red"></asp:Label>
        &nbsp;&nbsp;&nbsp;

        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/cst_cart.aspx">show cart...</asp:HyperLink>
        <br />
        <br />
        filter product acording to category:<br />
        <br />
       
        <br />
        <table class="style1"  >
            <tr>
                <td>
                   
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Soup</asp:LinkButton>
                    &nbsp; |&nbsp;
                    <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Starter</asp:LinkButton>
                    &nbsp;|&nbsp;
                     <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">Paneer</asp:LinkButton>
                    &nbsp;|&nbsp;
                     <asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click">Veg.</asp:LinkButton>
                    &nbsp;|&nbsp;
                     <asp:LinkButton ID="LinkButton6" runat="server" OnClick="LinkButton6_Click">Roti</asp:LinkButton>
                    &nbsp;|&nbsp;
                     <asp:LinkButton ID="LinkButton7" runat="server" OnClick="LinkButton7_Click">Rice</asp:LinkButton>
                    &nbsp;|&nbsp;
                    <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">All Item</asp:LinkButton>
                </td>
            </tr>
        </table>
        <br />
        <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" RepeatColumns="3"
              onitemcommand="DataList1_ItemCommand" RepeatDirection="Horizontal">
            <ItemTemplate>
                <table width ="100%" bgcolor="#99FFCC" border="2" cellpadding="0" cellspacing="0" class="style1">
                    <tr>
                        <td align="center">
                            <b>ItemID:</b> 
                            <asp:Label ID="IDLabel"  runat="server" Text='<%# Eval("food_id") %>' />
                       </td>
                    </tr> 
                    <tr>
                        <td align="center">
                            <b>Name:</b>
                            <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Sub_menu") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td align="center">
                            Image:<asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("picture_path") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td align="center">
                            &nbsp;<b>Price:</b>
                            <asp:Label ID="PriceLabel" runat="server" Text='<%# Eval("price") %>' />
                        </td>
                    </tr>
                     <tr>
       
                        <td align="center">
                            &nbsp;<b>Ingredients:</b><br/>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("ingredients") %>' />
                        </td>
                  
                    </tr>
                     <tr>
                        <td align="center">
                            &nbsp;<b>Serve_people:</b>
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("serve_people") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td align="center">
                            Quentity:      <asp:DropDownList ID="DropDownList1" runat="server">
                                <asp:ListItem>1</asp:ListItem>
                                <asp:ListItem>2</asp:ListItem>
                                <asp:ListItem>3</asp:ListItem>
                                <asp:ListItem>4</asp:ListItem>
                                <asp:ListItem>5</asp:ListItem>
                            </asp:DropDownList>
                       
                            <%--<asp:TextBox ID="TextBox1" runat="server" TextMode></asp:TextBox>--%>
                        </td>
                    </tr>
                    <tr>
                        <td align="center">
                            <asp:ImageButton ID="ImageButton1" runat="server" 
                                CommandArgument='<%# Eval("food_id") %>' CommandName="add2cart" Height="36px" 
                                ImageUrl="~/images/add2cart.png" Width="97px" />
                        </td>
                    </tr>
                    <br />
                </table>

            </ItemTemplate>
        </asp:DataList>
        <br />
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
            SelectCommand="SELECT * FROM [menu_table] "></asp:SqlDataSource>
        <br />
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
            SelectCommand="SELECT * FROM [menu_table] WHERE ([menu] = @category)">
            <SelectParameters>
                <asp:QueryStringParameter Name="category" QueryStringField="cat" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <br />
        <br />
        <br />
</asp:Content>

