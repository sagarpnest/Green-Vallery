<%@ Page Title="" Language="C#" MasterPageFile="~/basic.master" AutoEventWireup="true"
    CodeFile="basic_reg.aspx.cs" Inherits="basic_reg" %>

<%@ Register Assembly="MSCaptcha" Namespace="MSCaptcha" TagPrefix="rsv" %>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">
    <table class="style1">
        <tr>
            <td class="style16" colspan="2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <strong><span class="style3"><span class="style13">Registration Page</span>&nbsp;</span></strong>
            </td>
        </tr>
        <tr>
            <td class="style2" colspan="2">
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
            </td>
        </tr>
        <tr>
            <td align="right" class="style6">
                <strong>Email Id</strong>
            </td>
            <td>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <div class="style14">
                            <asp:TextBox ID="TextBox1" runat="server" Width="195px" AutoPostBack="True" OnDataBinding="TextBox1_TextChanged"
                                OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                            &nbsp;
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1"
                                ErrorMessage="Enter valid Email Id" Font-Bold="True" Font-Size="Medium" ForeColor="Red"
                                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox1"
                                ErrorMessage="email id can not be Blank" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td align="right" class="style6">
                <strong>Password</strong>
            </td>
            <td class="style14">
                <asp:TextBox ID="TextBox2" runat="server" Width="195px" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2"
                    ErrorMessage="password should not be Blank" Font-Bold="True" Font-Size="Medium"
                    ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="right" class="style7">
                <strong>ReType Password</strong>
            </td>
            <td class="style15">
                <asp:TextBox ID="TextBox3" runat="server" Width="195px" TextMode="Password"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2"
                    ControlToValidate="TextBox3" ErrorMessage="Enter correct password" Font-Bold="True"
                    Font-Size="Medium" ForeColor="#FF3300"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td align="right" class="style11">
                <strong>Mobile Numbe</strong>r
            </td>
            <td class="style12">
                <asp:TextBox ID="TextBox4" runat="server" MaxLength="10" Width="195px"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox4"
                    ErrorMessage="Enter Valid Number" Font-Bold="True" Font-Size="Medium" ForeColor="Red"
                    ValidationExpression="[7-9][0-9]{9}$"></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox4"
                    ErrorMessage="Mobile Number can not be Blank" Font-Bold="True"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style8">
                <strong>User Name</strong>
            </td>
            <td class="style4">
                <asp:TextBox ID="TextBox5" runat="server" Width="195px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox5"
                    ErrorMessage="User name can not be Blank" Font-Bold="True"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style">
            </td>
            <td class="style5">
                <rsv:CaptchaControl ID="captcha1" runat="server" CaptchaHeight="60" CaptchaWidth="200"
                    CaptchaLineNoise="None" CaptchaMinTimeout="5" CaptchaMaxTimeout="240" ForeColor="#00FFCC"
                    BackColor="White" CaptchaChars="ABCDEFGHIJKLNPQRTUVXYZ12346789" FontColor="Red"
                    Height="24px" Width="210px" />
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style6">
                <strong>Enter Captcha Image</strong>
            </td>
            <td class="style14">
                <asp:TextBox ID="TextBox6" runat="server" Width="195px"></asp:TextBox>
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="*"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox6"
                    ErrorMessage="Enter valid captcha" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="Large" Style="background-color: #99CCFF"
                    Text="Submit" Width="121px" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
