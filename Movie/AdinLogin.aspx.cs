using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAdminLogin_Click(object sender, EventArgs e)
    {
        if (txtAdminname.Text == "admin" && txtAdminPassword.Text == "admin")
        {
            Response.Redirect("~/UserBookingInfo.aspx");
        }
        else
        {
            Response.Write("User name and password is wrong");
            Server.Transfer("~/HomePage.aspx");
        }
    }
}