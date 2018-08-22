<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.master" AutoEventWireup="true" CodeFile="Bill.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
    <div align="left" dir="rtl" 
        
        
        style="background-position: left top; border-top-width: thin; background-image: url('seats/sprite_x.png'); background-repeat: repeat-x; height: 36px; background-color: #FFFF00; margin-right: 54px;">
    </div>
    <br /><br />
    <div style="border: medium outset #0033CC; height: 516px;">
      
            <div style="width: 389px; height: 403px;" align="left">
            <asp:Panel ID="panelAll" runat="server" Height="413px" Visible="False" 
                    Width="382px">
                <table align="left" font-bold="true">
                <tr>
                    <td style="height: 37px; width: 170px;">
                        <asp:Label ID="lblpyement" runat="server" Text="PayMent Option..." 
                            Font-Bold="True" Font-Names="Juice ITC" Font-Size="22pt" 
                            ForeColor="#491831"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="height: 70px; width: 170px;">
                        <asp:RadioButtonList ID="rblPayment" runat="server" AutoPostBack="True" 
                            Font-Bold="True" Font-Names="Times New Roman" Font-Size="14pt" Height="16px" 
                            onselectedindexchanged="rblPayment_SelectedIndexChanged" Width="155px" 
                            ForeColor="#530000">
                            <asp:ListItem>Credit Card</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                
                
                <tr>
                    <asp:Panel ID="PanelCreditCard" runat="server" Enabled="False" Height="16px" 
                        Width="849px" >
                    <td style="width: 234px">
                        <table style="background-image: url('layout/images/tbbg.jpg')" >
                            <tr>
                                <td colspan="2">
                                    <asp:Label ID="Label2" runat="server" Text="Enter Your Card Details" Font-Bold="True" Font-Names="Times New Roman" Font-Size="12pt"></asp:Label>
                                </td>
                             </tr>
                            <tr>
                                <td colspan="2">
                                    <asp:Label ID="lblCardNo" runat="server" Text="Card Number" Font-Bold="True" Font-Names="Times New Roman" Font-Size="12pt"></asp:Label><br />
                                    <asp:TextBox ID="txtCardNo" runat="server" Width="105px"></asp:TextBox><br /><br /><br />
                                    <asp:Label ID="lblNOC" runat="server" Text="Name On The Card" Font-Bold="True" Font-Names="Times New Roman" Font-Size="12pt"></asp:Label><br />
                                    <asp:TextBox ID="txtNameOnTheCard" runat="server" Width="93px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                <asp:Label ID="lblExpiry" runat="server" Text="Expiry" Font-Bold="True" Font-Names="Times New Roman" Font-Size="12pt"></asp:Label><br />
                                <asp:TextBox ID="TextBox2" runat="server" Width="80px"></asp:TextBox>
                                </td>
                                <td>
                                <asp:Label ID="lblCity" runat="server" Text="City" Font-Bold="True" Font-Names="Times New Roman" Font-Size="12pt"></asp:Label><br />
                                <asp:DropDownList ID="ddlCity" runat="server">
                                    <asp:ListItem Value="0">Select City</asp:ListItem>
                                    <asp:ListItem>Mumbai</asp:ListItem>
                                    <asp:ListItem>Pune</asp:ListItem>
                                    <asp:ListItem>Delhi</asp:ListItem>
                                    <asp:ListItem>Ahamdabad</asp:ListItem>
                                    <asp:ListItem>Surat</asp:ListItem>
                                    <asp:ListItem>Nagpur</asp:ListItem>
                                    <asp:ListItem>Agra</asp:ListItem>
                                    <asp:ListItem>Goa</asp:ListItem>
                                    <asp:ListItem>Kolkata</asp:ListItem>
                                    <asp:ListItem>Amritsar</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                        </table>
                        <br />
                        <asp:Button ID="btnCreditMakePayment" runat="server" Text="Make Payment" 
                            Font-Size="14pt" Font-Bold="True" BackColor="#FF6464" 
                            Font-Names="Times New Roman" Height="32px" Width="134px" OnClick="btnCreditMakePayment_Click"></asp:Button>
                    </td>
                    </asp:Panel>

                   
                </tr>
                </table><br /><br />
                </asp:Panel>

               </div><br /><br />

              
                <table border="2" align="right" font-bold="False" 
                    style="right: 68px; position: absolute; width: 447px; height: 387px;">
                    <tr>
                        <td colspan="2" style="height: 15px"><center>
                            <asp:Label ID="lblheading" runat="server" Text="Booking Summary..." 
                                Font-Size="22pt" Font-Bold="True" Font-Names="Juice ITC" ForeColor="#491831"></asp:Label>
                        </center><br />
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 136px">
                        <asp:Label ID="lblMovieName" runat="server" Text="Movie Name:" Font-Bold="True" 
                                Font-Size="12pt" Font-Names="Times New Roman" ForeColor="#640032"></asp:Label>
                        </td>
                        <td style="width: 141px">
                            <asp:TextBox ID="txtMovieName" runat="server" Font-Bold="True" Enabled="False"></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td style="width: 136px">
                        <asp:Label ID="lbldateTime" runat="server" Text="Date & Time:" Font-Size="12pt" 
                                Font-Bold="True" Font-Names="Times New Roman" ForeColor="#640032"></asp:Label>                           
                        </td>
                        <td style="width: 141px">
                            &nbsp;<asp:Label ID="lblDate" runat="server" Font-Bold="True"></asp:Label>
