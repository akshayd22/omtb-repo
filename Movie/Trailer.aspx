<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.master" AutoEventWireup="true" CodeFile="Trailer.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<div align="left" dir="rtl"
        
        style="background-position: left top; border-top-width: thin; background-image: url('layout/images/contentPatternBottom.png'); background-repeat: repeat-x; height: 55px; background-color: #FFFF00; margin-right: 38px;">
    <asp:ImageButton ID="ibtnNowShowing" runat="server" 
        ImageUrl="~/layout/images/now showing.png" onclick="ImageButton3_Click" 
        PostBackUrl="~/Trailer.aspx" Width="145px" />&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="ibtnCmindSoon" runat="server" 
            ImageUrl="~/layout/images/coming soon.png" Width="193px" 
        onclick="ImageButton2_Click" PostBackUrl="~/Trailer.aspx" />&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="ibtnAll" runat="server" Height="33px" 
            ImageUrl="~/layout/images/alll.png" Width="65px" 
        onclick="ImageButton1_Click" PostBackUrl="~/Trailer.aspx" />

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

</div>
<br /><br />

<!-- Hollywood Movie -->
     <asp:Panel ID="Panel1" runat="server" BackImageUrl="~/layout/images/pnlbk.png" 
        Width="966px" Visible="False">
      
       <table class="style1"> 
        <tr>      
            <td class="style2">
              <Video controls="" heigth="80px" width="295px">
              <source src="vedios/hw2012.mp4" type="video/mp4">
              <source src="vedios/hw2012.ogg" type="video/ogg">
              </video>
              <br />
                <asp:Label ID="lbl1" runat="server" Text="Movie Name:2012(HollyWood)" Font-Bold="True" 
                    ForeColor="White"></asp:Label>
              <br />
              <asp:Button ID="Button1" runat="server" Text="BOOK NOW" onclick="Button1_Click"></asp:Button>               
              &nbsp;</td> 
            <td>
               <Video controls="" heigth="80px" width="295px">
               <source src="vedios/hwCAPTAINAMERICA3.mp4" type="video/mp4">
               <source src="vedios/hwCAPTAINAMERICA3.ogg" type="video/ogg">
               </video>
                <br />
                <asp:Label ID="lbl2" runat="server" Text="Movie Name:Captan America 3(HollyWood)" Font-Bold="True" 
                    ForeColor="White"></asp:Label>
            
               <br />
               <asp:Button ID="Button2" runat="server" Text="BOOK NOW" onclick="Button2_Click1"></asp:Button>                             
            &nbsp;</td>    
            <td>
              <Video controls="" heigth="80px" width="295px">
              <source src="vedios/hwINDEPENDENCEDAY2.mp4" type="video/mp4">
              <source src="vedios/hwINDEPENDENCEDAY2.ogg" type="video/ogg">
              </video>
              <br />
               <asp:Label ID="lbl3" runat="server" Text="Movie Name:Independenceday2(HollyWood)" Font-Bold="True" 
                    ForeColor="White"></asp:Label>
           <br />
              <asp:Button ID="Button3" runat="server" Text="BOOK NOW" onclick="Button3_Click"></asp:Button>                             
              &nbsp;</td>  
        </tr>        
         </table>
        </asp:Panel>
