<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.master" AutoEventWireup="true" CodeFile="FAQs.aspx.cs" Inherits="Default2" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style="height: 611px">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>
    <asp:Accordion ID="Accordion1" runat="server"
            SelectedIndex="0"
        HeaderCssClass="accordionHeader"
        HeaderSelectedCssClass="accordionHeaderSelected"
    ContentCssClass="accordionContent"
    AutoSize="None"
    FadeTransitions="true"
    TransitionDuration="250"
    FramesPerSecond="40"
    RequireOpenedPane="false"
    SuppressHeaderPostbacks="true" Height="222px" Width="700px">

    <Panes>
        <asp:AccordionPane ID="AccordionPane1" runat="server">
        <Header>REGISTRATION</Header>
        <Content>
       <b> 1. Why become an online member?</b><br />

&raquo;Your exclusive user name and password will be your key to a whole host of benefits! As an online member you can enjoy:- Ticket booking facility. Exciting contests where you win exclusive movie merchandise. Receive our e-newsletters that give you all the latest happenings at BIG Cinemas, cool offers and a whole lot more! All registrations are absolutely FREE, so what are you waiting for? Register now www.bigcinemas.com.<br /><br />

 <b>2. If I register with BIG Cinemas, will my details be supplied to other companies?</b><br />

&raquo;Your privacy is very important to us. We will not be passing any customer details to any other companies so that they can contact you directly. You will only receive communication from BIG Cinemas as a result of registering on www.bigcinemas.com . You will also only receive this communication from BIG Cinemas if you have given us your explicit consent by clicking the appropriate boxes when registering. From time to time we may, however, include relevant third parties or companies in our communications if we believe this will add value to our communications. The option to un-subscribe is also given should you wish to do so.<br /><br />

 <b>3. How do I log out?</b><br />

&raquo;We do not have personalised account facility on website incase of any query related to registration and booking please e-mail us at support@bigcinemas.com.<br /><br />
        </Content>
        </asp:AccordionPane>

        <asp:AccordionPane ID="AccordionPane2" runat="server">
         <Header>TICKET BOOKING:</Header>
        <Content>
        <b> 1. How do I book for birthdays, parties & group bookings?</b><br />

&raquo;For details on this facility call 39894040 or email us on Bhaumik.Mewada@relianceada.com<br /><br />

 <b>2. How can I book my movie tickets online?</b>

&raquo;It is possible to book tickets for all BIG Cinemas via the Quick Book option on the home page. Choose your state, city, cinema, movie, date, time, class and number of tickets and follow the instructions provided.<br /><br />

 <b>3. Is buying tickets on-line on www.bigcinemas.com safe and secure?</b><br />

&raquo;Absolutely! www.bigcinemas.com online booking service is protected by the latest technology. We have tied-up with the HDFC Payment Gateway which is a 3D Secure & VBV certified Payment gateway.<br /><br />

 <b>4. Can I select my own cinema seats?</b><br />

&raquo;Yes, it is possible to select seats of your choice on booking tickets online. Click on the Take me to Seat Layout button on the Order Summary page to view the seat layout and select seats of your choice or click 'Pay now' to continue without seat preference.<br /><br />

 <b>5. How do I know if my booking is confirmed?</b><br />

&raquo;Confirmation of your booking is clearly displayed on your computer screen at the end of the booking process. You can print this information if you wish, but this is not necessary in order to receive your tickets.<br /><br />

 <b>6. If I am running late for the film will my seat be held?</b><br />

&raquo;Once your purchase has been confirmed, your admission is held and will not be sold to another customer.<br />
        </Content>
        </asp:AccordionPane>

        <asp:AccordionPane ID="AccordionPane3" runat="server">
        <Header>PAYMENT PROCESS:</Header>
        <Content>
         <b>1. Do I have to pay extra fee when I purchase tickets online?</b><br />

