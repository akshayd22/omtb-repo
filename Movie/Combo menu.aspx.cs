using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    public Double a;
    public Double q;
    public Double t;
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void ddlSelectItem_SelectedIndexChanged(object sender, EventArgs e)
    {
        //txtItemPrice.Text = ddlSelectItem.SelectedValue;
      
    }
    protected void ddlSelectQuantity_SelectedIndexChanged(object sender, EventArgs e)
    {

       // txtTotalAmt.Text = ddlSelectQuantity.SelectedValue;
 
    }
    protected void txtItemPrice_TextChanged(object sender, EventArgs e)
    {

    }
    protected void txtTotalAmt_TextChanged(object sender, EventArgs e)
    {
       //txtItemPrice.Text = ddlSelectItem.SelectedValue;
       a = Convert.ToDouble(ddlSelectItem.SelectedValue);
        
       q = Convert.ToDouble(ddlSelectQuantity.SelectedValue);
       t = a * q;
       lbltamt.Text = "" + t;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        ddlSelectItem.SelectedIndex = 0;
        ddlSelectQuantity.SelectedIndex = 0;
        ddlMOD.SelectedIndex = 0;
        //txtTotalAmt.Text = "";
        //txtItemPrice.Text = "";
        lbltamt.Text = "";
        btmProceed.Visible = false;

      
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //txtItemPrice.Text = ddlSelectItem.SelectedValue;
        lbltamt.Text = "" + q;
        a = Convert.ToDouble(ddlSelectItem.SelectedValue);
        q = Convert.ToDouble(ddlSelectQuantity.SelectedValue);
        t = a * q;
        lbltamt.Text = "" + t;
        btmProceed.Visible = true;
        Button1.Visible = false;
    }
    protected void btmProceed_Click(object sender, EventArgs e)
    {
        /*if (txtAddonPrice.Text == "")
        {
            txtAddonPrice.Text = "-";
        }
        else
        {
            txtAddonPrice.Text = Session["ComboAmt"].ToString();
        }*/
        Session["ComboAmt"] = lbltamt.Text;
        Response.Redirect("~/Bill.aspx");
    }
}