<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.master" AutoEventWireup="true" CodeFile="SeatMap.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
    <br />
    <br />
    <center style="height: 35px"><asp:Label ID="Label1" runat="server" 
            Text="Select Your Favourite Seat Over Here..." Enabled="False" 
            ForeColor="#0033CC" Font-Bold="True" Font-Names="Juice ITC" Font-Size="30pt"></asp:Label></center>
<br />
    <div>
        <table align="right">
            <tr>
                <td style="width: 124px">
                <asp:Label ID="Label4" runat="server" Text="No Of Seats:" Font-Bold="True" 
                        Font-Size="12pt" ForeColor="#990000"></asp:Label>
                </td>
                <td>
                &nbsp;
                    <asp:Label ID="lblTNS" runat="server" Font-Bold="True" Font-Size="10pt"></asp:Label>
&nbsp;
                </td>
            </tr>
            <tr>
                <td style="width: 124px">
                <asp:Label ID="Label5" runat="server" Text="Price:" Font-Bold="True" 
                        Font-Size="12pt" ForeColor="#990000"></asp:Label>
                </td>
                <td>
                <asp:Label ID="lblg" runat="server" Font-Bold="True" Font-Size="10pt"></asp:Label>
                <asp:Label ID="lbls" runat="server" Font-Bold="True" Font-Size="10pt"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="height: 32px; width: 124px;">
                <asp:Label ID="Label6" runat="server" Text="Total:" Font-Bold="True" 
                        Font-Size="12pt" ForeColor="#990000"></asp:Label>
                </td>
                <td style="height: 32px">
                <asp:TextBox ID="txtTotal" runat="server" Width="52px"></asp:TextBox>
                </td>
            </tr>
            <tr>
            <td colspan="2" style="height: 41px">
             <center>
                 &nbsp;<asp:Button ID="btnProceed" runat="server" Font-Bold="True" 
                     Font-Size="12pt" onclick="btnProceed_Click" Text="Proceed" Visible="False" 
                     Width="75px" />
                 &nbsp;&nbsp;
                 <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
            Text="Ok" Width="65px" Font-Bold="True" Font-Size="12pt" />&nbsp;&nbsp;
                 <asp:Button ID="btnAddon" runat="server" Font-Bold="True" Font-Size="12pt" 
                     Text="Addon" onclick="btnAddon_Click" Enabled="False" />
&nbsp;
                 <asp:Button ID="btnCancel" runat="server" Font-Bold="True" Font-Size="12pt" 
                     Text="Cancel" onclick="btnCancel_Click" />
                &nbsp;
                 <asp:Button ID="btnBack" runat="server" Font-Bold="True" Font-Size="12pt" 
                     onclick="btnBack_Click" Text="Back" Visible="False" />
                </center>
            </td>
            </tr>
        </table>
    </div>
    <br />
    <br />
    <div>
    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="12pt" 
            Text="Please Select Class:" ForeColor="#990000"></asp:Label>       
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;       
    <asp:DropDownList ID="ddlClass" runat="server" Height="25px" Width="214px" AutoPostBack="True" onselectedindexchanged="ddlClass_SelectedIndexChanged">
        <asp:ListItem>Please Select Your Class : </asp:ListItem>
        <asp:ListItem Value="180.00">Gold Class</asp:ListItem>
        <asp:ListItem Value="120.00">Silver Class</asp:ListItem>
    </asp:DropDownList><br />
   
    </div>
