<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.master" AutoEventWireup="true" CodeFile="Contact us.aspx.cs" Inherits="Default4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
<div>
    <asp:Image ID="imgContactUs" runat="server" 
        ImageUrl="~/layout/images/contact_us.jpg" Width="847px" />
</div>
    <center>
    <table style="width: 51%; margin-right: 0px; height: 264px;" border="3">
        <tr>
            <td colspan="2" style="height: 27px">
               <center><asp:Label ID="Label1" runat="server" Font-Bold="True" 
                    Font-Names="Copperplate Gothic Bold" Font-Size="15pt" ForeColor="#0000CC" 
                    Text="Contact Us"></asp:Label><br />
                    <asp:Label ID="Label6" runat="server"></asp:Label>

                    </center> 
            </td>
        </tr>
        <tr>
            <td style="width: 244px">
                <asp:Label ID="Label2" runat="server" Font-Bold="True" 
                    Font-Names="Copperplate Gothic Bold" Font-Size="13pt" ForeColor="Black" 
                    Text="Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtName" runat="server" Font-Names="Copperplate Gothic Light" 
                    Font-Size="13pt" ForeColor="Black"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 244px">
                <asp:Label ID="Label3" runat="server" Font-Bold="True" 
                    Font-Names="Copperplate Gothic Bold" Font-Size="13pt" ForeColor="Black" 
                    Text="Email ID"></asp:Label>
&nbsp;</td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server" Font-Names="Times New Roman" 
                    Font-Size="13pt" ForeColor="Black" Width="184px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 244px">
                <asp:Label ID="Label4" runat="server" Font-Bold="True" 
                    Font-Names="Copperplate Gothic Bold" Font-Size="13pt" ForeColor="Black" 
                    Text="Subject"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtSubject" runat="server" 
                    Font-Names="Copperplate Gothic Light" Font-Size="13pt" ForeColor="Black"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 244px">
                <asp:Label ID="Label5" runat="server" Font-Bold="True" 
                    Font-Names="Copperplate Gothic Bold" Font-Size="13pt" ForeColor="Black" 
                    Text="Comment"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtComment" runat="server" 
                    Font-Names="Copperplate Gothic Light" Font-Size="13pt" ForeColor="Black" 
                    TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="Button1" runat="server" Font-Bold="True" 
                    Font-Names="Copperplate Gothic Light" Font-Size="13pt" ForeColor="Black" 
                    Text="Submit" onclick="Button1_Click" />
            </td>
        </tr>
    </table>
    </center>
    </div>
</asp:Content>

