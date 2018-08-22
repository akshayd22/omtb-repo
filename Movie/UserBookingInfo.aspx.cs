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
    protected void Button1_Click(object sender, EventArgs e)
    {
        GridView2.Visible = true;
        GridView1.Visible = false;
        GridView3.Visible = false;

    }
    protected void btnloginInfo_Click(object sender, EventArgs e)
    {
        GridView1.Visible = true;
        GridView2.Visible = false;
        GridView3.Visible = false;
    }
    protected void btnregisinfo_Click(object sender, EventArgs e)
    {
        GridView3.Visible = true;
        GridView2.Visible = false;
        GridView1.Visible = false;
    }
}