<br />
<center style="margin-top: 0px">
    <asp:Panel ID="panelGC" runat="server" Enabled="False" Width="703px" 
        style="margin-top: 17px" Height="350px">
        <table>
            <tr>
                <td colspan="14">
                    <center><strong><span style="font-size: 16pt; font-family: Lucida Handwriting">GOLD CLASS
                    
                    </span></strong></center><br />
                </td>
            </tr>
            <tr>
                <td style="width: 11px; height: 17px">
                    <asp:CheckBox ID="C1" runat="server" Font-Names="Times New Roman" Text="A1" 
                        oncheckedchanged="C1_CheckedChanged" Font-Bold="True" ForeColor="#333300" /></td>
                <td style="width: 20px; height: 17px">
                    <asp:CheckBox ID="C2" runat="server" Text="A2" oncheckedchanged="C2_CheckedChanged" Font-Bold="True" ForeColor="#333300"/></td>
                <td style="height: 30px; width: 5px;">
                    <asp:CheckBox ID="C3" runat="server" Text="A3" oncheckedchanged="C3_CheckedChanged" Font-Bold="True" ForeColor="#333300"/></td>
                <td style="width: 4px; height: 30px">
                    <asp:CheckBox ID="C4" runat="server" Text="A4" Font-Bold="True" 
                        ForeColor="#333300" oncheckedchanged="C4_CheckedChanged"/></td>
                <td rowspan="6" style="width: 30px;" bgcolor= "#FF9900"></td>
                <td style="width: 21px; height: 30px">
                     <asp:CheckBox ID="C5" runat="server" Text="A5" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C5_CheckedChanged"/></td>
                <td style="width: 20px; height: 30px">
                     <asp:CheckBox ID="C6" runat="server" Text="A6" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C6_CheckedChanged"/></td>
                <td style="height: 30px; width: 21px;">
                     <asp:CheckBox ID="C7" runat="server" Text="A7" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C7_CheckedChanged"/></td>
                <td style="width: 20px; height: 30px">
                     <asp:CheckBox ID="C8" runat="server" Text="A8" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C8_CheckedChanged"/></td>
                <td rowspan="6" style="width: 30px;" bgcolor= "#FF9900"></td>
                <td style="width: 20px; height: 30px">
                     <asp:CheckBox ID="C9" runat="server" Text="A9" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C9_CheckedChanged"/></td>
                <td style="width: 20px; height: 30px">
                     <asp:CheckBox ID="C10" runat="server" Text="A10" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C10_CheckedChanged"/></td>
                <td style="width: 20px; height: 30px">
                     <asp:CheckBox ID="C11" runat="server" Text="A11" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C11_CheckedChanged"/></td>
                <td style="height: 30px; width: 20px;">
                     <asp:CheckBox ID="C12" runat="server" Text="A12" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C12_CheckedChanged"/></td>
           </tr>
            <tr>
                 <td style="width: 11px; height: 30px">
                      <asp:CheckBox ID="C13" runat="server" Text="B1" Font-Bold="True" 
                          ForeColor="#333300" oncheckedchanged="C13_CheckedChanged"/></td>
                 <td style="width: 20px; height: 30px">
                      <asp:CheckBox ID="C14" runat="server" Text="B2" Font-Bold="True" 
                          ForeColor="#333300" oncheckedchanged="C14_CheckedChanged"/></td>
                 <td style="height: 30px; width: 5px;">
                      <asp:CheckBox ID="C15" runat="server" Text="B3" Font-Bold="True" 
                          ForeColor="#333300" oncheckedchanged="C15_CheckedChanged"/></td>
                 <td style="width: 4px; height: 30px">
                      <asp:CheckBox ID="C16" runat="server" Text="B4" Font-Bold="True" 
                          ForeColor="#333300" oncheckedchanged="C16_CheckedChanged"/></td>
                 <td style="width: 21px; height: 30px">
                      <asp:CheckBox ID="C17" runat="server" Text="B5" Font-Bold="True" 
                          ForeColor="#333300" oncheckedchanged="C17_CheckedChanged"/></td>
                 <td style="width: 20px; height: 30px">
                      <asp:CheckBox ID="C18" runat="server" Text="B6" Font-Bold="True" 
                          ForeColor="#333300" oncheckedchanged="C18_CheckedChanged"/></td>
                 <td style="height: 30px; width: 21px;">
                      <asp:CheckBox ID="C19" runat="server" Text="B7" Font-Bold="True" 
                          ForeColor="#333300" oncheckedchanged="C19_CheckedChanged"/></td>
                 <td style="width: 20px; height: 30px">
                      <asp:CheckBox ID="C20" runat="server" Text="B8" Font-Bold="True" 
                          ForeColor="#333300" oncheckedchanged="C20_CheckedChanged"/></td>
                 <td style="width: 20px; height: 30px">
                      <asp:CheckBox ID="C21" runat="server" Text="B9" Font-Bold="True" 
                          ForeColor="#333300" oncheckedchanged="C21_CheckedChanged"/></td>
                 <td style="width: 20px; height: 30px">
                      <asp:CheckBox ID="C22" runat="server" Text="B10" Font-Bold="True" 
                          ForeColor="#333300" oncheckedchanged="C22_CheckedChanged"/></td>
                 <td style="width: 20px; height: 30px">
                      <asp:CheckBox ID="C23" runat="server" Text="B11" Font-Bold="True" 
                          ForeColor="#333300" oncheckedchanged="C23_CheckedChanged"/></td>
                 <td style="height: 30px; width: 20px;">
                      <asp:CheckBox ID="C24" runat="server" Text="B12" Font-Bold="True" 
                          ForeColor="#333300" oncheckedchanged="C24_CheckedChanged"/></td>
            </tr>
            <tr>
                 <td style="width: 11px; height: 30px">
                      <asp:CheckBox ID="C25" runat="server" Text="C1" Font-Bold="True" 
                          ForeColor="#333300" oncheckedchanged="C25_CheckedChanged"/></td>
                 <td style="width: 20px; height: 30px">
                      <asp:CheckBox ID="C26" runat="server" Text="C2" Font-Bold="True" 
                          ForeColor="#333300" oncheckedchanged="C26_CheckedChanged"/></td>
                 <td style="height: 30px; width: 5px;">
                      <asp:CheckBox ID="C27" runat="server" Text="C3" Font-Bold="True" 
                          ForeColor="#333300" oncheckedchanged="C27_CheckedChanged"/></td>
                 <td style="width: 4px; height: 30px">
                      <asp:CheckBox ID="C28" runat="server" Text="C4" Font-Bold="True" 
                          ForeColor="#333300" oncheckedchanged="C28_CheckedChanged"/></td>
                 <td style="width: 21px; height: 30px">
                      <asp:CheckBox ID="C29" runat="server" Text="C5" Font-Bold="True" 
                          ForeColor="#333300" oncheckedchanged="C29_CheckedChanged"/></td>
                 <td style="width: 20px; height: 30px">
                      <asp:CheckBox ID="C30" runat="server" Text="C6" Font-Bold="True" 
                          ForeColor="#333300" oncheckedchanged="C30_CheckedChanged"/></td>
                 <td style="height: 30px; width: 21px;">
                      <asp:CheckBox ID="C31" runat="server" Text="C7" Font-Bold="True" 
                          ForeColor="#333300" oncheckedchanged="C31_CheckedChanged"/></td>
                 <td style="width: 20px; height: 30px">
                      <asp:CheckBox ID="C32" runat="server" Text="C8" Font-Bold="True" 
                          ForeColor="#333300" oncheckedchanged="C32_CheckedChanged"/></td>
                 <td style="width: 20px; height: 30px">
                      <asp:CheckBox ID="C33" runat="server" Text="C9" Font-Bold="True" 
                          ForeColor="#333300" oncheckedchanged="C33_CheckedChanged"/></td>
                 <td style="width: 20px; height: 30px">
                      <asp:CheckBox ID="C34" runat="server" Text="C10" Font-Bold="True" 
                          ForeColor="#333300" oncheckedchanged="C34_CheckedChanged"/></td>
                 <td style="width: 20px; height: 30px">
                      <asp:CheckBox ID="C35" runat="server" Text="C11" Font-Bold="True" 
                          ForeColor="#333300" oncheckedchanged="C35_CheckedChanged"/></td>
                 <td style="height: 30px; width: 20px;">
                      <asp:CheckBox ID="C36" runat="server" Text="C12" Font-Bold="True" 
                          ForeColor="#333300" oncheckedchanged="C36_CheckedChanged"/></td>
            </tr>
            <tr>
                 <td style="width: 11px; height: 30px">
                      <asp:CheckBox ID="C37" runat="server" Text="D1" Font-Bold="True" 
                          ForeColor="#333300" oncheckedchanged="C37_CheckedChanged"/></td>
                 <td style="width: 20px; height: 30px">
                      <asp:CheckBox ID="C38" runat="server" Text="D2" Font-Bold="True" 
                          ForeColor="#333300" oncheckedchanged="C38_CheckedChanged"/></td>
                 <td style="height: 30px; width: 5px;">
                      <asp:CheckBox ID="C39" runat="server" Text="D3" Font-Bold="True" 
                          ForeColor="#333300" oncheckedchanged="C39_CheckedChanged"/></td>
                 <td style="width: 4px; height: 30px">
                      <asp:CheckBox ID="C40" runat="server" Text="D4" Font-Bold="True" 
                          ForeColor="#333300" oncheckedchanged="C40_CheckedChanged"/></td>
                 <td style="width: 21px; height: 30px">
                      <asp:CheckBox ID="C41" runat="server" Text="D5" Font-Bold="True" 
                          ForeColor="#333300" oncheckedchanged="C41_CheckedChanged"/></td>
                 <td style="width: 20px; height: 30px">
                      <asp:CheckBox ID="C42" runat="server" Text="D6" Font-Bold="True" 
                          ForeColor="#333300" oncheckedchanged="C42_CheckedChanged"/></td>
                 <td style="height: 30px; width: 21px;">
                      <asp:CheckBox ID="C43" runat="server" Text="D7" Font-Bold="True" 
                          ForeColor="#333300" oncheckedchanged="C43_CheckedChanged"/></td>
                 <td style="width: 20px; height: 30px">
                      <asp:CheckBox ID="C44" runat="server" Text="D8" Font-Bold="True" 
                          ForeColor="#333300" oncheckedchanged="C44_CheckedChanged"/></td>
                 <td style="width: 20px; height: 30px">
                      <asp:CheckBox ID="C45" runat="server" Text="D9" Font-Bold="True" 
                          ForeColor="#333300" oncheckedchanged="C45_CheckedChanged"/></td>
                 <td style="width: 20px; height: 30px">
                      <asp:CheckBox ID="C46" runat="server" Text="D10" Font-Bold="True" 
                          ForeColor="#333300" oncheckedchanged="C46_CheckedChanged"/></td>
                 <td style="width: 20px; height: 30px">
                      <asp:CheckBox ID="C47" runat="server" Text="D11" Font-Bold="True" 
                          ForeColor="#333300" oncheckedchanged="C47_CheckedChanged"/></td>
                 <td style="height: 30px; width: 20px;">
                      <asp:CheckBox ID="C48" runat="server" Text="D12" Font-Bold="True" 
                          ForeColor="#333300" oncheckedchanged="C48_CheckedChanged"/></td>
            </tr>
            <tr>
                 <td style="width: 11px; height: 30px">
                      <asp:CheckBox ID="C49" runat="server" Text="E1" Font-Bold="True" 
                          ForeColor="#333300" oncheckedchanged="C49_CheckedChanged"/></td>
                 <td style="width: 20px; height: 30px">
                      <asp:CheckBox ID="C50" runat="server" Text="E2" Font-Bold="True" 
                          ForeColor="#333300" oncheckedchanged="C50_CheckedChanged"/></td>
                 <td style="height: 30px; width: 5px;">
                      <asp:CheckBox ID="C51" runat="server" Text="E3" Font-Bold="True" 
                          ForeColor="#333300" oncheckedchanged="C51_CheckedChanged"/></td>
                 <td style="width: 4px; height: 30px">
                       <asp:CheckBox ID="C52" runat="server" Text="E4" Font-Bold="True" 
                           ForeColor="#333300" oncheckedchanged="C52_CheckedChanged"/></td>
                 <td style="width: 21px; height: 30px">
                       <asp:CheckBox ID="C53" runat="server" Text="E5" Font-Bold="True" 
                           ForeColor="#333300" oncheckedchanged="C53_CheckedChanged"/></td>
                 <td style="width: 20px; height: 30px">
                       <asp:CheckBox ID="C54" runat="server" Text="E6" Font-Bold="True" 
                           ForeColor="#333300" oncheckedchanged="C54_CheckedChanged"/></td>
                 <td style="height: 30px; width: 21px;">
                       <asp:CheckBox ID="C55" runat="server" Text="E7" Font-Bold="True" 
                           ForeColor="#333300" oncheckedchanged="C55_CheckedChanged"/></td>
                 <td style="width: 20px; height: 30px">
                       <asp:CheckBox ID="C56" runat="server" Text="E8" Font-Bold="True" 
                           ForeColor="#333300" oncheckedchanged="C56_CheckedChanged"/></td>
                 <td style="width: 20px; height: 30px">
                       <asp:CheckBox ID="C57" runat="server" Text="E9" Font-Bold="True" 
                           ForeColor="#333300" oncheckedchanged="C57_CheckedChanged"/></td>
                 <td style="width: 20px; height: 30px">
                       <asp:CheckBox ID="C58" runat="server" Text="E10" Font-Bold="True" 
                           ForeColor="#333300" oncheckedchanged="C58_CheckedChanged"/></td>
                 <td style="width: 20px; height: 30px">
                       <asp:CheckBox ID="C59" runat="server" Text="E11" Font-Bold="True" 
                           ForeColor="#333300" oncheckedchanged="C59_CheckedChanged"/></td>
                 <td style="height: 30px; width: 20px;">
                       <asp:CheckBox ID="C60" runat="server" Text="E12" Font-Bold="True" 
                           ForeColor="#333300" oncheckedchanged="C60_CheckedChanged"/></td>
            </tr>
            <tr>
                 <td style="width: 11px; height: 30px">
                       <asp:CheckBox ID="C61" runat="server" Text="F1" Font-Bold="True" 
                           ForeColor="#333300" oncheckedchanged="C61_CheckedChanged"/></td>
                 <td style="width: 20px; height: 30px">
                       <asp:CheckBox ID="C62" runat="server" Text="F2" Font-Bold="True" 
                           ForeColor="#333300" oncheckedchanged="C62_CheckedChanged"/></td>
                 <td style="height: 30px; width: 5px;">
                       <asp:CheckBox ID="C63" runat="server" Text="F3" Font-Bold="True" 
                           ForeColor="#333300" oncheckedchanged="C63_CheckedChanged"/></td>
                 <td style="width: 4px; height: 30px">
                       <asp:CheckBox ID="C64" runat="server" Text="F4" Font-Bold="True" 
                           ForeColor="#333300" oncheckedchanged="C64_CheckedChanged"/></td>
                 <td style="width: 21px; height: 30px">
                       <asp:CheckBox ID="C65" runat="server" Text="F5" Font-Bold="True" 
                           ForeColor="#333300" oncheckedchanged="C65_CheckedChanged"/></td>
                 <td style="width: 20px; height: 30px">
                       <asp:CheckBox ID="C66" runat="server" Text="F6" Font-Bold="True" 
                           ForeColor="#333300" oncheckedchanged="C66_CheckedChanged"/></td>
                 <td style="height: 30px; width: 21px;">
                       <asp:CheckBox ID="C67" runat="server" Text="F7" Font-Bold="True" 
                           ForeColor="#333300" oncheckedchanged="C67_CheckedChanged"/></td>
                 <td style="width: 20px; height: 30px">
                       <asp:CheckBox ID="C68" runat="server" Text="F8" Font-Bold="True" 
                           ForeColor="#333300" oncheckedchanged="C68_CheckedChanged"/></td>
                 <td style="width: 20px; height: 30px">
                       <asp:CheckBox ID="C69" runat="server" Text="F9" Font-Bold="True" 
                           ForeColor="#333300" oncheckedchanged="C69_CheckedChanged"/></td>
                 <td style="width: 20px; height: 30px">
                       <asp:CheckBox ID="C70" runat="server" Text="F10" Font-Bold="True" 
                           ForeColor="#333300" oncheckedchanged="C70_CheckedChanged"/></td>
                 <td style="width: 20px; height: 30px">
                       <asp:CheckBox ID="C71" runat="server" Text="F11" Font-Bold="True" 
                           ForeColor="#333300" oncheckedchanged="C71_CheckedChanged"/></td>
                 <td style="height: 30px; width: 20px;">
                       <asp:CheckBox ID="C72" runat="server" Text="F12" Font-Bold="True" 
                           ForeColor="#333300" oncheckedchanged="C72_CheckedChanged"/></td>
            </tr>                           
        </table>
    </asp:Panel>
