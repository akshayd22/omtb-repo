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
        
       

            Panel1.Visible = true;
            Panel2.Visible = true;
            Panel3.Visible = true;
            Panel4.Visible = true;

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
               }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = true;
        Panel3.Visible = true;
        Panel4.Visible = true;
            
        
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = true;
        Panel3.Visible = false;
        Panel4.Visible = true;
        
        
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {

        Panel1.Visible = true;
        Panel2.Visible = false;
        Panel3.Visible = true;
        Panel4.Visible = false;       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/demobk.aspx");
    }
    protected void Button2_Click1(object sender, EventArgs e)
    {
        Response.Redirect("~/demobk.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/demobk.aspx");
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        lblErrorMsg1.Visible = true;
        //Response.Redirect("~/demobk.aspx");
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        lblErrorMsg2.Visible = true;
        //Response.Redirect("~/demobk.aspx");
    }
    protected void Button12_Click(object sender, EventArgs e)
    {
        lblErrorMsg3.Visible = true;
        //Response.Redirect("~/demobk.aspx");
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/demobk.aspx");
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/demobk.aspx");
    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/demobk.aspx");
    }
    protected void Button10_Click(object sender, EventArgs e)
    {
        lblErrorMsg4.Visible = true;
        //Response.Redirect("~/demobk.aspx");
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        lblErrorMsg5.Visible = true;
        //Response.Redirect("~/demobk.aspx");
    }
    protected void Button11_Click(object sender, EventArgs e)
    {

        lblErrorMsg6.Visible = true;
        //Response.Redirect("~/demobk.aspx");
    }
}