&nbsp;
                            <asp:Label ID="lblShwTime" runat="server" Font-Bold="True"></asp:Label>
                        </td>
                    </tr>

                    <tr>
                        <td style="width: 136px">
                            <asp:Label ID="lblT_Name" runat="server" Text="Thetor Name:" Font-Bold="True" 
                                Font-Size="12pt" Font-Names="Times New Roman" ForeColor="#640032"></asp:Label>
                        </td>
                        <td style="width: 141px">
                            <asp:Label ID="lblThetorName" runat="server" Font-Bold="True" Font-Size="13pt" 
                                Text="AKTheathor"></asp:Label>
                        </td>
                    </tr>

                    <tr>
                        <td style="width: 136px; height: 29px;">
                            <asp:Label ID="lblClass" runat="server"></asp:Label>
                        </td>
                        <td style="width: 141px; height: 29px;">
                                                    </td>
                    </tr>

                    <tr>
                    <td>
                            <asp:Label ID="ibiSubTotal" runat="server" Text="Seat Amt:" Font-Size="12pt" 
                                Font-Bold="True" Font-Names="Trebuchet MS" ForeColor="#640032"></asp:Label>
                           
                    </td>
                    <td>
                                <asp:TextBox ID="txtSubTotal" runat="server" Font-Bold="True" 
                            Width="79px" Enabled="False"></asp:TextBox>
                                <asp:Label ID="lblx" runat="server" Font-Bold="True" Font-Size="13pt" Text="Rs"></asp:Label>
                    </td>
                    </tr>

                    <tr>
                        <td style="width: 136px">
                    <asp:Label ID="lblAddonPrice" runat="server" Text="Addon Price" Font-Bold="True" 
                                Font-Size="12pt" Font-Names="Times New Roman" ForeColor="#640032"></asp:Label>
                           
                        </td>
                        <td style="width: 141px">
                    <asp:TextBox ID="txtAddonPrice" runat="server" Font-Bold="True" Width="78px" 
                                Enabled="False"></asp:TextBox>
                            <asp:Label ID="lbly" runat="server" Font-Bold="True" Font-Size="13pt" Text="Rs"></asp:Label>
                        </td>
                        </tr>

                    <tr>
                        <td style="width: 136px">
                            <asp:Label ID="lblIHF" runat="server" Text="Internet Handling Fees:" 
                                Font-Size="12pt" Font-Bold="True" Font-Names="Times New Roman" 
                                ForeColor="#640032"></asp:Label>
                           
                            </td>
                            <td style="width: 141px">
                                <asp:Label ID="lblInternetHF" runat="server" Font-Bold="True" Font-Size="13pt" 
                                    Text="30 Rs."></asp:Label>
                            </td>
                        </tr>

                    <tr>
                            <td style="width: 136px">
                                <asp:Label ID="lblAmtPy" runat="server" Text="Total Amount:" Font-Size="12pt" 
                                    Font-Bold="True" Font-Names="Times New Roman" ForeColor="#640032"></asp:Label>
                            </td>
                            <td style="width: 141px">
                                <asp:Label ID="lblTotalAmt" runat="server" Font-Bold="True" Font-Size="13pt"></asp:Label>
                                <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="13pt" 
                                    Text="Rs"></asp:Label>
                            </td>
                        </tr>

                    <tr>
                        <td style="width: 136px">
                            <asp:Label ID="lblTotalRs" runat="server" Text="Amount Payble:" Font-Size="12pt" 
                                Font-Bold="True" Font-Names="Times New Roman" ForeColor="#640032"></asp:Label>
                            &nbsp;&nbsp;
                            <asp:Label ID="lblAmtPyble" runat="server" Font-Bold="True" Font-Size="13pt"></asp:Label>
                            <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="13pt" 
                                Text="Rs."></asp:Label>
                        </td>
                        <td style="width: 141px">
                            <asp:Button ID="btnBillproceed" runat="server" Text="Proceed" ForeColor="Black" 
                                 BackColor="#FF1515" Height="30px" style="margin-right: 5px" Width="73px" 
                                 Font-Bold="True" Font-Size="13pt" Font-Names="Times New Roman" 
                                onclick="btnBillproceed_Click" />
                            <asp:Button ID="btnCancel" runat="server" BackColor="#FF1515" Font-Bold="True" 
                                Font-Names="Times New Roman" Font-Size="13pt" Text="Cancel" Width="59px" />
                        </td>
                    </tr>
              </table>
               

    </div>
</div>
</asp:Content>

