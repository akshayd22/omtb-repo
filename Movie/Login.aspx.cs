using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringregis"].ConnectionString);
        conn.Open();
        String checkuser = "select count(*) from Registration where User_Name='" + txtUsername.Text + "'";
        SqlCommand cmd = new SqlCommand(checkuser, conn);
        int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());
        conn.Close();
        if (temp == 1)
        {
            conn.Open();
            String checkpass = "select Password from Registration where User_Name='" + txtUsername.Text + "' ";
            SqlCommand passcmd = new SqlCommand(checkpass, conn);
           string password = passcmd.ExecuteScalar().ToString().Replace(" ","");
            if (password == txtPassword.Text)
            {
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = conn;
                cmd1.CommandText = "Insert into Login_Details(username,password,time) Values('"+txtUsername.Text+"','"+txtPassword.Text+"','"+DateTime.Now+"')";
                cmd1.ExecuteNonQuery();
                Server.Transfer("~/demobk.aspx");
            }
            else
            {
                Response.Write("<script>alert('password is Wrong')</script>");               
            }

        }
        else
        {
            Response.Write("<script>alert('User Name Or Password Is Wrong')</script>");
            Response.Write("<script>alert('Enter Correct Password')</script>");
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
        conn.Close();
    }

    }