<!-- /Hollywood Movie -->
<br /><br />
<!-- Animated Hollywood Movie -->

        <asp:Panel ID="Panel2" runat="server" 
        BackImageUrl="~/layout/images/pnlbk.png" Width="966px" Visible="False">
        <br />
          <table class="style3"> 
        <tr>      
            <td class="style4">
                     <video controls="" heigth="80px" width="295px">
                           <source src="vedios/hwaANGRY%20BIRDS.mp4" type="video/mp4">
                           <source src="vedios/hwaANGRY%20BIRDS.ogg" type="video/ogg">
                     </video>
                       <br />
                        <asp:Label ID="lbl4" runat="server" Text="Movie Name:Angry Birds(HollyWood)" Font-Bold="True" 
                    ForeColor="White"></asp:Label>
           <br />
                       <asp:Button ID="Button4" runat="server" Text="BOOK NOW" 
                         onclick="Button4_Click" /> 
                         <br />
                <asp:Label ID="lblErrorMsg1" runat="server" Text="This Movie is not Released now days.try After some day." 
                        Visible="False" Font-Bold="True" ForeColor="White"></asp:Label>                      
                        &nbsp;</td>

                    <td>
                     <video controls="" heigth="80px" width="295px">
                           <source src="vedios/hwaTEENAGEMUTANTNINJATURTLES2.mp4" type="video/mp4">
                           <source src="vedios/hwaTEENAGEMUTANTNINJATURTLES2.ogg" type="video/ogg">
                     </video>
                       <br />
                        <asp:Label ID="lbl5" runat="server" Text="Movie Name:TEEN AGEMUTANT NINJA TURTLES2(HollyWood)" Font-Bold="True" 
                    ForeColor="White"></asp:Label>
           <br />                      
                      <asp:Button ID="Button8" runat="server" Text="BOOK NOW" 
                            onclick="Button8_Click" /> 
                              <br />
                <asp:Label ID="lblErrorMsg2" runat="server" Text="This Movie is not Released now days.try After some day." 
                        Visible="False" Font-Bold="True" ForeColor="White"></asp:Label>                      
                                           
                     &nbsp;</td>
                    <td>
                    <video controls="" heigth="80px" width="295px">
                           <source src="vedios/hwaZOOTOPIA.mp4" type="video/mp4">
                           <source src="vedios/hwaZOOTOPIA.ogg" type="video/ogg">
                    </video>
                    <br />
                      <asp:Label ID="lbl6" runat="server" Text="Movie Name:ZOOTOPIA(HollyWood)" Font-Bold="True" 
                    ForeColor="White"></asp:Label>
           <br />     
                    <asp:Button ID="Button12" runat="server" Text="BOOK NOW" onclick="Button12_Click" />                                          
                                  <br />
                <asp:Label ID="lblErrorMsg3" runat="server" Text="This Movie is not Released now days.try After some day." 
                        Visible="False" Font-Bold="True" ForeColor="White"></asp:Label>                      
                                 
                    &nbsp;</td>
                </tr>
            </table>
            <br />
             </asp:Panel>
<!-- /Animated Hollywood Movie -->

<br /><br />

<!-- Bollywood Movie -->
    <asp:Panel ID="Panel3" runat="server" BackImageUrl="~/layout/images/pnlbk.png" 
        Width="966px" Visible="False">
        <br />        
       <table class="style5"> 
        <tr>      
            <td class="style6">
                     <video controls="" heigth="80px" width="295px">
                     <source src="vedios/bwAirliftTeaser.mp4" type="video/mp4">
                     <source src="vedios/bwAirliftTeaser.ogg" type="video/ogg">
                     </video>
                     <br />
                     <asp:Label ID="lbl7" runat="server" Text="Movie Name:Airlift Teaser(BollyWood)" Font-Bold="True" 
                    ForeColor="White"></asp:Label>
           <br />  
                     <asp:Button ID="Button6" runat="server" Text="BOOK NOW" 
                         onclick="Button6_Click" />                      
                     &nbsp;</td>
            <td>
                     <video controls="" heigth="80px" width="295px">
                     <source src="vedios/bwBajiraoMastani.mp4" type="video/mp4">
                     <source src="vedios/bwBajiraoMastani.ogg" type="video/ogg">
                     </video>
                     <br />
                      <asp:Label ID="lbl8" runat="server" Text="Movie Name:Bajirao Mastani(BollyWood)" Font-Bold="True" 
                    ForeColor="White"></asp:Label>
           <br />  
                     <asp:Button ID="Button7" runat="server" Text="BOOK NOW" 
                         onclick="Button7_Click" />                      
                     &nbsp;</td>
            <td>
                     <video controls="" heigth="80px" width="295px">
                     <source src="vedios/bwDilwale.mp4" type="video/mp4">
                     <source src="vedios/bwDilwale.ogg" type="video/ogg">
                     </video>
                     <br />
                      <asp:Label ID="lbl9" runat="server" Text="Movie Name:Dilwale(BollyWood)" Font-Bold="True" 
                    ForeColor="White"></asp:Label>
           <br />  
                       <asp:Button ID="Button9" runat="server" Text="BOOK NOW" 
                         onclick="Button9_Click" />                                          
                     &nbsp;</td>
                </tr>               
        </table>
   </asp:Panel>
 <!-- /Bollywood Movie -->  
     
      <br /><br />