<br /><br /><br />
    <asp:Panel ID="panelSC" runat="server" Enabled="False" Height="260px" 
        Width="703px">    
        <table>
            <tr>
                <td colspan="14" style="height: 5px">
                    <center><strong><span style="font-size: 16pt; font-family: Lucida Handwriting">SILVER CLASS</span></strong></center>
                <br /></td>
            </tr>
            <tr>
              <td style="width: 17px; height: 30px">
                     <asp:CheckBox ID="C73" runat="server" Text="G1" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C73_CheckedChanged"/></td>
              <td style="width: 20px; height: 30px">
                     <asp:CheckBox ID="C74" runat="server" Text="G2" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C74_CheckedChanged"/></td>
              <td style="height: 30px; width: 17px;">
                     <asp:CheckBox ID="C75" runat="server" Text="G3" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C75_CheckedChanged"/></td>
              <td style="width: 16px; height: 30px">
                     <asp:CheckBox ID="C76" runat="server" Text="G4" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C76_CheckedChanged"/></td>
              <td rowspan="4" style="width: 30px;" bgcolor="#FF9900"></td>
              <td style="width: 18px; height: 30px">
                     <asp:CheckBox ID="C77" runat="server" Text="G5" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C77_CheckedChanged"/></td>
              <td style="width: 18px; height: 30px">
                     <asp:CheckBox ID="C78" runat="server" Text="G6" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C78_CheckedChanged"/></td>
              <td style="width: 17px; height: 30px">
                     <asp:CheckBox ID="C79" runat="server" Text="G7" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C79_CheckedChanged"/></td>
              <td style="width: 12px; height: 30px">
                     <asp:CheckBox ID="C80" runat="server" Text="G8" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C80_CheckedChanged"/></td>
              <td rowspan="4" style="width: 30px;" bgcolor="#FF9900"></td>
              <td style="width: 15px; height: 30px">
                     <asp:CheckBox ID="C81" runat="server" Text="G9" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C81_CheckedChanged"/></td>
              <td style="width: 16px; height: 30px">
                     <asp:CheckBox ID="C82" runat="server" Text="G10" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C82_CheckedChanged"/></td>
              <td style="width: 16px; height: 30px">
                     <asp:CheckBox ID="C83" runat="server" Text="G11" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C83_CheckedChanged"/></td>
              <td style="height: 30px; width: 18px;">
                     <asp:CheckBox ID="C84" runat="server" Text="G12" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C84_CheckedChanged"/></td>
         </tr>
            <tr>
              <td style="width: 17px; height: 30px">
                     <asp:CheckBox ID="C85" runat="server" Text="H1" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C85_CheckedChanged"/></td>
              <td style="width: 20px; height: 30px">
                     <asp:CheckBox ID="C86" runat="server" Text="H2" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C86_CheckedChanged"/></td>
              <td style="height: 30px; width: 17px;">
                     <asp:CheckBox ID="C87" runat="server" Text="H3" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C87_CheckedChanged"/></td>
              <td style="width: 16px; height: 30px">
                     <asp:CheckBox ID="C88" runat="server" Text="H4" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C88_CheckedChanged"/></td>
              <td style="width: 18px; height: 30px">
                     <asp:CheckBox ID="C89" runat="server" Text="H5" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C89_CheckedChanged"/></td>
              <td style="width: 18px; height: 30px">
                     <asp:CheckBox ID="C90" runat="server" Text="H6" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C90_CheckedChanged"/></td>
              <td style="width: 17px; height: 30px">
                     <asp:CheckBox ID="C91" runat="server" Text="H7" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C91_CheckedChanged"/></td>
              <td style="width: 12px; height: 30px">
                     <asp:CheckBox ID="C92" runat="server" Text="H8" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C92_CheckedChanged"/></td>
              <td style="width: 15px; height: 30px">
                     <asp:CheckBox ID="C93" runat="server" Text="H9" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C93_CheckedChanged"/></td>
              <td style="width: 16px; height: 30px">
                     <asp:CheckBox ID="C94" runat="server" Text="H10" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C94_CheckedChanged"/></td>
              <td style="width: 16px; height: 30px">
                     <asp:CheckBox ID="C95" runat="server" Text="H11" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C95_CheckedChanged"/></td>
              <td style="height: 30px; width: 18px;">
                     <asp:CheckBox ID="C96" runat="server" Text="H12" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C96_CheckedChanged"/></td>
          </tr>
            <tr>
              <td class="style1" style="width: 17px">
                     <asp:CheckBox ID="C97" runat="server" Text="I1" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C97_CheckedChanged"/></td>
              <td class="style1" style="width: 20px">
                     <asp:CheckBox ID="C98" runat="server" Text="I2" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C98_CheckedChanged"/></td>
              <td class="style1" style="width: 17px">
                     <asp:CheckBox ID="C99" runat="server" Text="I3" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C99_CheckedChanged"/></td>
              <td class="style1" style="width: 16px">
                     <asp:CheckBox ID="C100" runat="server" Text="I4" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C100_CheckedChanged"/></td>
              <td class="style2" style="width: 18px">
                     <asp:CheckBox ID="C101" runat="server" Text="I5" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C101_CheckedChanged"/></td>
              <td class="style1" style="width: 18px">
                     <asp:CheckBox ID="C102" runat="server" Text="I6" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C102_CheckedChanged"/></td>
              <td class="style1" style="width: 17px">
                     <asp:CheckBox ID="C103" runat="server" Text="I7" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C103_CheckedChanged"/></td>
              <td class="style1" style="width: 12px">
                     <asp:CheckBox ID="C104" runat="server" Text="I8" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C104_CheckedChanged"/></td>
              <td class="style1" style="width: 15px">
                     <asp:CheckBox ID="C105" runat="server" Text="I9" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C105_CheckedChanged"/></td>
              <td class="style1" style="width: 16px">
                     <asp:CheckBox ID="C106" runat="server" Text="I10" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C106_CheckedChanged"/></td>
              <td class="style1" style="width: 16px">
                     <asp:CheckBox ID="C107" runat="server" Text="I11" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C107_CheckedChanged"/></td>
              <td class="style1" style="width: 18px">
                     <asp:CheckBox ID="C108" runat="server" Text="I12" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C108_CheckedChanged"/></td>
         </tr>
            <tr>
              <td style="width: 17px; height: 30px">
                     <asp:CheckBox ID="C109" runat="server" Text="J1" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C109_CheckedChanged"/></td>
              <td style="width: 20px; height: 30px">
                     <asp:CheckBox ID="C110" runat="server" Text="J2" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C110_CheckedChanged"/></td>
              <td style="height: 30px; width: 17px;">
                     <asp:CheckBox ID="C111" runat="server" Text="J3" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C111_CheckedChanged"/></td>
              <td style="width: 16px; height: 30px">
                     <asp:CheckBox ID="C112" runat="server" Text="J4" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C112_CheckedChanged"/></td>
              <td style="width: 18px; height: 30px">
                     <asp:CheckBox ID="C113" runat="server" Text="J5" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C113_CheckedChanged"/></td>
              <td style="width: 18px; height: 30px">
                     <asp:CheckBox ID="C114" runat="server" Text="J6" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C114_CheckedChanged"/></td>
              <td style="width: 17px; height: 30px">
                     <asp:CheckBox ID="C115" runat="server" Text="J7" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C115_CheckedChanged"/></td>
              <td style="width: 12px; height: 30px">
                     <asp:CheckBox ID="C116" runat="server" Text="J8" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C116_CheckedChanged"/></td>
              <td style="width: 15px; height: 30px">
                     <asp:CheckBox ID="C117" runat="server" Text="J9" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C117_CheckedChanged"/></td>
              <td style="width: 16px; height: 30px">
                     <asp:CheckBox ID="C118" runat="server" Text="J10" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C118_CheckedChanged"/></td>
              <td style="width: 16px; height: 30px">
                     <asp:CheckBox ID="C119" runat="server" Text="J11" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C119_CheckedChanged"/></td>
              <td style="height: 30px; width: 18px;">
                     <asp:CheckBox ID="C120" runat="server" Text="J12" Font-Bold="True" 
                         ForeColor="#333300" oncheckedchanged="C120_CheckedChanged"/></td>
        </tr>
        </table>
    </asp:Panel>
<br /><br /><br />
    <div style="width: 773px">
        <asp:Image ID="imgsrcn" runat="server" ImageUrl="~/seats/screen.png" Height="30px" Width="753px" />

    </div>
</center>
</div>
</asp:Content>

