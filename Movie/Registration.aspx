<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.master" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br /><center>
<div style="width: 951px; background-image: url('layout/images/rgfrmbd.jpg'); background-attachment: fixed;">
<center><br />
<table align="center">
<tr><td colspan="2">
    <asp:Label ID="lblregis" runat="server" Text="Registration" Font-Bold="True" 
                Font-Size="25pt" ForeColor="#005100" Font-Names="Times New Roman"></asp:Label><br /><br />
</td></tr>
<tr><td>
<asp:Label ID="lblName" runat="server" Text="Full Name: " Font-Bold="True" 
                Font-Names="Copperplate Gothic Bold" Font-Size="Large" 
        ForeColor="#2B2BFF"></asp:Label></td>
<td>
    <asp:TextBox ID="txtFullName" runat="server" Font-Names="Copperplate Gothic Bold"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="txtFullName" ErrorMessage="Plese Enter Full Name"></asp:RequiredFieldValidator>
</td></tr>
<tr><td>
    <asp:Label ID="lblAge" runat="server" Text="Age:" Font-Bold="True" 
                Font-Names="Copperplate Gothic Bold" Font-Size="Large" 
        ForeColor="#2B2BFF"></asp:Label>
</td><td>
    <asp:TextBox ID="txtAGE" runat="server" Font-Names="Copperplate Gothic Bold"></asp:TextBox>
    <asp:RangeValidator ID="RangeValidator1" runat="server" 
        ControlToValidate="txtAGE" ErrorMessage="Age In Bwt  18-60" MaximumValue="60" 
        MinimumValue="18"></asp:RangeValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
        ControlToValidate="txtAGE" ErrorMessage="Please Enter The Age"></asp:RequiredFieldValidator>
</td></tr>
<tr><td>
<asp:Label ID="lblGender" runat="server" Text="Gender:" Font-Bold="True" 
                Font-Names="Copperplate Gothic Bold" Font-Size="Large" 
        ForeColor="#2B2BFF"></asp:Label></td>
<td>
<asp:DropDownList ID="ddlgender" runat="server">
 <asp:ListItem>Male</asp:ListItem>
 <asp:ListItem>Female</asp:ListItem>
</asp:DropDownList>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
        ControlToValidate="ddlgender" ErrorMessage="Plese Select Gender"></asp:RequiredFieldValidator>
</td></tr>
<tr><td>
<asp:Label ID="Label1" runat="server" Text="Mobile No:" Font-Bold="True" 
                Font-Names="Copperplate Gothic Bold" Font-Size="Large" 
        ForeColor="#2B2BFF"></asp:Label></td>
<td>
<asp:TextBox ID="txtNumber" runat="server" Font-Names="Copperplate Gothic Bold"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
        ControlToValidate="txtNumber" ErrorMessage="Please Enter the Mobail No"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
        ControlToValidate="txtNumber" 
        ErrorMessage="RegularExpressiAPlease Enter Valid Mob No " 
        ValidationExpression="[0-9]{10}"></asp:RegularExpressionValidator>
</td></tr>
<tr><td>
<asp:Label ID="lblEmailID" runat="server" Text="Email-ID:" Font-Bold="True" 
                Font-Names="Copperplate Gothic Bold" Font-Size="Large" 
        ForeColor="#2B2BFF"></asp:Label></td>
<td>
<asp:TextBox ID="txtEmail" runat="server" Font-Names="Copperplate Gothic Bold"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
        ControlToValidate="txtEmail" ErrorMessage="Please Enter Valid Email ID" 
        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
        ControlToValidate="txtEmail" ErrorMessage="Please Enter Email Id"></asp:RequiredFieldValidator>
</td></tr>
<tr><td>
<asp:Label ID="lblUsername" runat="server" Text="Username:" Font-Bold="True" 
                Font-Names="Copperplate Gothic Bold" Font-Size="Large" 
        ForeColor="#2B2BFF"></asp:Label></td>
<td>
<asp:TextBox ID="txtUsername" runat="server" Font-Names="Copperplate Gothic Bold"></asp:TextBox>
<asp:Label ID="lblchekuser" runat="server" Visible="False"></asp:Label>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
        ControlToValidate="txtUsername" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
</td></tr>
<tr><td>
<asp:Label ID="lblPassword" runat="server" Text="Password:" Font-Bold="True" 
                Font-Names="Copperplate Gothic Bold" Font-Size="Large" 
        ForeColor="#2B2BFF"></asp:Label></td>
<td>
<asp:TextBox ID="txtPassword" runat="server" Font-Names="Copperplate Gothic Bold" 
        TextMode="Password"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
        ControlToValidate="txtPassword" ErrorMessage="Please enter the Password"></asp:RequiredFieldValidator>
</td></tr>
<tr><td>
<asp:Label ID="lblConfirmPassword" runat="server" Text="Confirm Password:" Font-Bold="True" 
                Font-Names="Copperplate Gothic Bold" Font-Size="Large" 
        ForeColor="#2B2BFF"></asp:Label></td>
<td>
<asp:TextBox ID="txtConfirmPassword" runat="server" 
        Font-Names="Copperplate Gothic Bold" TextMode="Password"></asp:TextBox>
    <asp:CompareValidator ID="CompareValidator1" runat="server" 
        ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" 
        ErrorMessage="Password Does Not Match"></asp:CompareValidator>
</td></tr>
<tr><td></td>
<td><br /></td></tr>
<tr><td>
<asp:Button ID="btnSubmit" runat="server" Text="Submit" Font-Bold="True" Font-Names="Century Schoolbook" 
                Font-Size="Large" onclick="btnSubmit_Click1"></asp:Button></td>
<td>
<asp:Button ID="btnReset" runat="server" Text="Reset" Font-Bold="True" 
                Font-Names="Century Schoolbook" Font-Size="Large"></asp:Button>
</td></tr>
</table>
<br /><br />
</center>
</div></center>
</asp:Content>

