using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HomePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void AdRotator1_AdCreated(object sender, AdCreatedEventArgs e)
    {

    }
    protected void XmlDataSource1_Transforming(object sender, EventArgs e)
    {

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("http://localhost:1969/Movie/Trailer.aspx");
    }
    protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
    {

    }
}