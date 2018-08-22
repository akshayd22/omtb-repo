<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.master" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="HomePage" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<table>
<tr>
<td style="width: 321px">
<div id="slider">
<figure>
<asp:ImageButton ID="ImageButton9" runat="server" Height="450px" Width="794px" 
        ImageUrl="images1/x-men.jpg" onclick="ImageButton9_Click"></asp:ImageButton>
<asp:ImageButton ID="ImageButton10" runat="server" Height="450px" Width="795px" 
        ImageUrl="~/images1/harculis.jpg" onclick="ImageButton9_Click"></asp:ImageButton>
<asp:ImageButton ID="ImageButton11" runat="server" Height="450px" Width="794px" 
        ImageUrl="~/images1/Godzilla.jpg" onclick="ImageButton9_Click"></asp:ImageButton>
<asp:ImageButton ID="ImageButton12" runat="server" Height="450px" Width="795px" 
        ImageUrl="images1/the%20maize%20runner.jpg" onclick="ImageButton9_Click"></asp:ImageButton>
<asp:ImageButton ID="ImageButton13" runat="server" Height="450px" Width="796px" 
        ImageUrl="images1/Turbo.jpg" onclick="ImageButton9_Click"></asp:ImageButton>
</figure>
</div>
</td>
<td style="width: 141px" "Padding: 7px">
    <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="xmlAds/Advrt.xml" 
        target="_self" Height="150px" Width="182px"/><br /><br />
    <asp:AdRotator ID="AdRotator2" runat="server" AdvertisementFile="xmlAds/Advrt1..xml"
        target="_self" Height="150px" Width="182px"/><br /><br />
    <asp:AdRotator ID="AdRotator3" runat="server" AdvertisementFile="xmlAds/Advrt.xml" 
        target="_self" Height="150px" Width="182px"/><br /><br />   
</td>
</tr>
</table>
<div style="height: 709px; width: 941px;">
<table>
<tr>
    <td style="width: 231px">
    <asp:ImageButton ID="ImageButton1" runat="server" Height="150px" Width="200px" 
            ImageUrl="~/advrt/Guardians1.jpg" onclick="ImageButton1_Click"></asp:ImageButton>
    </td>
    <td style="width: 488px">
    Movie Name: Guardians
    <br />Director:
    <br />Actors:
    <br />Movie Type:Hollywood
    <br />Description:
    </td>  
    <td style="width: 295px">
    <asp:ImageButton ID="ImageButton2" runat="server" Height="150px" Width="200px" 
            ImageUrl="~/advrt/Phantom1.png" onclick="ImageButton1_Click"></asp:ImageButton>
    </td>
    <td style="width: 448px">
    Movie Name: Phantom
    <br />Director:
    <br />Actors:
    <br />Movie Type:Bollywood
        (Action)<br />Description:
    </td>
</tr>
<tr>
    <td style="width: 231px">
    <asp:ImageButton ID="ImageButton3" runat="server" Height="150px" Width="200px" 
            ImageUrl="advrt/rio1.jpg" onclick="ImageButton1_Click"></asp:ImageButton>
    </td>
    <td style="width: 488px">
    Movie Name: Rio2
    <br />Director:
    <br />Actors:
    <br />Movie Type:Hollywood
    <br />Description:
    </td>

    <td style="width: 295px">
    <asp:ImageButton ID="ImageButton4" runat="server" Height="150px" Width="200px" 
            ImageUrl="advrt/tees-maar-khan1.png" onclick="ImageButton1_Click"></asp:ImageButton>
    </td>
    <td style="width: 448px">
    Movie Name: Tees Maar Khan
    <br />Director:
    <br />Actors:
    <br />Movie Type:Bollywood
        (Comedi)<br />Description:
    </td>
</tr>
<tr>
    <td style="width: 231px">
    <asp:ImageButton ID="ImageButton5" runat="server" Height="150px" Width="200px" 
            ImageUrl="advrt/titanic-1.jpg" onclick="ImageButton1_Click"></asp:ImageButton>
    </td>
    <td style="width: 488px">
    Movie Name: Titanic
    <br />Director:
    <br />Actors:
    <br />Movie Type:Hollywood
    <br />Description:
    </td>
     <td style="width: 295px">
     <asp:ImageButton ID="ImageButton6" runat="server" Height="150px" Width="200px" 
            ImageUrl="advrt/players1.png" onclick="ImageButton1_Click"></asp:ImageButton>
   </td>
    <td style="width: 448px">
    Movie Name: Players
    <br />Director:
    <br />Actors:
    <br />Movie Type:Bollywood
    <br />Description:
    </td>
</tr>
<tr>
    <td style="width: 231px">
    <asp:ImageButton ID="ImageButton7" runat="server" Height="150px" Width="200px" 
            ImageUrl="advrt/resident_evil_afterlife1.jpg" onclick="ImageButton1_Click"></asp:ImageButton>
    </td>
    <td style="width: 488px">
    Movie Name: advrt/Resident Evil Afterlife
    <br />Director:
    <br />Actors:
    <br />Movie Type:Hollywood
    <br />Description:
    </td>
     <td style="width: 295px">
     <asp:ImageButton ID="ImageButton8" runat="server" Height="150px" Width="200px" 
            ImageUrl="advrt/wlcom2karachi1.jpg" onclick="ImageButton1_Click"></asp:ImageButton>
    </td>
    <td style="width: 448px">
    Movie Name: advrt/Welcome 2 Karachi        
    <br />Director:
    <br />Actors:
    <br />Movie Type:Bollywood
    <br />Description:
    </td>
</tr>
</table>
</div>
</asp:Content>