<!-- Tollywood Movie -->      
   <asp:Panel ID="Panel4" runat="server" 
        BackImageUrl="~/layout/images/pnlbk.png" Width="966px" Visible="False">
        <br />
           <table class="style7"> 
             <tr>      
                 <td class="style8">
                     <video controls="" heigth="80px" width="295px">
                     <source src="vedios/twMiruthan.mp4" type="video/mp4">
                     <source src="vedios/twMiruthan.ogg" type="video/ogg">
                     </video>
                     <br />
                      <asp:Label ID="lbl10" runat="server" Text="Movie Name:Miruthan(TollyWood)" Font-Bold="True" 
                    ForeColor="White"></asp:Label>
           <br />  
                     <asp:Button ID="Button10" runat="server" Text="BOOK NOW" 
                         onclick="Button10_Click" />  
                                             <br />
                <asp:Label ID="lblErrorMsg4" runat="server" Text="This Movie is not Released now days.try After some day." 
                        Visible="False" Font-Bold="True" ForeColor="White"></asp:Label>                      
                                      
                     &nbsp;</td>

                     <td>
                     <video controls="" heigth="80px" width="295px">
                     <source src="vedios/Selvandhan.mp4" type="video/mp4">
                     <source src="vedios/Selvandhan.ogg" type="video/ogg">
                     </video>
                     <br />
                      <asp:Label ID="lbl11" runat="server" Text="Movie Name:Selvandhan(TollyWood)" Font-Bold="True" 
                    ForeColor="White"></asp:Label>
           <br />  
                     <asp:Button ID="Button5" runat="server" Text="BOOK NOW" onclick="Button5_Click" /> 
                                         <br />
                <asp:Label ID="lblErrorMsg5" runat="server" Text="This Movie is not Released now days.try After some day." 
                        Visible="False" Font-Bold="True" ForeColor="White"></asp:Label>                      
                                       
                     &nbsp;</td>

                    <td>
                     <video controls="" heigth="80px" width="295px">
                     <source src="vedios/KABALI.mp4" type="video/mp4">
                     <source src="vedios/KABALI.ogg" type="video/ogg">
                     </video>
                     <br />
                      <asp:Label ID="lbl12" runat="server" Text="Movie Name:KABALI(TollyWood)" Font-Bold="True" 
                    ForeColor="White"></asp:Label>
           <br />  
                     <asp:Button ID="Button11" runat="server" Text="BOOK NOW" 
                            onclick="Button11_Click" />    
                                                <br />
                <asp:Label ID="lblErrorMsg6" runat="server" Text="This Movie is not Released now days.try After some day." 
                        Visible="False" Font-Bold="True" ForeColor="White"></asp:Label>                      
                                    
                     &nbsp;</td>
                </tr>                       
        </table>
   </asp:Panel>
<!-- /TOllywood Movie -->
<br />
<br />
<div align="left" dir="rtl" 
        
        style="background-position: left top; border-top-width: thin; background-image: url('layout/images/contentPatternBottom.png'); background-repeat: repeat-x; height: 55px; background-color: #FFFF00; margin-right: 38px;">
    <asp:ImageButton ID="ImageButton1" runat="server" 
        ImageUrl="~/layout/images/now showing.png" onclick="ImageButton3_Click" 
        PostBackUrl="~/Trailer.aspx" Width="145px" />&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="ImageButton2" runat="server" 
            ImageUrl="~/layout/images/coming soon.png" Width="193px" 
        onclick="ImageButton2_Click" PostBackUrl="~/Trailer.aspx" />&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="ImageButton3" runat="server" Height="33px" 
            ImageUrl="~/layout/images/alll.png" Width="65px" 
        onclick="ImageButton1_Click" PostBackUrl="~/Trailer.aspx" />

</div>
<br /><br />

</asp:Content>

