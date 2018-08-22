
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class Registration : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click1(object sender, EventArgs e)
    {
        try
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringregis"].ConnectionString);
            conn.Open();
            String checkuser = "select count(*) from Registration where User_Name='" + txtUsername.Text + "' ";
            SqlCommand com = new SqlCommand(checkuser, conn);
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            if (temp > 0)
            {
                lblchekuser.Text = "User Name Is Alredy Exist";
                lblchekuser.Visible = true;

            }
            else
            {
                string insertQuery = "insert into Registration(Full_Name,Age,Gender,Mobail_No,Email,User_Name,Password) values(@Fname,@CName,@CAddress,@EAddress,@Email,@UName,@Password)";
                com = new SqlCommand(insertQuery, conn);
                com.Parameters.AddWithValue("@Fname", txtFullName.Text);
                com.Parameters.AddWithValue("@CName", txtAGE.Text);
                com.Parameters.AddWithValue("@CAddress", ddlgender.Text);
                com.Parameters.AddWithValue("@EAddress", txtNumber.Text);
                com.Parameters.AddWithValue("@Email", txtEmail.Text);
                com.Parameters.AddWithValue("@UName", txtUsername.Text);
                com.Parameters.AddWithValue("@Password", txtPassword.Text);
                com.ExecuteNonQuery();
                Response.Write("<script>alert('Registration is Sucessfull go to login page')</script>");
                Server.Transfer("~/Login.aspx");
            }
            conn.Close();
        }
        catch (SqlException ex)
        {
            Response.Write("Error:" + ex.ToString());
        }
        
    }
}
