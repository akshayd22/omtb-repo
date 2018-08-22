using System;
using System.Net.Mail;

public partial class Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("akshaydamare9@gmail.com");
            mailMessage.To.Add("akshaydamare9@gmail.com");
            mailMessage.Subject = txtSubject.Text;

            mailMessage.Body = "<b>Sender Name : </b>" + txtName.Text + "<br />"

                + "<b>Sender Email : </b>" + txtEmail.Text + "<br />"
                + "<b>Sender Comments : </b>" + txtComment.Text;
            mailMessage.IsBodyHtml = true;

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new System.Net.NetworkCredential("akshaydamare9@gmail.com", "8898216510");
            smtpClient.Send(mailMessage);

            Label6.ForeColor = System.Drawing.Color.Blue;
            Label6.Text = "Tank You For Contacting Us";
            txtName.Enabled = false;
            txtEmail.Enabled = false;
            txtSubject.Enabled = false;
            txtComment.Enabled = false;
        }
        catch (Exception ex)
        {
            //Log Event or table
            Label6.ForeColor = System.Drawing.Color.Blue;
            Label6.ForeColor = System.Drawing.Color.Red;
            Label6.Text = "There is an unknown problem. Please try later";

        }
    }
}