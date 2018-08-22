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
       if(rblMovies.SelectedIndex==0)
       {
            Label7.Text = ddlBollywood.SelectedItem.Text;
        }
       if (rblMovies.SelectedIndex == 1)
       {
            Label7.Text = ddlHollywood.SelectedItem.Text;
       }
       if (rblMovies.SelectedIndex == 2)
       {
            Label7.Text = ddlTollywood.SelectedItem.Text;
       }
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        /*try
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringregis"].ConnectionString);
            conn.Open();
            String checkuser = "select count(*) from Booking";
            SqlCommand com = new SqlCommand(checkuser, conn);
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());

            string insertQuery = "insert into Booking(Bid,Uid,Movie_Type,Movie_Name,Date,Time,Class,User_Name,Mobail_No,Email,Price,No_Of_Seats,Sub_Total) values(@Bid,@Uid,@Movie_type,@Movie_Name,@Dte,@Tye,@Cls,@User_Name,@Mobail_No,@Email,@Price,@No_Of_Seats,@Sub_Total)";
            com = new SqlCommand(insertQuery, conn);
           
            com.Parameters.AddWithValue("@Movie_type", rblMovies.Text);
            com.Parameters.AddWithValue("@Movie_Name", Label7.Text);
            
            com.Parameters.AddWithValue("@Dte", ddlDate.Text);
            com.Parameters.AddWithValue("@Tye", dddlTime.Text);
            //com.Parameters.AddWithValue("@Cls", ddlClass.Text);

            //com.Parameters.AddWithValue("@No_Of_Seats", txtNOS.Text);
           // com.Parameters.AddWithValue("@Price", txtPrice.Text);     
           // com.Parameters.AddWithValue("@Sub_Total", txtTotal.Text);
           

            com.ExecuteNonQuery();
           
            conn.Close();
        }
        catch (SqlException ex)
        {
            Response.Write("Error:" + ex.ToString());
        }*/

        if (ddlBollywood.SelectedIndex == 1)
        {
            Session["MovieName"] = ddlBollywood.Text;
        }

        if (ddlBollywood.SelectedIndex == 2)
        {
            Session["MovieName"] = ddlBollywood.Text;
        }
        if (ddlBollywood.SelectedIndex == 3)
        {
            Session["MovieName"] = ddlBollywood.Text;
        }

        if (ddlHollywood.SelectedIndex == 1)
        {
            Session["MovieName"] = ddlHollywood.Text;
        }
        if (ddlHollywood.SelectedIndex == 2)
        {
            Session["MovieName"] = ddlHollywood.Text;
        }
        if (ddlHollywood.SelectedIndex == 3)
        {
            Session["MovieName"] = ddlHollywood.Text;
        }

        if (ddlTollywood.SelectedIndex == 1)
        {
            Session["MovieName"] = ddlTollywood.Text;
        }
        if (ddlTollywood.SelectedIndex == 2)
        {
            Session["MovieName"] = ddlTollywood.Text;
        }
        if (ddlTollywood.SelectedIndex == 3)
        {
            Session["MovieName"] = ddlTollywood.Text;
        }


        if (ddlDate.SelectedIndex == 1)
        {
            Session["Date"] = ddlDate.Text;
        }
        if (ddlDate.SelectedIndex == 2)
        {
            Session["Date"] = ddlDate.Text;
        }



        if (dddlTime.SelectedIndex == 1)
        {
            Session["Time"] = dddlTime.Text;
        }
        if (dddlTime.SelectedIndex == 2)
        {
            Session["Time"] = dddlTime.Text;
        }
        if (dddlTime.SelectedIndex == 3)
        {
            Session["Time"] = dddlTime.Text;
        }
        if (dddlTime.SelectedIndex == 4)
        {
            Session["Time"] = dddlTime.Text;
        }
        /* // //to check already booked
         //a row
         if (C1.Enabled == false)
         {
             Session["a1"] = null;
         }
         if (C2.Enabled == false)
         {
             Session["a2"] = null;
         }
         if (C3.Enabled == false)
         {
             Session["a3"] = null;
         }
         if (C4.Enabled == false)
         {
             Session["a4"] = null;
         }
         if (C5.Enabled == false)
         {
             Session["a5"] = null;
         }
         if (C6.Enabled == false)
         {
             Session["a6"] = null;
         }
         if (C7.Enabled == false)
         {
             Session["a7"] = null;
         }
         if (C8.Enabled == false)
         {
             Session["a8"] = null;
         }
         if (C9.Enabled == false)
         {
             Session["a9"] = null;
         }
         if (C10.Enabled == false)
         {
             Session["a10"] = null;
         }
         if (C11.Enabled == false)
         {
             Session["a11"] = null;
         }
         if (C12.Enabled == false)
         {
             Session["a12"] = null;
         }

         //row b
         if (C13.Enabled == false)
         {
             Session["b1"] = null;
         }
         if (C14.Enabled == false)
         {
             Session["b2"] = null;
         }
         if (C15.Enabled == false)
         {
             Session["b3"] = null;
         }
         if (C16.Enabled == false)
         {
             Session["b4"] = null;
         }
         if (C17.Enabled == false)
         {
             Session["b5"] = null;
         }
         if (C18.Enabled == false)
         {
             Session["b6"] = null;
         }
         if (C19.Enabled == false)
         {
             Session["b7"] = null;
         }
         if (C20.Enabled == false)
         {
             Session["b8"] = null;
         }
         if (C21.Enabled == false)
         {
             Session["b9"] = null;
         }
         if (C22.Enabled == false)
         {
             Session["b10"] = null;
         }
         if (C23.Enabled == false)
         {
             Session["b11"] = null;
         }
         if (C24.Enabled == false)
         {
             Session["b12"] = null;
         }

         //c row
         if (C25.Enabled == false)
         {
             Session["c1"] = null;
         }
         if (C26.Enabled == false)
         {
             Session["c2"] = null;
         }
         if (C27.Enabled == false)
         {
             Session["c3"] = null;
         }
         if (C28.Enabled == false)
         {
             Session["c4"] = null;
         }
         if (C29.Enabled == false)
         {
             Session["c5"] = null;
         }
         if (C30.Enabled == false)
         {
             Session["c6"] = null;
         }
         if (C31.Enabled == false)
         {
             Session["c7"] = null;
         }
         if (C32.Enabled == false)
         {
             Session["c8"] = null;
         }
         if (C33.Enabled == false)
         {
             Session["c9"] = null;
         }
         if (C34.Enabled == false)
         {
             Session["c10"] = null;
         }
         if (C35.Enabled == false)
         {
             Session["c11"] = null;
         }
         if (C36.Enabled == false)
         {
             Session["c12"] = null;
         }

         //d row

         if (C37.Enabled == false)
         {
             Session["d1"] = null;
         }
         if (C38.Enabled == false)
         {
             Session["d2"] = null;
         }
         if (C39.Enabled == false)
         {
             Session["d3"] = null;
         }
         if (C40.Enabled == false)
         {
             Session["d4"] = null;
         }
         if (C41.Enabled == false)
         {
             Session["d5"] = null;
         }
         if (C42.Enabled == false)
         {
             Session["d6"] = null;
         }
         if (C43.Enabled == false)
         {
             Session["d7"] = null;
         }
         if (C44.Enabled == false)
         {
             Session["d8"] = null;
         }
         if (C45.Enabled == false)
         {
             Session["d9"] = null;
         }
         if (C46.Enabled == false)
         {
             Session["d10"] = null;
         }
         if (C47.Enabled == false)
         {
             Session["d11"] = null;
         }
         if (C48.Enabled == false)
         {
             Session["d12"] = null;
         }

         //e row

         if (C49.Enabled == false)
         {
             Session["e1"] = null;
         }
         if (C50.Enabled == false)
         {
             Session["e2"] = null;
         }
         if (C51.Enabled == false)
         {
             Session["e3"] = null;
         }
         if (C52.Enabled == false)
         {
             Session["e4"] = null;
         }
         if (C53.Enabled == false)
         {
             Session["e5"] = null;
         }
         if (C54.Enabled == false)
         {
             Session["e6"] = null;
         }
         if (C55.Enabled == false)
         {
             Session["e7"] = null;
         }
         if (C56.Enabled == false)
         {
             Session["e8"] = null;
         }
         if (C57.Enabled == false)
         {
             Session["e9"] = null;
         }
         if (C58.Enabled == false)
         {
             Session["e10"] = null;
         }
         if (C59.Enabled == false)
         {
             Session["e11"] = null;
         }
         if (C60.Enabled == false)
         {
             Session["e12"] = null;
         }

         //f row
         if (C61.Enabled == false)
         {
             Session["f1"] = null;
         }
         if (C62.Enabled == false)
         {
             Session["f2"] = null;
         }
         if (C63.Enabled == false)
         {
             Session["f3"] = null;
         }
         if (C64.Enabled == false)
         {
             Session["f4"] = null;
         }
         if (C65.Enabled == false)
         {
             Session["f5"] = null;
         }
         if (C66.Enabled == false)
         {
             Session["f6"] = null;
         }
         if (C67.Enabled == false)
         {
             Session["f7"] = null;
         }
         if (C68.Enabled == false)
         {
             Session["f8"] = null;
         }
         if (C69.Enabled == false)
         {
             Session["f9"] = null;
         }
         if (C70.Enabled == false)
         {
             Session["f10"] = null;
         }
         if (C71.Enabled == false)
         {
             Session["f11"] = null;
         }
         if (C72.Enabled == false)
         {
             Session["f12"] = null;
         }
         // g row
         if (C73.Enabled == false)
         {
             Session["g1"] = null;
         }
         if (C74.Enabled == false)
         {
             Session["g2"] = null;
         }
         if (C75.Enabled == false)
         {
             Session["g3"] = null;
         }
         if (C76.Enabled == false)
         {
             Session["g4"] = null;
         }
         if (C77.Enabled == false)
         {
             Session["g5"] = null;
         }
         if (C78.Enabled == false)
         {
             Session["g6"] = null;
         }
         if (C79.Enabled == false)
         {
             Session["g7"] = null;
         }
         if (C80.Enabled == false)
         {
             Session["g8"] = null;
         }
         if (C81.Enabled == false)
         {
             Session["g9"] = null;
         }
         if (C82.Enabled == false)
         {
             Session["g10"] = null;
         }
         if (C83.Enabled == false)
         {
             Session["g11"] = null;
         }
         if (C84.Enabled == false)
         {
             Session["g12"] = null;
         }

         //h row
         if (C85.Enabled == false)
         {
             Session["h1"] = null;
         }
         if (C86.Enabled == false)
         {
             Session["h2"] = null;
         }
         if (C87.Enabled == false)
         {
             Session["h3"] = null;
         }
         if (C88.Enabled == false)
         {
             Session["h4"] = null;
         }
         if (C89.Enabled == false)
         {
             Session["h5"] = null;
         }
         if (C90.Enabled == false)
         {
             Session["h6"] = null;
         }
         if (C91.Enabled == false)
         {
             Session["h7"] = null;
         }
         if (C92.Enabled == false)
         {
             Session["h9"] = null;
         }
         if (C93.Enabled == false)
         {
             Session["h10"] = null;
         }
         if (C94.Enabled == false)
         {
             Session["h11"] = null;
         }
         if (C95.Enabled == false)
         {
             Session["h12"] = null;
         }

         //i row
         if (C96.Enabled == false)
         {
             Session["i1"] = null;
         }
         if (C97.Enabled == false)
         {
             Session["i2"] = null;
         }
         if (C98.Enabled == false)
         {
             Session["i3"] = null;
         }
         if (C99.Enabled == false)
         {
             Session["i4"] = null;
         }
         if (C100.Enabled == false)
         {
             Session["i5"] = null;
         }
         if (C101.Enabled == false)
         {
             Session["i6"] = null;
         }
         if (C102.Enabled == false)
         {
             Session["i7"] = null;
         }
         if (C103.Enabled == false)
         {
             Session["i8"] = null;
         }
         if (C104.Enabled == false)
         {
             Session["i9"] = null;
         }
         if (C105.Enabled == false)
         {
             Session["i10"] = null;
         }
         if (C106.Enabled == false)
         {
             Session["i11"] = null;
         }
         if (C107.Enabled == false)
         {
             Session["i12"] = null;
         }

         //j row
         if (C108.Enabled == false)
         {
             Session["j1"] = null;
         }
         if (C109.Enabled == false)
         {
             Session["j2"] = null;
         }
         if (C110.Enabled == false)
         {
             Session["j3"] = null;
         }
         if (C111.Enabled == false)
         {
             Session["j4"] = null;
         }
         if (C112.Enabled == false)
         {
             Session["j5"] = null;
         }
         if (C113.Enabled == false)
         {
             Session["j6"] = null;
         }
         if (C114.Enabled == false)
         {
             Session["j7"] = null;
         }
         if (C115.Enabled == false)
         {
             Session["j8"] = null;
         }
         if (C116.Enabled == false)
         {
             Session["j9"] = null;
         }
         if (C117.Enabled == false)
         {
             Session["j10"] = null;
         }
         if (C118.Enabled == false)
         {
             Session["j11"] = null;
         }
         if (C119.Enabled == false)
         {
             Session["j12"] = null;
         }
        */
        Response.Redirect("~/SeatMap.aspx");

    }
   

    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (rblMovies.SelectedIndex == 0)
        {
            ddlBollywood.Visible = true;
            ddlHollywood.Visible = false;
            ddlTollywood.Visible = false;
        }

        if (rblMovies.SelectedIndex == 1)
        {
            ddlBollywood.Visible = false;
            ddlHollywood.Visible = true;
            ddlTollywood.Visible = false;
        }

        if (rblMovies.SelectedIndex == 2)
        {
            ddlBollywood.Visible = false;
            ddlHollywood.Visible = false;
            ddlTollywood.Visible = true;
        }

    }
   
}
