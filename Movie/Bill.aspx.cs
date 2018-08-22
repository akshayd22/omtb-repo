using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
        
         public int n,o;
         
    protected void Page_Load(object sender, EventArgs e)
    {
         
        txtMovieName.Text = Session["MovieName"].ToString();
        lblDate.Text = Session["Date"].ToString();
        lblShwTime.Text = Session["Time"].ToString();
        lblClass.Text = Session["Class"].ToString();

      
        
            /*txtSeat1.Text = Session["A1"].ToString();
              
            txtSeat2.Text = Session["A2"].ToString();
        
            txtSeat3.Text = Session["A3"].ToString();
        
            txtSeat4.Text = Session["A4"].ToString();
       
            txtSeat5.Text = Session["A5"].ToString();
       
            txtSeat6.Text = Session["A6"].ToString();
         */
            
            
           
            

        

        txtAddonPrice.Text = Session["ComboAmt"].ToString();        
        txtSubTotal.Text = Session["TickitPrice"].ToString();  
        n = 30 + (Convert.ToInt32(txtAddonPrice.Text)) + (Convert.ToInt32(txtSubTotal.Text));
        lblTotalAmt.Text = Convert.ToString(n);
        lblAmtPyble.Text = lblTotalAmt.Text;
       /* if (n >= 2500)
        {
            o = (10 / 100 * n);
            o = n - o;
            lblAmtPyble.Text = Convert.ToString(o);
            lblTotalAmt.Text = Convert.ToString(n);

        }
            
        else
        {
            
            
        }
        */
      
    }

    protected void rblPayment_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (rblPayment.SelectedIndex == 0)
        {
            PanelCreditCard.Enabled = true;
           // panelDebitCard.Enabled = false;
        }

        if (rblPayment.SelectedIndex == 1)
        {
           // panelDebitCard.Enabled = true;
            PanelCreditCard.Enabled = false;
        }
    }
    protected void btnCreditMakePayment_Click(object sender, EventArgs e)
    
    {
       SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringregis"].ConnectionString);
        conn.Open();
        
            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.CommandText = "Select * from Booking1 where Movie_Name='" + txtMovieName + "' ";
        //String userbooking = "select count(*) from Booking where Movie_Name='" + txtMovieName + "' ";
        //SqlCommand com = new SqlCommand(userbooking, conn);
         
        string insertQuery = "insert into Booking1(Movie_Name,Date,Time,Total_Amt) values(@Movie_Name,@Date,@Time,@Total_Amt)";
        com = new SqlCommand(insertQuery, conn);
              
        com.Parameters.AddWithValue("@Movie_Name", txtMovieName.Text);
        com.Parameters.AddWithValue("@Date", lblDate.Text);
        com.Parameters.AddWithValue("@Time", lblShwTime.Text);
        com.Parameters.AddWithValue("@Class", lblClass.Text);
        com.Parameters.AddWithValue("@Total_Amt", lblAmtPyble.Text);
        com.ExecuteNonQuery();
        
        if(Session["a1"]!=null)
        {
            SqlCommand cmd=new SqlCommand();
            cmd.Connection=conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["a1"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["a2"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["a2"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["a3"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["a3"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["a4"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["a4"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["a5"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["a5"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["a6"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["a6"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["a7"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["a7"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["a8"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["a8"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["a9"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["a9"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["a10"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["a10"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["a11"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["a11"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["a12"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["a12"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }




        if (Session["b1"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["b1"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["b2"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["b2"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["b3"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["b3"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["b4"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["b4"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["b5"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["b5"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["b6"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["b6"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["b7"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["b7"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["b8"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["b8"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["b9"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["b9"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["b10"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["b10"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["b11"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["b11"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["b12"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["b12"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }




        if (Session["c1"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["c1"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["c2"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["c2"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["c3"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["c3"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["c4"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["c4"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["c5"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["c5"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["c6"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["c6"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["c7"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["c7"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["c8"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["c8"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["c9"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["c9"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["c10"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["c10"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["c11"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["c11"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["c12"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["c12"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }



        if (Session["d1"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["d1"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["d2"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["d2"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["d3"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["d3"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["d4"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["d4"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["d5"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["d5"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["d6"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["d6"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["d7"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["d7"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["d8"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["d8"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["d9"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["d9"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["d10"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["d10"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["d11"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["d11"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["d12"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["d12"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }



        if (Session["e1"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["e1"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["e2"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["e2"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["e3"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["e3"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["e4"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["e4"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["e5"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["e5"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["e6"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["e6"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["e7"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["e7"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["e8"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["e8"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["e9"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["e9"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["e10"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["e10"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["e11"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["e11"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["e12"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["e12"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }



        if (Session["f1"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["f1"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["f2"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["f2"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["f3"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["f3"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["f4"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["f4"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["f5"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["f5"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["f6"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["f6"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["f7"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["f7"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["f8"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["f8"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["f9"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["f9"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["f10"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["f10"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["f11"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["f11"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["f12"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["f12"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }



        if (Session["g1"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["g1"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["g2"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["g2"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["g3"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["g3"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["g4"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["g4"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["g5"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["g5"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["g6"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["g6"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["g7"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["g7"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["g8"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["g8"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["g9"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["g9"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["g10"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["g10"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["g11"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["g11"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["g12"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["g12"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }



        if (Session["h1"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["h1"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["h2"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["h2"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["h3"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["h3"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["h4"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["h4"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["h5"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["h5"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["h6"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["h6"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["h7"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["h7"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["h8"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["h8"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["h9"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["h9"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["h10"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["h10"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["h11"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["h11"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["h12"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["h12"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }



        if (Session["i1"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["i1"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["i2"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["i2"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["i3"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["i3"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["i4"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["i4"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["i5"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["i5"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["i6"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["i6"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["i7"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["i7"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["i8"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["i8"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["i9"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["i9"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["i10"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["i10"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["i11"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["i11"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["i12"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["i12"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["j1"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["j1"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["j2"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["j2"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["j3"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["j3"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["j4"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["j4"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["j5"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["j5"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["j6"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["j6"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["j7"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["j7"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["j8"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["j8"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["j9"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["j9"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["j10"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["j10"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["j11"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["j11"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }

        if (Session["j12"] != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update seatBooking set booked='yes' where seat_no='" + Session["j12"].ToString() + "'";
            cmd.ExecuteNonQuery();
        }


        Response.Write("<script>alert('Booking is Sucessfull...')</script>");
        Server.Transfer("~/HomePage.aspx");



        }
    protected void btnBillproceed_Click(object sender, EventArgs e)
    {
        panelAll.Visible = true;
        btnBillproceed.Enabled = false;
    }
}