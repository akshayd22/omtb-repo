<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.master" AutoEventWireup="true" CodeFile="Combo menu.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style="width: 966px; height: 437px">
<center>

<br />
<br />
<div       
        style="border: thin ridge #ea7e15; z-index: 104; background-image: url('layout/images/combo%20menu/6.jpg'); background-repeat: inherit;
                left: 65px; width: 871px; position: absolute; top: 39px; height: 413px; color: #ea7e15;">
                &nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                
                <asp:Image ID="Image2" runat="server" Height="104px" ImageUrl="layout/images/combo%20menu/dairy_milk_bars.png"
                    Style="left: 80px; position: absolute; top: 16px; width: 124px;" />
                &nbsp;
                <asp:Image ID="Image7" runat="server" Height="136px" ImageUrl="layout/images/combo%20menu/pizza_2.png"
                    Style="left: 286px; position: absolute; top: -14px; width: 162px;" />
                <asp:Image ID="Image12" runat="server" Height="72px" ImageUrl="layout/images/combo%20menu/born wille red.png"
                    Style="left: 56px; position: absolute; top: 56px; width: 86px;" />
                <asp:Image ID="Image13" runat="server" Height="64px" ImageUrl="layout/images/combo%20menu/kitkat-chocolate.png"
                    Style="left: 72px; position: absolute; top: 8px; width: 86px;" />
                &nbsp;&nbsp;
                <asp:Image ID="Image14" runat="server" Height="88px" ImageUrl="layout/images/combo%20menu/FP.Chocolate.png"
                    Style="left: 622px; position: absolute; top: 24px; width: 132px;" />
                <asp:Image ID="Image11" runat="server" Height="88px" ImageUrl="layout/images/combo%20menu/LAYS_Classic.png"
                    Style="left: 431px; position: absolute; top: 16px; width: 108px;" />
                <asp:Image ID="Image8" runat="server" Height="104px" ImageUrl="layout/images/combo%20menu/coca cola.png"
                    Style="left: 480px; position: absolute; top: 8px; width: 113px;" />
                <asp:Image ID="Image15" runat="server" Height="104px" ImageUrl="layout/images/combo%20menu/popcorn(2).png"
                    Style="left: 546px; position: absolute; top: 0px; width: 126px;" />
                <asp:Image ID="Image9" runat="server" Height="80px" ImageUrl="layout/images/combo%20menu/burger22.png"
                    Style="left: 197px; position: absolute; top: 24px; width: 106px;" />
<br />
<br />
<div>    
                <table style="width: 78%">
                    <tr>
                        <td style="width: 173px; height: 51px;">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Style="font-size: 13pt;
                    font-family: Cambria; height: 20px; width: 117px;"
                    Text="Select Item" ForeColor="White"></asp:Label>
                            </td>
                        <td style="height: 51px; width: 155px;" colspan="2">
                        <center style="width: 454px">
    <asp:DropDownList ID="ddlSelectItem" runat="server" Height="23px" Width="181px" 
                                onselectedindexchanged="ddlSelectItem_SelectedIndexChanged">
    <asp:ListItem>Select Items</asp:ListItem>
                    <asp:ListItem Value="60.00">PopCorn Rs.60.00</asp:ListItem>
                    <asp:ListItem Value="50.00">Chips Rs.50.00</asp:ListItem>
                    <asp:ListItem Value="30.00">Cock Rs.30.00</asp:ListItem>
                    <asp:ListItem Value="85.00">PopCorn + Cock Rs.85.00</asp:ListItem>
                    <asp:ListItem Value="75.00">Chips + Cock Rs.75.00</asp:ListItem>
                    
    </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                ControlToValidate="ddlSelectItem" ErrorMessage="Please Select Item"></asp:RequiredFieldValidator>
    </center>
                        </td>
                        <td style="height: 51px">
                        
                            &nbsp;</td>
</tr>
<tr>
                        <td style="width: 173px; height: 51px;">
                         <asp:Label ID="Label2" runat="server" Font-Bold="True" Style="font-size: 13pt;
                    font-family: Cambria; height: 20px; width: 117px;"
                    Text="Select Quantity" ForeColor="White"></asp:Label>

                            </td>
                        <td style="width: 155px; height: 51px;" colspan="2">
                        <center style="width: 452px">
    <asp:DropDownList ID="ddlSelectQuantity" runat="server" Height="23px" 
        Width="177px" onselectedindexchanged="ddlSelectQuantity_SelectedIndexChanged">
         <asp:ListItem>Select Qauntity</asp:ListItem>
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
    </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                ControlToValidate="ddlSelectQuantity" ErrorMessage="Please Select Quantity"></asp:RequiredFieldValidator>
     </center>
                        </td>
                        <td rowspan="2">
                        
                            <br />
                            <br />
                        
                        </td>
 </tr>
 <tr>
                   
                        <td style="width: 173px; height: 43px;">
                          <asp:Label ID="Label3" runat="server" Font-Bold="True" Style="font-size: 13pt;
                    font-family: Cambria;height: 26px; width: 159px;"
                    Text="Mode Of Delivery" ForeColor="White"></asp:Label>
                    </td>
                        
<td style="height: 43px; width: 155px;" colspan="2">
<center style="width: 452px">
    <asp:DropDownList ID="ddlMOD" runat="server" Height="23px" Width="183px">
    <asp:ListItem>Select Mode of Delivery</asp:ListItem>
    <asp:ListItem>Start Of Movie - On Seat</asp:ListItem>
    <asp:ListItem>Start Of Movie - On Counter</asp:ListItem>
    <asp:ListItem> Interval - On Seat</asp:ListItem>
    <asp:ListItem>Interval - On Counter</asp:ListItem>
    </asp:DropDownList>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
        ControlToValidate="ddlMOD" ErrorMessage="Please Select MOD"></asp:RequiredFieldValidator>
    </center>
</td>
</tr>
                    <tr>
                        <td style="width: 173px">
    <asp:Button ID="Button1" runat="server" Text="Ok" Height="29px" 
        Width="69px" Font-Bold="True" Font-Size="13pt" onclick="Button1_Click" />
                        </td>
                        <td style="width: 155px">
         <asp:Button ID="Button2" runat="server" Text="Cancel" Height="29px" 
        Width="69px" Font-Bold="True" Font-Size="13pt" onclick="Button2_Click" />

                        </td>
                        <td>
                        
                            <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="11pt" 
                                ForeColor="Black" Text="total Amt: Rs."></asp:Label>
&nbsp;
                            <asp:Label ID="lbltamt" runat="server" Font-Bold="True" Font-Size="12pt" 
                                ForeColor="Black"></asp:Label>
&nbsp;<asp:Button ID="btmProceed" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="White" 
                                Text="Proceed" Visible="False" BackColor="#FF3300" 
                                onclick="btmProceed_Click" />
                        
                        </td>
                    </tr>
                </table>
                </div>
                <br /><br />
                <br />
                <br />
                <br />
                <br />

    
</div>
</center>
<br /><br /><br />


</div>
</asp:Content>

