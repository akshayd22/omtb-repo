<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center>
    <table style="width: 51%; height: 180px;">
    <tr>
            <td colspan="2">
            <center>
         <asp:Label class="center" ID="Label1" runat="server" 
        Text="Login" Font-Bold="True" Font-Italic="True" 
        Font-Names="Bernard MT Condensed" Font-Size="XX-Large" Font-Underline="True"></asp:Label>
     </center>
    &nbsp;</td>
       
    </tr>
    
    <tr>
        <td class="right" style="width: 393px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblUsername" runat="server" Text="Username: " Font-Bold="True" 
                Font-Names="Copperplate Gothic Bold" Font-Size="Large"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtUsername" runat="server" 
                Font-Names="Copperplate Gothic Bold"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="right" style="width: 393px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblPassword" runat="server" Text="Password: " Font-Bold="True" 
                Font-Names="Copperplate Gothic Bold" Font-Size="Large"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtPassword" runat="server" 
                Font-Names="Copperplate Gothic Bold" TextMode="Password"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 393px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="hlForgetPassword" runat="server">Forget Password?</asp:HyperLink>
        </td>
        <td>
            &nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="hlSignup" runat="server">Sign Up?</asp:HyperLink>
        </td>
    </tr>
    <tr>
        <td style="width: 393px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button 
                ID="btnLogin" runat="server" style="text-align: right" 
                Text="Login" Font-Bold="True" Font-Names="Century Schoolbook" 
                Font-Size="Large" Height="32px" Width="94px" onclick="btnLogin_Click" />
        </td>
        <td>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" Font-Bold="True" 
                Font-Names="Century Schoolbook" Font-Size="Large" Height="30px" 
                Width="79px" />
        </td>
    </tr>
</table>
    </center>
    
<br />
    <br />
    <br />
    <br />
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="Uid" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="Uid" HeaderText="Uid" ReadOnly="True" 
                    SortExpression="Uid" />
                <asp:BoundField DataField="User_Name" HeaderText="User_Name" 
                    SortExpression="User_Name" />
                <asp:BoundField DataField="Mobail_No" HeaderText="Mobail_No" 
                    SortExpression="Mobail_No" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="Login_Date_Time" HeaderText="Login_Date_Time" 
                    SortExpression="Login_Date_Time" />
                <asp:BoundField DataField="Logout_Date_Time" HeaderText="Logout_Date_Time" 
                    SortExpression="Logout_Date_Time" />
            </Columns>
        </asp:GridView>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionStringregis %>" 
            SelectCommand="SELECT * FROM [Login Details]"></asp:SqlDataSource>
    </div>
    
</asp:Content>