&raquo;Yes, there is a convenience charge as per ticket price, minimum of INR 10 per ticket (except in Andhra Pradesh - INR 10).
No online convenience charge for Maharashtra Cinemas.<br /><br />

 <b>2. What methods of payment are accepted online?</b><br />

&raquo;We accept all major credit cards, American Express, Debit Cards & Net-banking. When collecting the tickets, the cardholder must be present with the card used to make the booking. Tickets will not be made available to anyone else.<br /><br />
        </Content>
        </asp:AccordionPane>

        <asp:AccordionPane ID="AccordionPane4" runat="server">
        <Header>REFUND:</Header>
        <Content>
         <b>1. Can I cancel the tickets that I have booked online and get a refund?</b><br />

&raquo;Once tickets have been bought online, they are considered sold and cannot be cancelled, refunded or exchanged.<br /><br />
        </Content>
        </asp:AccordionPane>

        <asp:AccordionPane ID="AccordionPane5" runat="server">
        <Header>TICKET COLLECTION:</Header>
        <Content>
         <b>1. Once I have booked tickets online, how do I collect them?</b><br />

&raquo;You can collect your tickets from the Box Office of the cinema you have booked tickets for. Please ensure that you arrive well in advance of the show time to allow time to pick up your tickets. Please remember to bring your card with you ensuring it is the one used to make the purchase. For security reasons, the card holder MUST be present for the tickets to be collected at the cinema.<br /><br />

 <b>2. Once I have booked tickets online, when can I collect them?</b><br />

&raquo;The tickets may be collected during the cinema's normal opening hours as soon as the booking has been confirmed.<br /><br />
        </Content>
        </asp:AccordionPane>

        <asp:AccordionPane ID="AccordionPane6" runat="server">
         <Header>COUPON CODE / E-VOUCHER / PROMO CODE:</Header>
        <Content>
         <b>1. How to use your Coupon Code/E-Voucher / Promo Code</b><br />

&raquo;Please follow the below steps to use your Coupon Code / E-Voucher / Promo Code. Log onto www.bigcinemas.com Select the cinema, movie, show date, show time, booking class and seats of your choice from our Quick Book section On the payment page click on "I Want to Redeem Evoucher"" and click "GO" after selecting the No. of coupons you wish to redeem. Enter the Coupon Code(s) same as mentioned in your email and click Redeem Voucher. Click on "Submit" and book your discounted ticket(s). The cost of the ticket(s) will be reduced. Pay the balance booking / convenience fees and book your ticket(s). Please note that you can redeem up to 10 Coupon Codes at one time at www.bigcinemas.com. The E-Voucher / Promo Code can be redeemed only on www.bigcinemas.com<br /><br />
        </Content>
        </asp:AccordionPane>
       
        
        <asp:AccordionPane ID="AccordionPane7" runat="server">
         <Header>TROUBLESHOOTING:</Header>
        <Content>
        <b> 1. What happens if my machine crashes when I am in the middle of a booking?</b><br />

&raquo;In the event that your computer crashes or you experience problems, please note that payment will not be made by you unless you have completed the entire process and confirmation of your booking has been made. However, in such an event write to us on support@bigcinemas.com.<br /><br />
        </Content>
        </asp:AccordionPane>

        <asp:AccordionPane ID="AccordionPane8" runat="server">
         <Header>CONTACT AND OTHER INFORMATION:</Header>
        <Content>
         <b>1. How can I contact BIG Cinemas?</b><br />

&raquo;Please feel free to e-mail us at support@bigcinemas.com for all queries and suggestions.<br /><br />

 <b>2. How do I find out a movie show time?</b><br />

&raquo;The show time of all movies will be displayed on the Check Show Timings section, in a cinema-wise order. This can be accessed at the top left part of the home page. Simply select City and Cinema of your interest.<br /><br />
        </Content>
        </asp:AccordionPane>

    </Panes>
    </asp:Accordion>

</div>
</asp:Content>

