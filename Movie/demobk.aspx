<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.master" AutoEventWireup="true" CodeFile="demobk.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="height: 370px; width: 948px; margin-top: 20px;">
<div style="height: 403px; width: 948px; margin-top: 0px; background-image: url('layout/images/ima.png');">
<center>
<form method="post" action="">

<table align="center">
<tr>
<th colspan="2" style="height: 42px; font-size: 19px; color: #9999FF;" 
        align="center"><b> Welcome TO The Tickit BooKing Counter</b></th>
</tr>
<tr><td style="width: 186px; height: 47px;">
     <asp:RadioButtonList ID="rblMovies" runat="server" Height="16px" 
         Width="172px" AutoPostBack="True" 
         onselectedindexchanged="RadioButtonList1_SelectedIndexChanged" 
         Font-Bold="True" Font-Size="10pt" ForeColor="White">
         <asp:ListItem Value="0">Bollywood Movies</asp:ListItem>
         <asp:ListItem Value="1">Hollywood Movies</asp:ListItem>
         <asp:ListItem Value="2">Tamil movies</asp:ListItem>
     </asp:RadioButtonList><br />
     </td>
    <td style="height: 47px; width: 295px;"><br />
    <asp:DropDownList ID="ddlBollywood" runat="server" Visible="False" 
            ForeColor="#530000">
        <asp:ListItem>Please Select Bollywood Movie</asp:ListItem>
        <asp:ListItem>Airlift Teaser</asp:ListItem>
        <asp:ListItem>Bajirao Mastani</asp:ListItem>
        <asp:ListItem>Dilwale</asp:ListItem>      
    </asp:DropDownList><br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="ddlHollywood" runat="server" Visible="False" Height="19px" 
            ForeColor="#530000">
        <asp:ListItem>Please Select Hollywood Movie</asp:ListItem>
        <asp:ListItem>2012</asp:ListItem>
        <asp:ListItem>Captain America 3</asp:ListItem>
        <asp:ListItem>Independence Day 2</asp:ListItem>
        </asp:DropDownList>      
        <asp:Label ID="Label7" runat="server" Text="Label" Visible="False"></asp:Label><br />
    <asp:DropDownList ID="ddlTollywood" runat="server" Visible="False" Width="209px" 
            style="margin-bottom: 0px" ForeColor="#530000">
        <asp:ListItem>Please Select Tamil Movie</asp:ListItem>
        <asp:ListItem>Miruthan</asp:ListItem>
        <asp:ListItem>Selvandhan</asp:ListItem>
        <asp:ListItem>KABALI</asp:ListItem>      
    </asp:DropDownList><br />
    </td>
</tr>

<tr>
    <td style="height: 38px; width: 186px;">
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="10pt" 
            Text="Please Select Date:" ForeColor="White"></asp:Label>
    </td>
    <td style="height: 38px; width: 295px;">
    <asp:DropDownList ID="ddlDate" runat="server" Height="25px" Width="218px" 
            ForeColor="#530000" >
        <asp:ListItem>Please Select Date</asp:ListItem>
        <asp:ListItem>21-03-16</asp:ListItem>
        <asp:ListItem>22-03-16</asp:ListItem>
    </asp:DropDownList>
    </td>
</tr>

<tr>
    <td style="width: 186px; height: 32px;">
    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="10pt" 
            Text="Please Select Show Time:" ForeColor="White"></asp:Label>
    </td>
    <td style="height: 32px; width: 295px;">
    <asp:DropDownList ID="dddlTime" runat="server" Height="24px" Width="218px" 
            ForeColor="#530000" >
    <asp:ListItem>select your show time</asp:ListItem>
        <asp:ListItem>12:00 to2:45</asp:ListItem>
        <asp:ListItem>3:00 to 5:45</asp:ListItem>
        <asp:ListItem>6:00 to 8:45</asp:ListItem>
        <asp:ListItem>9:00 to 11:45</asp:ListItem>
    </asp:DropDownList>
    </td>
</tr>           
<tr>
    <td colspan="2">
    <center>
    <asp:Button ID="Button1" runat="server" Text="Proceed" onclick="Button1_Click" 
            Font-Bold="True" Width="85px" Font-Size="10pt" ForeColor="#530000" />
    <asp:Button ID="btnNext" runat="server" Text="Cancel" onclick="Button1_Click" 
            Font-Bold="True" Width="85px" Font-Size="10pt" ForeColor="#530000" />
    </center>
    </td>
</tr>
</table>
</form>
</center>
</div>
</div>               
</asp:Content>

