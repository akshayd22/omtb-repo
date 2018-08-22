<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.master" AutoEventWireup="true" CodeFile="AdinLogin.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
<center>
<br /><br />
    <table>
    <tr>
        <td colspan="2">
        <center>
<asp:Label class="center" ID="Label10" runat="server" 
        Text="Admin Login..." Font-Bold="True" Font-Italic="True" 
        Font-Names="Bernard MT Condensed" Font-Size="XX-Large" Font-Underline="True"></asp:Label>
        </center>
            &nbsp;</td>
       
    </tr>
    
    <tr>
        <td style="width: 143px"><center style="width: 183px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblAdminname" runat="server" Text="Admin Name: " Font-Bold="True" 
                Font-Names="Copperplate Gothic Bold" Font-Size="Large"></asp:Label>
                </center>
        </td>
        <td>
            <asp:TextBox ID="txtAdminname" runat="server" 
                Font-Names="Copperplate Gothic Bold"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 143px">
        <center style="width: 185px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblAdminPassword" runat="server" Text="Password: " Font-Bold="True" 
                Font-Names="Copperplate Gothic Bold" Font-Size="Large"></asp:Label>
                </center>
        </td>
        <td>
            <asp:TextBox ID="txtAdminPassword" runat="server" 
                Font-Names="Copperplate Gothic Bold" TextMode="Password"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 143px"><center>
            &nbsp;<asp:HyperLink ID="hlForgetPassword" runat="server">Forget Password?</asp:HyperLink>
            </center>
        </td>
        <td>
            <center>
            <asp:HyperLink ID="hlSignup" runat="server">Sign Up?</asp:HyperLink>
            </center>
        </td>
    </tr>
    <tr>
        <td style="width: 143px"><center>            
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button 
                ID="btnAdminLogin" runat="server" style="text-align: right" 
                Text="Login" Font-Bold="True" Font-Names="Century Schoolbook" 
                Font-Size="Large" Height="32px" Width="94px" 
                onclick="btnAdminLogin_Click" />
                </center>

        </td>
        <td><center>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnAdminCancel" runat="server" Text="Cancel" Font-Bold="True" 
                Font-Names="Century Schoolbook" Font-Size="Large" Height="30px" 
                Width="79px" />
                </center>
        </td>
    </tr>
</table>
    
    
<br />
    <br />
    <br />
    <br />


</center>
</div>
</asp:Content>

