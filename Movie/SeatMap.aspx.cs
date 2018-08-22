using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    public int i;
    public int p;
    public int j;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (ddlClass.SelectedIndex == 1)
        {
            Session["Class"] =  ddlClass.Text;
        }
        if (ddlClass.SelectedIndex == 2)
        {
            Session["Class"] = ddlClass.Text;
        }
        if (lblg.Text != "")
        {
            Session["TickitPrice"] = txtTotal.Text;
        }
        if (lbls.Text != "")
        {
            Session["TickitPrice"] = txtTotal.Text;
        }
        
        
        
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringregis"].ConnectionString);
        conn.Open();
        if(!IsPostBack)
        {
            if (true)
            {
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = conn;
                cmd1.CommandText = "Select * from seatBooking where seat_no='A1' and booked='YES'";
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                if (dt1.Rows.Count > 0)
                {
                    C1.Checked = true;
                    C1.Enabled = false;
                   // Session["A1"] = C1.Text;
                }
                else
                {
                    C1.Checked = false;
                }
              

                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = conn;
                cmd2.CommandText = "Select * from seatBooking where seat_no='A2' and booked='YES'";
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                if (dt2.Rows.Count > 0)
                {
                    C2.Checked = true;
                    C2.Enabled = false;
                    //Session["A2"] = C2.Text;
                }
                else
                {
                    C2.Checked = false;
                }

                SqlCommand cmd3 = new SqlCommand();
                cmd3.Connection = conn;
                cmd3.CommandText = "Select * from seatBooking where seat_no='A3' and booked='YES'";
                SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                if (dt3.Rows.Count > 0)
                {
                    C3.Checked = true;
                    C3.Enabled = false;
                    //Session["A3"] = C3.Text;
                }
                else
                {
                    C3.Checked = false;
                }

                SqlCommand cmd4 = new SqlCommand();
                cmd4.Connection = conn;
                cmd4.CommandText = "Select * from seatBooking where seat_no='A4' and booked='YES'";
                SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
                DataTable dt4 = new DataTable();
                da4.Fill(dt4);
                if (dt4.Rows.Count > 0)
                {
                    C4.Checked = true;
                    C4.Enabled = false;
                    //Session["A4"] = C4.Text;
                }
                else
                {
                    C4.Checked = false;
                }

                SqlCommand cmd5 = new SqlCommand();
                cmd5.Connection = conn;
                cmd5.CommandText = "Select * from seatBooking where seat_no='A5' and booked='YES'";
                SqlDataAdapter da5 = new SqlDataAdapter(cmd5);
                DataTable dt5 = new DataTable();
                da5.Fill(dt5);
                if (dt5.Rows.Count > 0)
                {
                    C5.Checked = true;
                    C5.Enabled = false;
                    //Session["A5"] = C5.Text;
                }

                else
                {
                    C5.Checked = false;
                }

                SqlCommand cmd6 = new SqlCommand();
                cmd6.Connection = conn;
                cmd6.CommandText = "Select * from seatBooking where seat_no='A6' and booked='YES'";
                SqlDataAdapter da6 = new SqlDataAdapter(cmd6);
                DataTable dt6 = new DataTable();
                da6.Fill(dt6);
                if (dt6.Rows.Count > 0)
                {
                    C6.Checked = true;
                    C6.Enabled = false;
                    //Session["A6"] = C6.Text;
                }
                else
                {
                    C6.Checked = false;
                }

                SqlCommand cmd7 = new SqlCommand();
                cmd7.Connection = conn;
                cmd7.CommandText = "Select * from seatBooking where seat_no='A7' and booked='YES'";
                SqlDataAdapter da7 = new SqlDataAdapter(cmd7);
                DataTable dt7 = new DataTable();
                da7.Fill(dt7);
                if (dt7.Rows.Count > 0)
                {
                    C7.Checked = true;
                    C7.Enabled = false;
                }
                else
                {
                    C7.Checked = false;
                }

                SqlCommand cmd8 = new SqlCommand();
                cmd8.Connection = conn;
                cmd8.CommandText = "Select * from seatBooking where seat_no='A8' and booked='YES'";
                SqlDataAdapter da8 = new SqlDataAdapter(cmd8);
                DataTable dt8 = new DataTable();
                da8.Fill(dt8);
                if (dt8.Rows.Count > 0)
                {
                    C8.Checked = true;
                    C8.Enabled = false;
                }
                else
                {
                    C8.Checked = false;
                }

                SqlCommand cmd9 = new SqlCommand();
                cmd9.Connection = conn;
                cmd9.CommandText = "Select * from seatBooking where seat_no='A9' and booked='YES'";
                SqlDataAdapter da9 = new SqlDataAdapter(cmd9);
                DataTable dt9 = new DataTable();
                da9.Fill(dt9);
                if (dt9.Rows.Count > 0)
                {
                    C9.Checked = true;
                    C9.Enabled = false;
                }
                else
                {
                    C9.Checked = false;
                }

                SqlCommand cmd10 = new SqlCommand();
                cmd10.Connection = conn;
                cmd10.CommandText = "Select * from seatBooking where seat_no='A10' and booked='YES'";
                SqlDataAdapter da10 = new SqlDataAdapter(cmd10);
                DataTable dt10 = new DataTable();
                da10.Fill(dt10);
                if (dt10.Rows.Count > 0)
                {
                    C10.Checked = true;
                    C10.Enabled = false;
                }
                else
                {
                    C10.Checked = false;
                }

                SqlCommand cmd11 = new SqlCommand();
                cmd11.Connection = conn;
                cmd11.CommandText = "Select * from seatBooking where seat_no='A11' and booked='YES'";
                SqlDataAdapter da11 = new SqlDataAdapter(cmd11);
                DataTable dt11 = new DataTable();
                da11.Fill(dt11);
                if (dt11.Rows.Count > 0)
                {
                    C11.Checked = true;
                    C11.Enabled = false;
                }
                else
                {
                    C11.Checked = false;
                }

                SqlCommand cmd12 = new SqlCommand();
                cmd12.Connection = conn;
                cmd12.CommandText = "Select * from seatBooking where seat_no='A12' and booked='YES'";
                SqlDataAdapter da12 = new SqlDataAdapter(cmd12);
                DataTable dt12 = new DataTable();
                da12.Fill(dt12);
                if (dt12.Rows.Count > 0)
                {
                    C12.Checked = true;
                    C12.Enabled = false;
                }
                else
                {
                    C12.Checked = false;
                }


                SqlCommand cmd13 = new SqlCommand();
                cmd13.Connection = conn;
                cmd13.CommandText = "Select * from seatBooking where seat_no='B1' and booked='YES'";
                SqlDataAdapter da13 = new SqlDataAdapter(cmd13);
                DataTable dt13 = new DataTable();
                da13.Fill(dt13);
                if (dt13.Rows.Count > 0)
                {
                    C13.Checked = true;
                    C13.Enabled = false;
                }
                else
                {
                    C13.Checked = false;
                }

                SqlCommand cmd14 = new SqlCommand();
                cmd14.Connection = conn;
                cmd14.CommandText = "Select * from seatBooking where seat_no='B2' and booked='YES'";
                SqlDataAdapter da14 = new SqlDataAdapter(cmd14);
                DataTable dt14 = new DataTable();
                da14.Fill(dt14);
                if (dt14.Rows.Count > 0)
                {
                    C14.Checked = true;
                    C14.Enabled = false;
                }
                else
                {
                    C14.Checked = false;
                }

                SqlCommand cmd15 = new SqlCommand();
                cmd15.Connection = conn;
                cmd15.CommandText = "Select * from seatBooking where seat_no='B3' and booked='YES'";
                SqlDataAdapter da15 = new SqlDataAdapter(cmd15);
                DataTable dt15 = new DataTable();
                da15.Fill(dt15);
                if (dt15.Rows.Count > 0)
                {
                    C15.Checked = true;
                    C15.Enabled = false;
                }
                else
                {
                    C15.Checked = false;
                }

                SqlCommand cmd16 = new SqlCommand();
                cmd16.Connection = conn;
                cmd16.CommandText = "Select * from seatBooking where seat_no='B4' and booked='YES'";
                SqlDataAdapter da16 = new SqlDataAdapter(cmd16);
                DataTable dt16 = new DataTable();
                da16.Fill(dt16);
                if (dt16.Rows.Count > 0)
                {
                    C16.Checked = true;
                    C16.Enabled = false;
                }
                else
                {
                    C16.Checked = false;
                }

                SqlCommand cmd17 = new SqlCommand();
                cmd17.Connection = conn;
                cmd17.CommandText = "Select * from seatBooking where seat_no='B5' and booked='YES'";
                SqlDataAdapter da17 = new SqlDataAdapter(cmd17);
                DataTable dt17 = new DataTable();
                da1.Fill(dt17);
                if (dt17.Rows.Count > 0)
                {
                    C17.Checked = true;
                    C17.Enabled = false;
                }
                else
                {
                    C17.Checked = false;
                }

                SqlCommand cmd18 = new SqlCommand();
                cmd18.Connection = conn;
                cmd18.CommandText = "Select * from seatBooking where seat_no='B6' and booked='YES'";
                SqlDataAdapter da18 = new SqlDataAdapter(cmd18);
                DataTable dt18 = new DataTable();
                da18.Fill(dt18);
                if (dt18.Rows.Count > 0)
                {
                    C18.Checked = true;
                    C18.Enabled = false;
                }
                else
                {
                    C18.Checked = false;
                }

                SqlCommand cmd19 = new SqlCommand();
                cmd19.Connection = conn;
                cmd19.CommandText = "Select * from seatBooking where seat_no='B7' and booked='YES'";
                SqlDataAdapter da19 = new SqlDataAdapter(cmd19);
                DataTable dt19 = new DataTable();
                da19.Fill(dt19);
                if (dt19.Rows.Count > 0)
                {
                    C19.Checked = true;
                    C19.Enabled = false;
                }
                else
                {
                    C19.Checked = false;
                }

                SqlCommand cmd20 = new SqlCommand();
                cmd20.Connection = conn;
                cmd20.CommandText = "Select * from seatBooking where seat_no='B8' and booked='YES'";
                SqlDataAdapter da20 = new SqlDataAdapter(cmd20);
                DataTable dt20 = new DataTable();
                da20.Fill(dt20);
                if (dt20.Rows.Count > 0)
                {
                    C20.Checked = true;
                    C20.Enabled = false;
                }
                else
                {
                    C20.Checked = false;
                }

                SqlCommand cmd21 = new SqlCommand();
                cmd21.Connection = conn;
                cmd21.CommandText = "Select * from seatBooking where seat_no='B9' and booked='YES'";
                SqlDataAdapter da21 = new SqlDataAdapter(cmd21);
                DataTable dt21 = new DataTable();
                da21.Fill(dt21);
                if (dt21.Rows.Count > 0)
                {
                    C21.Checked = true;
                    C21.Enabled = false;
                }
                else
                {
                    C21.Checked = false;
                }

                SqlCommand cmd22 = new SqlCommand();
                cmd22.Connection = conn;
                cmd22.CommandText = "Select * from seatBooking where seat_no='B10' and booked='YES'";
                SqlDataAdapter da22 = new SqlDataAdapter(cmd22);
                DataTable dt22 = new DataTable();
                da22.Fill(dt10);
                if (dt22.Rows.Count > 0)
                {
                    C22.Checked = true;
                    C22.Enabled = false;
                }
                else
                {
                    C22.Checked = false;
                }

                SqlCommand cmd23 = new SqlCommand();
                cmd23.Connection = conn;
                cmd23.CommandText = "Select * from seatBooking where seat_no='B11' and booked='YES'";
                SqlDataAdapter da23 = new SqlDataAdapter(cmd23);
                DataTable dt23 = new DataTable();
                da23.Fill(dt23);
                if (dt23.Rows.Count > 0)
                {
                    C23.Checked = true;
                    C23.Enabled = false;
                }
                else
                {
                    C23.Checked = false;
                }

                SqlCommand cmd24 = new SqlCommand();
                cmd24.Connection = conn;
                cmd24.CommandText = "Select * from seatBooking where seat_no='B12' and booked='YES'";
                SqlDataAdapter da24 = new SqlDataAdapter(cmd24);
                DataTable dt24 = new DataTable();
                da24.Fill(dt24);
                if (dt24.Rows.Count > 0)
                {
                    C24.Checked = true;
                    C24.Enabled = false;
                }
                else
                {
                    C24.Checked = false;
                }


                SqlCommand cmd25 = new SqlCommand();
                cmd25.Connection = conn;
                cmd25.CommandText = "Select * from seatBooking where seat_no='C1' and booked='YES'";
                SqlDataAdapter da25 = new SqlDataAdapter(cmd25);
                DataTable dt25 = new DataTable();
                da25.Fill(dt1);
                if (dt25.Rows.Count > 0)
                {
                    C25.Checked = true;
                    C25.Enabled = false;
                }
                else
                {
                    C25.Checked = false;
                }

                SqlCommand cmd26 = new SqlCommand();
                cmd26.Connection = conn;
                cmd26.CommandText = "Select * from seatBooking where seat_no='C2' and booked='YES'";
                SqlDataAdapter da26 = new SqlDataAdapter(cmd26);
                DataTable dt26 = new DataTable();
                da26.Fill(dt26);
                if (dt26.Rows.Count > 0)
                {
                    C26.Checked = true;
                    C26.Enabled = false;
                }
                else
                {
                    C26.Checked = false;
                }

                SqlCommand cmd27 = new SqlCommand();
                cmd27.Connection = conn;
                cmd27.CommandText = "Select * from seatBooking where seat_no='C3' and booked='YES'";
                SqlDataAdapter da27 = new SqlDataAdapter(cmd27);
                DataTable dt27 = new DataTable();
                da27.Fill(dt27);
                if (dt27.Rows.Count > 0)
                {
                    C27.Checked = true;
                    C27.Enabled = false;
                }
                else
                {
                    C27.Checked = false;
                }

                SqlCommand cmd28 = new SqlCommand();
                cmd28.Connection = conn;
                cmd28.CommandText = "Select * from seatBooking where seat_no='C4' and booked='YES'";
                SqlDataAdapter da28 = new SqlDataAdapter(cmd28);
                DataTable dt28 = new DataTable();
                da28.Fill(dt28);
                if (dt28.Rows.Count > 0)
                {
                    C28.Checked = true;
                    C28.Enabled = false;
                }
                else
                {
                    C28.Checked = false;
                }

                SqlCommand cmd29 = new SqlCommand();
                cmd29.Connection = conn;
                cmd29.CommandText = "Select * from seatBooking where seat_no='C5' and booked='YES'";
                SqlDataAdapter da29 = new SqlDataAdapter(cmd29);
                DataTable dt29 = new DataTable();
                da29.Fill(dt29);
                if (dt29.Rows.Count > 0)
                {
                    C29.Checked = true;
                    C29.Enabled = false;
                }
                else
                {
                    C29.Checked = false;
                }

                SqlCommand cmd30 = new SqlCommand();
                cmd30.Connection = conn;
                cmd30.CommandText = "Select * from seatBooking where seat_no='C6' and booked='YES'";
                SqlDataAdapter da30 = new SqlDataAdapter(cmd30);
                DataTable dt30 = new DataTable();
                da30.Fill(dt30);
                if (dt30.Rows.Count > 0)
                {
                    C30.Checked = true;
                    C30.Enabled = false;
                }
                else
                {
                    C30.Checked = false;
                }

                SqlCommand cmd31 = new SqlCommand();
                cmd31.Connection = conn;
                cmd31.CommandText = "Select * from seatBooking where seat_no='C7' and booked='YES'";
                SqlDataAdapter da31 = new SqlDataAdapter(cmd31);
                DataTable dt31 = new DataTable();
                da31.Fill(dt31);
                if (dt31.Rows.Count > 0)
                {
                    C31.Checked = true;
                    C31.Enabled = false;
                }
                else
                {
                    C31.Checked = false;
                }

                SqlCommand cmd32 = new SqlCommand();
                cmd32.Connection = conn;
                cmd32.CommandText = "Select * from seatBooking where seat_no='C8' and booked='YES'";
                SqlDataAdapter da32 = new SqlDataAdapter(cmd32);
                DataTable dt32 = new DataTable();
                da32.Fill(dt32);
                if (dt32.Rows.Count > 0)
                {
                    C32.Checked = true;
                    C32.Enabled = false;
                }
                else
                {
                    C32.Checked = false;
                }

                SqlCommand cmd33 = new SqlCommand();
                cmd33.Connection = conn;
                cmd33.CommandText = "Select * from seatBooking where seat_no='C9' and booked='YES'";
                SqlDataAdapter da33 = new SqlDataAdapter(cmd33);
                DataTable dt33 = new DataTable();
                da33.Fill(dt33);
                if (dt33.Rows.Count > 0)
                {
                    C33.Checked = true;
                    C33.Enabled = false;
                }
                else
                {
                    C33.Checked = false;
                }

                SqlCommand cmd34 = new SqlCommand();
                cmd34.Connection = conn;
                cmd34.CommandText = "Select * from seatBooking where seat_no='C10' and booked='YES'";
                SqlDataAdapter da34 = new SqlDataAdapter(cmd34);
                DataTable dt34 = new DataTable();
                da34.Fill(dt34);
                if (dt34.Rows.Count > 0)
                {
                    C34.Checked = true;
                    C34.Enabled = false;
                }
                else
                {
                    C34.Checked = false;
                }

                SqlCommand cmd35 = new SqlCommand();
                cmd35.Connection = conn;
                cmd35.CommandText = "Select * from seatBooking where seat_no='C11' and booked='YES'";
                SqlDataAdapter da35 = new SqlDataAdapter(cmd35);
                DataTable dt35 = new DataTable();
                da35.Fill(dt35);
                if (dt35.Rows.Count > 0)
                {
                    C35.Checked = true;
                    C35.Enabled = false;
                }
                else
                {
                    C35.Checked = false;
                }

                SqlCommand cmd36 = new SqlCommand();
                cmd36.Connection = conn;
                cmd36.CommandText = "Select * from seatBooking where seat_no='C12' and booked='YES'";
                SqlDataAdapter da36 = new SqlDataAdapter(cmd36);
                DataTable dt36 = new DataTable();
                da36.Fill(dt36);
                if (dt36.Rows.Count > 0)
                {
                    C36.Checked = true;
                    C36.Enabled = false;
                }
                else
                {
                    C36.Checked = false;
                }



                SqlCommand cmd37 = new SqlCommand();
                cmd37.Connection = conn;
                cmd37.CommandText = "Select * from seatBooking where seat_no='D1' and booked='YES'";
                SqlDataAdapter da37 = new SqlDataAdapter(cmd37);
                DataTable dt37 = new DataTable();
                da37.Fill(dt37);
                if (dt37.Rows.Count > 0)
                {
                    C37.Checked = true;
                    C37.Enabled = false;
                }
                else
                {
                    C37.Checked = false;
                }

                SqlCommand cmd38 = new SqlCommand();
                cmd38.Connection = conn;
                cmd38.CommandText = "Select * from seatBooking where seat_no='D2' and booked='YES'";
                SqlDataAdapter da38 = new SqlDataAdapter(cmd38);
                DataTable dt38 = new DataTable();
                da38.Fill(dt38);
                if (dt38.Rows.Count > 0)
                {
                    C38.Checked = true;
                    C38.Enabled = false;
                }
                else
                {
                    C38.Checked = false;
                }

                SqlCommand cmd39 = new SqlCommand();
                cmd39.Connection = conn;
                cmd39.CommandText = "Select * from seatBooking where seat_no='D3' and booked='YES'";
                SqlDataAdapter da39 = new SqlDataAdapter(cmd39);
                DataTable dt39 = new DataTable();
                da39.Fill(dt3);
                if (dt39.Rows.Count > 0)
                {
                    C39.Checked = true;
                    C39.Enabled = false;
                }
                else
                {
                    C39.Checked = false;
                }

                SqlCommand cmd40 = new SqlCommand();
                cmd40.Connection = conn;
                cmd40.CommandText = "Select * from seatBooking where seat_no='D4' and booked='YES'";
                SqlDataAdapter da40 = new SqlDataAdapter(cmd40);
                DataTable dt40 = new DataTable();
                da40.Fill(dt40);
                if (dt40.Rows.Count > 0)
                {
                    C40.Checked = true;
                    C40.Enabled = false;
                }
                else
                {
                    C40.Checked = false;
                }

                SqlCommand cmd41 = new SqlCommand();
                cmd41.Connection = conn;
                cmd41.CommandText = "Select * from seatBooking where seat_no='D5' and booked='YES'";
                SqlDataAdapter da41 = new SqlDataAdapter(cmd41);
                DataTable dt41 = new DataTable();
                da41.Fill(dt41);
                if (dt41.Rows.Count > 0)
                {
                    C41.Checked = true;
                    C41.Enabled = false;
                }
                else
                {
                    C41.Checked = false;
                }

                SqlCommand cmd42 = new SqlCommand();
                cmd42.Connection = conn;
                cmd42.CommandText = "Select * from seatBooking where seat_no='D6' and booked='YES'";
                SqlDataAdapter da42 = new SqlDataAdapter(cmd42);
                DataTable dt42 = new DataTable();
                da42.Fill(dt42);
                if (dt42.Rows.Count > 0)
                {
                    C42.Checked = true;
                    C42.Enabled = false;
                }
                else
                {
                    C42.Checked = false;
                }

                SqlCommand cmd43 = new SqlCommand();
                cmd43.Connection = conn;
                cmd43.CommandText = "Select * from seatBooking where seat_no='D7' and booked='YES'";
                SqlDataAdapter da43 = new SqlDataAdapter(cmd43);
                DataTable dt43 = new DataTable();
                da43.Fill(dt43);
                if (dt43.Rows.Count > 0)
                {
                    C43.Checked = true;
                    C43.Enabled = false;
                }
                else
                {
                    C43.Checked = false;
                }

                SqlCommand cmd44 = new SqlCommand();
                cmd44.Connection = conn;
                cmd44.CommandText = "Select * from seatBooking where seat_no='D8' and booked='YES'";
                SqlDataAdapter da44 = new SqlDataAdapter(cmd44);
                DataTable dt44 = new DataTable();
                da44.Fill(dt44);
                if (dt44.Rows.Count > 0)
                {
                    C44.Checked = true;
                    C44.Enabled = false;
                }
                else
                {
                    C44.Checked = false;
                }

                SqlCommand cmd45 = new SqlCommand();
                cmd45.Connection = conn;
                cmd45.CommandText = "Select * from seatBooking where seat_no='D9' and booked='YES'";
                SqlDataAdapter da45 = new SqlDataAdapter(cmd45);
                DataTable dt45 = new DataTable();
                da45.Fill(dt45);
                if (dt45.Rows.Count > 0)
                {
                    C45.Checked = true;
                    C45.Enabled = false;
                }
                else
                {
                    C45.Checked = false;
                }

                SqlCommand cmd46 = new SqlCommand();
                cmd46.Connection = conn;
                cmd46.CommandText = "Select * from seatBooking where seat_no='D10' and booked='YES'";
                SqlDataAdapter da46 = new SqlDataAdapter(cmd46);
                DataTable dt46 = new DataTable();
                da46.Fill(dt46);
                if (dt46.Rows.Count > 0)
                {
                    C46.Checked = true;
                    C46.Enabled = false;
                }
                else
                {
                    C46.Checked = false;
                }

                SqlCommand cmd47 = new SqlCommand();
                cmd47.Connection = conn;
                cmd47.CommandText = "Select * from seatBooking where seat_no='D11' and booked='YES'";
                SqlDataAdapter da47 = new SqlDataAdapter(cmd47);
                DataTable dt47 = new DataTable();
                da47.Fill(dt47);
                if (dt47.Rows.Count > 0)
                {
                    C47.Checked = true;
                    C47.Enabled = false;
                }
                else
                {
                    C47.Checked = false;
                }

                SqlCommand cmd48 = new SqlCommand();
                cmd48.Connection = conn;
                cmd48.CommandText = "Select * from seatBooking where seat_no='D12' and booked='YES'";
                SqlDataAdapter da48 = new SqlDataAdapter(cmd48);
                DataTable dt48 = new DataTable();
                da48.Fill(dt48);
                if (dt48.Rows.Count > 0)
                {
                    C48.Checked = true;
                    C48.Enabled = false;
                }
                else
                {
                    C48.Checked = false;
                }



                SqlCommand cmd49 = new SqlCommand();
                cmd49.Connection = conn;
                cmd49.CommandText = "Select * from seatBooking where seat_no='E1' and booked='YES'";
                SqlDataAdapter da49 = new SqlDataAdapter(cmd49);
                DataTable dt49 = new DataTable();
                da49.Fill(dt49);
                if (dt49.Rows.Count > 0)
                {
                    C49.Checked = true;
                    C49.Enabled = false;
                }
                else
                {
                    C49.Checked = false;
                }

                SqlCommand cmd50 = new SqlCommand();
                cmd50.Connection = conn;
                cmd50.CommandText = "Select * from seatBooking where seat_no='E2' and booked='YES'";
                SqlDataAdapter da50 = new SqlDataAdapter(cmd50);
                DataTable dt50 = new DataTable();
                da50.Fill(dt50);
                if (dt50.Rows.Count > 0)
                {
                    C50.Checked = true;
                    C50.Enabled = false;
                }
                else
                {
                    C50.Checked = false;
                }

                SqlCommand cmd51 = new SqlCommand();
                cmd51.Connection = conn;
                cmd51.CommandText = "Select * from seatBooking where seat_no='E3' and booked='YES'";
                SqlDataAdapter da51 = new SqlDataAdapter(cmd51);
                DataTable dt51 = new DataTable();
                da51.Fill(dt51);
                if (dt51.Rows.Count > 0)
                {
                    C51.Checked = true;
                    C51.Enabled = false;
                }
                else
                {
                    C51.Checked = false;
                }

                SqlCommand cmd52 = new SqlCommand();
                cmd52.Connection = conn;
                cmd52.CommandText = "Select * from seatBooking where seat_no='E4' and booked='YES'";
                SqlDataAdapter da52 = new SqlDataAdapter(cmd52);
                DataTable dt52 = new DataTable();
                da52.Fill(dt52);
                if (dt52.Rows.Count > 0)
                {
                    C52.Checked = true;
                    C52.Enabled = false;
                }
                else
                {
                    C52.Checked = false;
                }

                SqlCommand cmd53 = new SqlCommand();
                cmd53.Connection = conn;
                cmd53.CommandText = "Select * from seatBooking where seat_no='E5' and booked='YES'";
                SqlDataAdapter da53 = new SqlDataAdapter(cmd53);
                DataTable dt53 = new DataTable();
                da53.Fill(dt53);
                if (dt53.Rows.Count > 0)
                {
                    C53.Checked = true;
                    C53.Enabled = false;
                }
                else
                {
                    C53.Checked = false;
                }

                SqlCommand cmd54 = new SqlCommand();
                cmd54.Connection = conn;
                cmd54.CommandText = "Select * from seatBooking where seat_no='E6' and booked='YES'";
                SqlDataAdapter da54 = new SqlDataAdapter(cmd54);
                DataTable dt54 = new DataTable();
                da54.Fill(dt54);
                if (dt54.Rows.Count > 0)
                {
                    C54.Checked = true;
                    C54.Enabled = false;
                }
                else
                {
                    C54.Checked = false;
                }

                SqlCommand cmd55 = new SqlCommand();
                cmd55.Connection = conn;
                cmd55.CommandText = "Select * from seatBooking where seat_no='E7' and booked='YES'";
                SqlDataAdapter da55 = new SqlDataAdapter(cmd55);
                DataTable dt55 = new DataTable();
                da55.Fill(dt55);
                if (dt55.Rows.Count > 0)
                {
                    C55.Checked = true;
                    C55.Enabled = false;
                }
                else
                {
                    C55.Checked = false;
                }

                SqlCommand cmd56 = new SqlCommand();
                cmd56.Connection = conn;
                cmd56.CommandText = "Select * from seatBooking where seat_no='E8' and booked='YES'";
                SqlDataAdapter da56 = new SqlDataAdapter(cmd56);
                DataTable dt56 = new DataTable();
                da56.Fill(dt56);
                if (dt56.Rows.Count > 0)
                {
                    C56.Checked = true;
                    C56.Enabled = false;
                }
                else
                {
                    C56.Checked = false;
                }

                SqlCommand cmd57 = new SqlCommand();
                cmd57.Connection = conn;
                cmd57.CommandText = "Select * from seatBooking where seat_no='E9' and booked='YES'";
                SqlDataAdapter da57 = new SqlDataAdapter(cmd57);
                DataTable dt57 = new DataTable();
                da57.Fill(dt57);
                if (dt57.Rows.Count > 0)
                {
                    C57.Checked = true;
                    C57.Enabled = false;
                }
                else
                {
                    C57.Checked = false;
                }

                SqlCommand cmd58 = new SqlCommand();
                cmd58.Connection = conn;
                cmd58.CommandText = "Select * from seatBooking where seat_no='E10' and booked='YES'";
                SqlDataAdapter da58 = new SqlDataAdapter(cmd58);
                DataTable dt58 = new DataTable();
                da58.Fill(dt58);
                if (dt58.Rows.Count > 0)
                {
                    C58.Checked = true;
                    C58.Enabled = false;
                }
                else
                {
                    C58.Checked = false;
                }

                SqlCommand cmd59 = new SqlCommand();
                cmd59.Connection = conn;
                cmd59.CommandText = "Select * from seatBooking where seat_no='E11' and booked='YES'";
                SqlDataAdapter da59 = new SqlDataAdapter(cmd59);
                DataTable dt59 = new DataTable();
                da59.Fill(dt59);
                if (dt59.Rows.Count > 0)
                {
                    C59.Checked = true;
                    C59.Enabled = false;
                }
                else
                {
                    C59.Checked = false;
                }

                SqlCommand cmd60 = new SqlCommand();
                cmd60.Connection = conn;
                cmd60.CommandText = "Select * from seatBooking where seat_no='E12' and booked='YES'";
                SqlDataAdapter da60 = new SqlDataAdapter(cmd60);
                DataTable dt60 = new DataTable();
                da60.Fill(dt60);
                if (dt60.Rows.Count > 0)
                {
                    C60.Checked = true;
                    C60.Enabled = false;
                }
                else
                {
                    C60.Checked = false;
                }


                SqlCommand cmd61 = new SqlCommand();
                cmd61.Connection = conn;
                cmd61.CommandText = "Select * from seatBooking where seat_no='F1' and booked='YES'";
                SqlDataAdapter da61 = new SqlDataAdapter(cmd61);
                DataTable dt61 = new DataTable();
                da61.Fill(dt61);
                if (dt61.Rows.Count > 0)
                {
                    C61.Checked = true;
                    C61.Enabled = false;
                }
                else
                {
                    C61.Checked = false;
                }

                SqlCommand cmd62 = new SqlCommand();
                cmd62.Connection = conn;
                cmd62.CommandText = "Select * from seatBooking where seat_no='F2' and booked='YES'";
                SqlDataAdapter da62 = new SqlDataAdapter(cmd62);
                DataTable dt62 = new DataTable();
                da62.Fill(dt62);
                if (dt62.Rows.Count > 0)
                {
                    C62.Checked = true;
                    C62.Enabled = false;
                }
                else
                {
                    C62.Checked = false;
                }

                SqlCommand cmd63 = new SqlCommand();
                cmd63.Connection = conn;
                cmd63.CommandText = "Select * from seatBooking where seat_no='F3' and booked='YES'";
                SqlDataAdapter da63 = new SqlDataAdapter(cmd63);
                DataTable dt63 = new DataTable();
                da63.Fill(dt63);
                if (dt63.Rows.Count > 0)
                {
                    C63.Checked = true;
                    C63.Enabled = false;
                }
                else
                {
                    C63.Checked = false;
                }

                SqlCommand cmd64 = new SqlCommand();
                cmd64.Connection = conn;
                cmd64.CommandText = "Select * from seatBooking where seat_no='F4' and booked='YES'";
                SqlDataAdapter da64 = new SqlDataAdapter(cmd64);
                DataTable dt64 = new DataTable();
                da64.Fill(dt4);
                if (dt64.Rows.Count > 0)
                {
                    C64.Checked = true;
                    C64.Enabled = false;
                }
                else
                {
                    C64.Checked = false;
                }

                SqlCommand cmd65 = new SqlCommand();
                cmd65.Connection = conn;
                cmd65.CommandText = "Select * from seatBooking where seat_no='F5' and booked='YES'";
                SqlDataAdapter da65 = new SqlDataAdapter(cmd65);
                DataTable dt65 = new DataTable();
                da65.Fill(dt65);
                if (dt65.Rows.Count > 0)
                {
                    C65.Checked = true;
                    C65.Enabled = false;
                }
                else
                {
                    C65.Checked = false;
                }

                SqlCommand cmd66 = new SqlCommand();
                cmd66.Connection = conn;
                cmd66.CommandText = "Select * from seatBooking where seat_no='F6' and booked='YES'";
                SqlDataAdapter da66 = new SqlDataAdapter(cmd66);
                DataTable dt66 = new DataTable();
                da66.Fill(dt66);
                if (dt66.Rows.Count > 0)
                {
                    C66.Checked = true;
                    C66.Enabled = false;
                }
                else
                {
                    C66.Checked = false;
                }

                SqlCommand cmd67 = new SqlCommand();
                cmd67.Connection = conn;
                cmd67.CommandText = "Select * from seatBooking where seat_no='F7' and booked='YES'";
                SqlDataAdapter da67 = new SqlDataAdapter(cmd67);
                DataTable dt67 = new DataTable();
                da67.Fill(dt67);
                if (dt67.Rows.Count > 0)
                {
                    C67.Checked = true;
                    C67.Enabled = false;
                }
                else
                {
                    C67.Checked = false;
                }

                SqlCommand cmd68 = new SqlCommand();
                cmd68.Connection = conn;
                cmd68.CommandText = "Select * from seatBooking where seat_no='F8' and booked='YES'";
                SqlDataAdapter da68 = new SqlDataAdapter(cmd68);
                DataTable dt68 = new DataTable();
                da68.Fill(dt68);
                if (dt68.Rows.Count > 0)
                {
                    C68.Checked = true;
                    C68.Enabled = false;
                }
                else
                {
                    C68.Checked = false;
                }

                SqlCommand cmd69 = new SqlCommand();
                cmd69.Connection = conn;
                cmd69.CommandText = "Select * from seatBooking where seat_no='F9' and booked='YES'";
                SqlDataAdapter da69 = new SqlDataAdapter(cmd69);
                DataTable dt69 = new DataTable();
                da69.Fill(dt69);
                if (dt69.Rows.Count > 0)
                {
                    C69.Checked = true;
                    C69.Enabled = false;
                }
                else
                {
                    C69.Checked = false;
                }

                SqlCommand cmd70 = new SqlCommand();
                cmd70.Connection = conn;
                cmd70.CommandText = "Select * from seatBooking where seat_no='F10' and booked='YES'";
                SqlDataAdapter da70 = new SqlDataAdapter(cmd70);
                DataTable dt70 = new DataTable();
                da70.Fill(dt70);
                if (dt70.Rows.Count > 0)
                {
                    C70.Checked = true;
                    C70.Enabled = false;
                }
                else
                {
                    C70.Checked = false;
                }

                SqlCommand cmd71 = new SqlCommand();
                cmd71.Connection = conn;
                cmd71.CommandText = "Select * from seatBooking where seat_no='F11' and booked='YES'";
                SqlDataAdapter da71 = new SqlDataAdapter(cmd71);
                DataTable dt71 = new DataTable();
                da71.Fill(dt71);
                if (dt71.Rows.Count > 0)
                {
                    C71.Checked = true;
                    C71.Enabled = false;
                }
                else
                {
                    C71.Checked = false;
                }

                SqlCommand cmd72 = new SqlCommand();
                cmd72.Connection = conn;
                cmd72.CommandText = "Select * from seatBooking where seat_no='F12' and booked='YES'";
                SqlDataAdapter da72 = new SqlDataAdapter(cmd72);
                DataTable dt72 = new DataTable();
                da72.Fill(dt72);
                if (dt72.Rows.Count > 0)
                {
                    C72.Checked = true;
                    C72.Enabled = false;
                }
                else
                {
                    C72.Checked = false;
                }

                SqlCommand cmd73 = new SqlCommand();
                cmd73.Connection = conn;
                cmd73.CommandText = "Select * from seatBooking where seat_no='G1' and booked='YES'";
                SqlDataAdapter da73 = new SqlDataAdapter(cmd73);
                DataTable dt73 = new DataTable();
                da73.Fill(dt73);
                if (dt73.Rows.Count > 0)
                {
                    C73.Checked = true;
                    C73.Enabled = false;
                    //Session["G1"] = C73.Text;
                }
                else
                {
                    C73.Checked = false;
                }

                SqlCommand cmd74 = new SqlCommand();
                cmd74.Connection = conn;
                cmd74.CommandText = "Select * from seatBooking where seat_no='G2' and booked='YES'";
                SqlDataAdapter da74 = new SqlDataAdapter(cmd74);
                DataTable dt74 = new DataTable();
                da74.Fill(dt74);
                if (dt74.Rows.Count > 0)
                {
                    C74.Checked = true;
                    C74.Enabled = false;
                }
                else
                {
                    C74.Checked = false;
                }

                SqlCommand cmd75 = new SqlCommand();
                cmd75.Connection = conn;
                cmd75.CommandText = "Select * from seatBooking where seat_no='G3' and booked='YES'";
                SqlDataAdapter da75 = new SqlDataAdapter(cmd75);
                DataTable dt75 = new DataTable();
                da75.Fill(dt75);
                if (dt75.Rows.Count > 0)
                {
                    C75.Checked = true;
                    C75.Enabled = false;
                }
                else
                {
                    C75.Checked = false;
                }

                SqlCommand cmd76 = new SqlCommand();
                cmd76.Connection = conn;
                cmd76.CommandText = "Select * from seatBooking where seat_no='G4' and booked='YES'";
                SqlDataAdapter da76 = new SqlDataAdapter(cmd76);
                DataTable dt76 = new DataTable();
                da76.Fill(dt76);
                if (dt76.Rows.Count > 0)
                {
                    C76.Checked = true;
                    C76.Enabled = false;
                }
                else
                {
                    C76.Checked = false;
                }

                SqlCommand cmd77 = new SqlCommand();
                cmd77.Connection = conn;
                cmd77.CommandText = "Select * from seatBooking where seat_no='G5' and booked='YES'";
                SqlDataAdapter da77 = new SqlDataAdapter(cmd77);
                DataTable dt77 = new DataTable();
                da77.Fill(dt77);
                if (dt77.Rows.Count > 0)
                {
                    C77.Checked = true;
                    C77.Enabled = false;
                }
                else
                {
                    C77.Checked = false;
                }

                SqlCommand cmd78 = new SqlCommand();
                cmd78.Connection = conn;
                cmd78.CommandText = "Select * from seatBooking where seat_no='G6' and booked='YES'";
                SqlDataAdapter da78 = new SqlDataAdapter(cmd78);
                DataTable dt78 = new DataTable();
                da78.Fill(dt78);
                if (dt78.Rows.Count > 0)
                {
                    C78.Checked = true;
                    C78.Enabled = false;
                }
                else
                {
                    C78.Checked = false;
                }

                SqlCommand cmd79 = new SqlCommand();
                cmd79.Connection = conn;
                cmd79.CommandText = "Select * from seatBooking where seat_no='G7' and booked='YES'";
                SqlDataAdapter da79 = new SqlDataAdapter(cmd79);
                DataTable dt79 = new DataTable();
                da79.Fill(dt79);
                if (dt79.Rows.Count > 0)
                {
                    C79.Checked = true;
                    C79.Enabled = false;
                }
                else
                {
                    C79.Checked = false;
                }

                SqlCommand cmd80 = new SqlCommand();
                cmd80.Connection = conn;
                cmd80.CommandText = "Select * from seatBooking where seat_no='G8' and booked='YES'";
                SqlDataAdapter da80 = new SqlDataAdapter(cmd80);
                DataTable dt80 = new DataTable();
                da80.Fill(dt80);
                if (dt80.Rows.Count > 0)
                {
                    C80.Checked = true;
                    C80.Enabled = false;
                }
                else
                {
                    C80.Checked = false;
                }

                SqlCommand cmd81 = new SqlCommand();
                cmd81.Connection = conn;
                cmd81.CommandText = "Select * from seatBooking where seat_no='G9' and booked='YES'";
                SqlDataAdapter da81 = new SqlDataAdapter(cmd81);
                DataTable dt81 = new DataTable();
                da81.Fill(dt81);
                if (dt81.Rows.Count > 0)
                {
                    C81.Checked = true;
                    C81.Enabled = false;
                }
                else
                {
                    C81.Checked = false;
                }


                SqlCommand cmd82 = new SqlCommand();
                cmd82.Connection = conn;
                cmd82.CommandText = "Select * from seatBooking where seat_no='G10' and booked='YES'";
                SqlDataAdapter da82 = new SqlDataAdapter(cmd82);
                DataTable dt82 = new DataTable();
                da82.Fill(dt82);
                if (dt82.Rows.Count > 0)
                {
                    C82.Checked = true;
                    C82.Enabled = false;
                }
                else
                {
                    C82.Checked = false;
                }

                SqlCommand cmd83 = new SqlCommand();
                cmd83.Connection = conn;
                cmd83.CommandText = "Select * from seatBooking where seat_no='G11' and booked='YES'";
                SqlDataAdapter da83 = new SqlDataAdapter(cmd83);
                DataTable dt83 = new DataTable();
                da83.Fill(dt83);
                if (dt83.Rows.Count > 0)
                {
                    C83.Checked = true;
                    C83.Enabled = false;
                }
                else
                {
                    C83.Checked = false;
                }

                SqlCommand cmd84 = new SqlCommand();
                cmd84.Connection = conn;
                cmd84.CommandText = "Select * from seatBooking where seat_no='G12' and booked='YES'";
                SqlDataAdapter da84 = new SqlDataAdapter(cmd84);
                DataTable dt84 = new DataTable();
                da84.Fill(dt84);
                if (dt84.Rows.Count > 0)
                {
                    C84.Checked = true;
                    C84.Enabled = false;
                }
                else
                {
                    C84.Checked = false;
                }


                SqlCommand cmd85 = new SqlCommand();
                cmd85.Connection = conn;
                cmd85.CommandText = "Select * from seatBooking where seat_no='H1' and booked='YES'";
                SqlDataAdapter da85 = new SqlDataAdapter(cmd85);
                DataTable dt85 = new DataTable();
                da85.Fill(dt85);
                if (dt85.Rows.Count > 0)
                {
                    C85.Checked = true;
                    C85.Enabled = false;
                }
                else
                {
                    C85.Checked = false;
                }


                SqlCommand cmd86 = new SqlCommand();
                cmd86.Connection = conn;
                cmd86.CommandText = "Select * from seatBooking where seat_no='H2' and booked='YES'";
                SqlDataAdapter da86 = new SqlDataAdapter(cmd86);
                DataTable dt86 = new DataTable();
                da86.Fill(dt86);
                if (dt86.Rows.Count > 0)
                {
                    C86.Checked = true;
                    C86.Enabled = false;
                }
                else
                {
                    C86.Checked = false;
                }

                SqlCommand cmd87 = new SqlCommand();
                cmd87.Connection = conn;
                cmd87.CommandText = "Select * from seatBooking where seat_no='H3' and booked='YES'";
                SqlDataAdapter da87 = new SqlDataAdapter(cmd87);
                DataTable dt87 = new DataTable();
                da87.Fill(dt87);
                if (dt87.Rows.Count > 0)
                {
                    C87.Checked = true;
                    C87.Enabled = false;
                }
                else
                {
                    C87.Checked = false;
                }

                SqlCommand cmd88 = new SqlCommand();
                cmd88.Connection = conn;
                cmd88.CommandText = "Select * from seatBooking where seat_no='H4' and booked='YES'";
                SqlDataAdapter da88 = new SqlDataAdapter(cmd88);
                DataTable dt88 = new DataTable();
                da88.Fill(dt88);
                if (dt88.Rows.Count > 0)
                {
                    C88.Checked = true;
                    C88.Enabled = false;
                }
                else
                {
                    C88.Checked = false;
                }

                SqlCommand cmd89 = new SqlCommand();
                cmd89.Connection = conn;
                cmd89.CommandText = "Select * from seatBooking where seat_no='H5' and booked='YES'";
                SqlDataAdapter da89 = new SqlDataAdapter(cmd89);
                DataTable dt89 = new DataTable();
                da89.Fill(dt89);
                if (dt89.Rows.Count > 0)
                {
                    C89.Checked = true;
                    C89.Enabled = false;
                }
                else
                {
                    C89.Checked = false;
                }

                SqlCommand cmd90 = new SqlCommand();
                cmd90.Connection = conn;
                cmd90.CommandText = "Select * from seatBooking where seat_no='H6' and booked='YES'";
                SqlDataAdapter da90 = new SqlDataAdapter(cmd90);
                DataTable dt90 = new DataTable();
                da90.Fill(dt90);
                if (dt90.Rows.Count > 0)
                {
                    C90.Checked = true;
                    C90.Enabled = false;
                }
                else
                {
                    C90.Checked = false;
                }

                SqlCommand cmd91 = new SqlCommand();
                cmd91.Connection = conn;
                cmd91.CommandText = "Select * from seatBooking where seat_no='H7' and booked='YES'";
                SqlDataAdapter da91 = new SqlDataAdapter(cmd91);
                DataTable dt91 = new DataTable();
                da91.Fill(dt91);
                if (dt91.Rows.Count > 0)
                {
                    C91.Checked = true;
                    C91.Enabled = false;
                }
                else
                {
                    C91.Checked = false;
                }

                SqlCommand cmd92 = new SqlCommand();
                cmd92.Connection = conn;
                cmd92.CommandText = "Select * from seatBooking where seat_no='H8' and booked='YES'";
                SqlDataAdapter da92 = new SqlDataAdapter(cmd92);
                DataTable dt92 = new DataTable();
                da92.Fill(dt92);
                if (dt92.Rows.Count > 0)
                {
                    C92.Checked = true;
                    C92.Enabled = false;
                }
                else
                {
                    C92.Checked = false;
                }

                SqlCommand cmd93 = new SqlCommand();
                cmd93.Connection = conn;
                cmd93.CommandText = "Select * from seatBooking where seat_no='H9' and booked='YES'";
                SqlDataAdapter da93 = new SqlDataAdapter(cmd93);
                DataTable dt93 = new DataTable();
                da93.Fill(dt93);
                if (dt93.Rows.Count > 0)
                {
                    C93.Checked = true;
                    C93.Enabled = false;
                }
                else
                {
                    C93.Checked = false;
                }

                SqlCommand cmd94 = new SqlCommand();
                cmd94.Connection = conn;
                cmd94.CommandText = "Select * from seatBooking where seat_no='H10' and booked='YES'";
                SqlDataAdapter da94 = new SqlDataAdapter(cmd94);
                DataTable dt94 = new DataTable();
                da94.Fill(dt94);
                if (dt94.Rows.Count > 0)
                {
                    C94.Checked = true;
                    C94.Enabled = false;
                }
                else
                {
                    C94.Checked = false;
                }

                SqlCommand cmd95 = new SqlCommand();
                cmd95.Connection = conn;
                cmd95.CommandText = "Select * from seatBooking where seat_no='H11' and booked='YES'";
                SqlDataAdapter da95 = new SqlDataAdapter(cmd95);
                DataTable dt95 = new DataTable();
                da95.Fill(dt95);
                if (dt95.Rows.Count > 0)
                {
                    C95.Checked = true;
                    C95.Enabled = false;
                }
                else
                {
                    C95.Checked = false;
                }

                SqlCommand cmd96 = new SqlCommand();
                cmd96.Connection = conn;
                cmd96.CommandText = "Select * from seatBooking where seat_no='H12' and booked='YES'";
                SqlDataAdapter da96 = new SqlDataAdapter(cmd96);
                DataTable dt96 = new DataTable();
                da96.Fill(dt96);
                if (dt96.Rows.Count > 0)
                {
                    C96.Checked = true;
                    C96.Enabled = false;
                }
                else
                {
                    C96.Checked = false;
                }

                SqlCommand cmd97 = new SqlCommand();
                cmd97.Connection = conn;
                cmd97.CommandText = "Select * from seatBooking where seat_no='I1' and booked='YES'";
                SqlDataAdapter da97 = new SqlDataAdapter(cmd97);
                DataTable dt97 = new DataTable();
                da97.Fill(dt97);
                if (dt97.Rows.Count > 0)
                {
                    C97.Checked = true;
                    C97.Enabled = false;
                }
                else
                {
                    C97.Checked = false;
                }


                SqlCommand cmd98 = new SqlCommand();
                cmd98.Connection = conn;
                cmd98.CommandText = "Select * from seatBooking where seat_no='I2' and booked='YES'";
                SqlDataAdapter da98 = new SqlDataAdapter(cmd98);
                DataTable dt98 = new DataTable();
                da98.Fill(dt98);
                if (dt98.Rows.Count > 0)
                {
                    C98.Checked = true;
                    C98.Enabled = false;
                }
                else
                {
                    C98.Checked = false;
                }

                SqlCommand cmd99 = new SqlCommand();
                cmd99.Connection = conn;
                cmd99.CommandText = "Select * from seatBooking where seat_no='I3' and booked='YES'";
                SqlDataAdapter da99 = new SqlDataAdapter(cmd99);
                DataTable dt99 = new DataTable();
                da99.Fill(dt99);
                if (dt99.Rows.Count > 0)
                {
                    C99.Checked = true;
                    C99.Enabled = false;
                }
                else
                {
                    C99.Checked = false;
                }

                SqlCommand cmd100 = new SqlCommand();
                cmd100.Connection = conn;
                cmd100.CommandText = "Select * from seatBooking where seat_no='I4' and booked='YES'";
                SqlDataAdapter da100 = new SqlDataAdapter(cmd100);
                DataTable dt100 = new DataTable();
                da100.Fill(dt100);
                if (dt100.Rows.Count > 0)
                {
                    C100.Checked = true;
                    C100.Enabled = false;
                }
                else
                {
                    C100.Checked = false;
                }

                SqlCommand cmd101 = new SqlCommand();
                cmd101.Connection = conn;
                cmd101.CommandText = "Select * from seatBooking where seat_no='I5' and booked='YES'";
                SqlDataAdapter da101 = new SqlDataAdapter(cmd101);
                DataTable dt101 = new DataTable();
                da101.Fill(dt101);
                if (dt101.Rows.Count > 0)
                {
                    C101.Checked = true;
                    C101.Enabled = false;
                }
                else
                {
                    C101.Checked = false;
                }

                SqlCommand cmd102 = new SqlCommand();
                cmd102.Connection = conn;
                cmd102.CommandText = "Select * from seatBooking where seat_no='I6' and booked='YES'";
                SqlDataAdapter da102 = new SqlDataAdapter(cmd102);
                DataTable dt102 = new DataTable();
                da102.Fill(dt102);
                if (dt102.Rows.Count > 0)
                {
                    C102.Checked = true;
                    C102.Enabled = false;
                }
                else
                {
                    C102.Checked = false;
                }

                SqlCommand cmd103 = new SqlCommand();
                cmd103.Connection = conn;
                cmd103.CommandText = "Select * from seatBooking where seat_no='I7' and booked='YES'";
                SqlDataAdapter da103 = new SqlDataAdapter(cmd103);
                DataTable dt103 = new DataTable();
                da103.Fill(dt103);
                if (dt103.Rows.Count > 0)
                {
                    C103.Checked = true;
                    C103.Enabled = false;
                }
                else
                {
                    C103.Checked = false;
                }

                SqlCommand cmd104 = new SqlCommand();
                cmd104.Connection = conn;
                cmd104.CommandText = "Select * from seatBooking where seat_no='I8' and booked='YES'";
                SqlDataAdapter da104 = new SqlDataAdapter(cmd104);
                DataTable dt104 = new DataTable();
                da104.Fill(dt104);
                if (dt104.Rows.Count > 0)
                {
                    C104.Checked = true;
                    C104.Enabled = false;
                }
                else
                {
                    C104.Checked = false;
                }

                SqlCommand cmd105 = new SqlCommand();
                cmd105.Connection = conn;
                cmd105.CommandText = "Select * from seatBooking where seat_no='I9' and booked='YES'";
                SqlDataAdapter da105 = new SqlDataAdapter(cmd105);
                DataTable dt105 = new DataTable();
                da105.Fill(dt105);
                if (dt105.Rows.Count > 0)
                {
                    C105.Checked = true;
                    C105.Enabled = false;
                }
                else
                {
                    C105.Checked = false;
                }

                SqlCommand cmd106 = new SqlCommand();
                cmd106.Connection = conn;
                cmd106.CommandText = "Select * from seatBooking where seat_no='I10' and booked='YES'";
                SqlDataAdapter da106 = new SqlDataAdapter(cmd106);
                DataTable dt106 = new DataTable();
                da106.Fill(dt106);
                if (dt106.Rows.Count > 0)
                {
                    C106.Checked = true;
                    C106.Enabled = false;
                }
                else
                {
                    C106.Checked = false;
                }

                SqlCommand cmd107 = new SqlCommand();
                cmd107.Connection = conn;
                cmd107.CommandText = "Select * from seatBooking where seat_no='I11' and booked='YES'";
                SqlDataAdapter da107 = new SqlDataAdapter(cmd107);
                DataTable dt107 = new DataTable();
                da107.Fill(dt107);
                if (dt107.Rows.Count > 0)
                {
                    C107.Checked = true;
                    C107.Enabled = false;
                }
                else
                {
                    C107.Checked = false;
                }

                SqlCommand cmd108 = new SqlCommand();
                cmd108.Connection = conn;
                cmd108.CommandText = "Select * from seatBooking where seat_no='I12' and booked='YES'";
                SqlDataAdapter da108 = new SqlDataAdapter(cmd108);
                DataTable dt108 = new DataTable();
                da108.Fill(dt108);
                if (dt108.Rows.Count > 0)
                {
                    C108.Checked = true;
                    C108.Enabled = false;
                }
                else
                {
                    C108.Checked = false;
                }
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        
        
        if (ddlClass.SelectedIndex == 1)
        {
            lblTNS.Text = Convert.ToString(i);
            p = 180 * (Convert.ToInt32(lblTNS.Text)); //+ 120 * (Convert.ToInt32(txtGC.Text));
            txtTotal.Text = Convert.ToString(p);
        }
        else if(ddlClass.SelectedIndex == 2)
        {
            lblTNS.Text = Convert.ToString(j);
            p = 120 * (Convert.ToInt32(lblTNS.Text)); //+ 120 * (Convert.ToInt32(txtGC.Text));
            txtTotal.Text = Convert.ToString(p);
        }
        btnProceed.Visible = true;
        Button2.Visible = false;
        btnAddon.Enabled = true;
        

    }
    protected void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlClass.SelectedIndex == 1)
        {
            ddlClass.Enabled = false;
            panelGC.Enabled = true;
            panelSC.Enabled = false;
            lblg.Text = "Rs 180.00";
            lbls.Text = "";
        }
        else if (ddlClass.SelectedIndex == 2)
        {
            ddlClass.Enabled = false;
            panelSC.Enabled = true;
            panelGC.Enabled = false;
            lbls.Text = "Rs 120.00";
            lblg.Text = "";

        }
    }
    protected void C1_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C2_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C3_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void btnAddon_Click(object sender, EventArgs e)
    {
        if (C1.Checked == true)
        {
            Session["a1"] = C1.Text;
        }
        if (C2.Checked == true)
        {
            Session["a2"] = C2.Text;
        }
        if (C3.Checked == true)
        {
            Session["a3"] = C3.Text;
        }
        if (C4.Checked == true)
        {
            Session["a4"] = C4.Text;
        }
        if (C5.Checked == true)
        {
            Session["a5"] = C5.Text;
        }
        if (C6.Checked == true)
        {
            Session["a6"] = C6.Text;
        }
        if (C7.Checked == true)
        {
            Session["a7"] = C7.Text;
        }
        if (C8.Checked == true)
        {
            Session["a8"] = C8.Text;
        }
        if (C9.Checked == true)
        {
            Session["a9"] = C9.Text;
        }
        if (C10.Checked == true)
        {
            Session["a10"] = C10.Text;
        }
        if (C11.Checked == true)
        {
            Session["a11"] = C11.Text;
        }
        if (C12.Checked == true)
        {
            Session["a12"] = C12.Text;
        }

        //Session for B Row
       

        if (C13.Checked == true)
        {
            Session[" b1"] = C13.Text;
        }
        if (C14.Checked == true)
        {
            Session[" b2"] = C14.Text;
        }
        if (C15.Checked == true)
        {
            Session[" b3"] = C15.Text;
        }
        if (C16.Checked == true)
        {
            Session[" b4"] = C16.Text;
        }
        if (C17.Checked == true)
        {
            Session[" b5"] = C17.Text;
        }
        if (C18.Checked == true)
        {
            Session[" b6"] = C18.Text;
        }
        if (C19.Checked == true)
        {
            Session[" b7"] = C19.Text;
        }
        if (C20.Checked == true)
        {
            Session[" b8"] = C20.Text;
        }
        if (C21.Checked == true)
        {
            Session[" b9"] = C21.Text;
        }
        if (C22.Checked == true)
        {
            Session[" b10"] = C22.Text;
        }
        if (C23.Checked == true)
        {
            Session[" b11"] = C23.Text;
        }
        if (C24.Checked == true)
        {
            Session[" b12"] = C24.Text;
        }

        //Session for C Row
        if (C25.Checked == true)
        {
            Session[" c1"] = C25.Text;
        }
        if (C26.Checked == true)
        {
            Session[" c2"] = C26.Text;
        }
        if (C27.Checked == true)
        {
            Session[" c3"] = C27.Text;
        }
        if (C28.Checked == true)
        {
            Session[" c4"] = C28.Text;
        }
        if (C29.Checked == true)
        {
            Session[" c5"] = C29.Text;
        }
        if (C30.Checked == true)
        {
            Session[" c6"] = C30.Text;
        }
        if (C31.Checked == true)
        {
            Session[" c7"] = C31.Text;
        }
        if (C32.Checked == true)
        {
            Session[" c8"] = C32.Text;
        }
        if (C33.Checked == true)
        {
            Session[" c9"] = C33.Text;
        }
        if (C34.Checked == true)
        {
            Session[" c10"] = C34.Text;
        }
        if (C35.Checked == true)
        {
            Session[" c11"] = C35.Text;
        }
        if (C36.Checked == true)
        {
            Session[" c12"] = C36.Text;
        }

        //Session for D Row
        if (C37.Checked == true)
        {
            Session[" d1"] = C37.Text;
        }
        if (C38.Checked == true)
        {
            Session[" d2"] = C38.Text;
        }
        if (C39.Checked == true)
        {
            Session[" d3"] = C39.Text;
        }
        if (C40.Checked == true)
        {
            Session[" d4"] = C40.Text;
        }
        if (C41.Checked == true)
        {
            Session[" d5"] = C41.Text;
        }
        if (C42.Checked == true)
        {
            Session[" d6"] = C42.Text;
        }
        if (C43.Checked == true)
        {
            Session[" d7"] = C43.Text;
        }
        if (C44.Checked == true)
        {
            Session[" d8"] = C44.Text;
        }
        if (C45.Checked == true)
        {
            Session[" d9"] = C45.Text;
        }
        if (C46.Checked == true)
        {
            Session[" d10"] = C46.Text;
        }
        if (C47.Checked == true)
        {
            Session[" d11"] = C47.Text;
        }
        if (C48.Checked == true)
        {
            Session[" d12"] = C48.Text;
        }

        //Session for E Row
        if (C49.Checked == true)
        {
            Session[" e1"] = C49.Text;
        }
        if (C50.Checked == true)
        {
            Session[" e2"] = C50.Text;
        }
        if (C51.Checked == true)
        {
            Session[" e3"] = C51.Text;
        }
        if (C52.Checked == true)
        {
            Session[" e4"] = C52.Text;
        }
        if (C53.Checked == true)
        {
            Session[" e5"] = C53.Text;
        }
        if (C54.Checked == true)
        {
            Session[" e6"] = C54.Text;
        }
        if (C55.Checked == true)
        {
            Session[" e7"] = C55.Text;
        }
        if (C56.Checked == true)
        {
            Session[" e8"] = C56.Text;
        }
        if (C57.Checked == true)
        {
            Session[" e9"] = C57.Text;
        }
        if (C58.Checked == true)
        {
            Session[" e10"] = C58.Text;
        }
        if (C59.Checked == true)
        {
            Session[" e11"] = C59.Text;
        }
        if (C60.Checked == true)
        {
            Session[" e12"] = C60.Text;
        }

        //Session for F Row
        if (C61.Checked == true)
        {
            Session[" f1"] = C61.Text;
        }
        if (C62.Checked == true)
        {
            Session[" f2"] = C62.Text;
        }
        if (C63.Checked == true)
        {
            Session[" f3"] = C63.Text;
        }
        if (C64.Checked == true)
        {
            Session[" f4"] = C64.Text;
        }
        if (C65.Checked == true)
        {
            Session[" f5"] = C65.Text;
        }
        if (C66.Checked == true)
        {
            Session[" f6"] = C66.Text;
        }
        if (C67.Checked == true)
        {
            Session[" f7"] = C67.Text;
        }
        if (C68.Checked == true)
        {
            Session[" f8"] = C68.Text;
        }
        if (C69.Checked == true)
        {
            Session[" f9"] = C69.Text;
        }
        if (C70.Checked == true)
        {
            Session[" f10"] = C70.Text;
        }
        if (C71.Checked == true)
        {
            Session[" f11"] = C71.Text;
        }
        if (C72.Checked == true)
        {
            Session[" f12"] = C72.Text;
        }

        //Session for G Row
        if (C73.Checked == true)
        {
            Session[" g1"] = C73.Text;
        }
        if (C74.Checked == true)
        {
            Session[" g2"] = C74.Text;
        }
        if (C75.Checked == true)
        {
            Session[" g3"] = C75.Text;
        }
        if (C76.Checked == true)
        {
            Session[" g4"] = C76.Text;
        }
        if (C77.Checked == true)
        {
            Session[" g5"] = C77.Text;
        }
        if (C78.Checked == true)
        {
            Session[" g6"] = C78.Text;
        }
        if (C79.Checked == true)
        {
            Session[" g7"] = C79.Text;
        }
        if (C80.Checked == true)
        {
            Session[" g8"] = C80.Text;
        }
        if (C81.Checked == true)
        {
            Session[" g9"] = C81.Text;
        }
        if (C82.Checked == true)
        {
            Session[" g10"] = C82.Text;
        }
        if (C83.Checked == true)
        {
            Session[" g11"] = C83.Text;
        }
        if (C84.Checked == true)
        {
            Session[" g12"] = C84.Text;
        }

        //Session for H Row
        if (C85.Checked == true)
        {
            Session[" h1"] = C85.Text;
        }
        if (C86.Checked == true)
        {
            Session[" h2"] = C86.Text;
        }
        if (C87.Checked == true)
        {
            Session[" h3"] = C87.Text;
        }
        if (C88.Checked == true)
        {
            Session[" h4"] = C88.Text;
        }
        if (C89.Checked == true)
        {
            Session[" h5"] = C89.Text;
        }
        if (C90.Checked == true)
        {
            Session[" h6"] = C90.Text;
        }
        if (C91.Checked == true)
        {
            Session[" h7"] = C91.Text;
        }
        if (C92.Checked == true)
        {
            Session[" h8"] = C92.Text;
        }
        if (C93.Checked == true)
        {
            Session[" h9"] = C93.Text;
        }
        if (C94.Checked == true)
        {
            Session[" h10"] = C94.Text;
        }
        if (C95.Checked == true)
        {
            Session[" h11"] = C95.Text;
        }
        if (C96.Checked == true)
        {
            Session[" h12"] = C96.Text;
        }

        //Session for I Row
        if (C97.Checked == true)
        {
            Session[" i1"] = C97.Text;
        }
        if (C98.Checked == true)
        {
            Session[" i2"] = C98.Text;
        }
        if (C99.Checked == true)
        {
            Session[" i3"] = C99.Text;
        }
        if (C100.Checked == true)
        {
            Session[" i4"] = C100.Text;
        }
        if (C101.Checked == true)
        {
            Session[" i5"] = C101.Text;
        }
        if (C102.Checked == true)
        {
            Session[" i6"] = C102.Text;
        }
        if (C103.Checked == true)
        {
            Session[" i7"] = C103.Text;
        }
        if (C104.Checked == true)
        {
            Session[" i8"] = C104.Text;
        }
        if (C105.Checked == true)
        {
            Session[" i9"] = C105.Text;
        }
        if (C106.Checked == true)
        {
            Session[" i10"] = C106.Text;
        }
        if (C107.Checked == true)
        {
            Session[" i11"] = C107.Text;
        }
        if (C108.Checked == true)
        {
            Session[" i12"] = C108.Text;
        }
        //Session for J Row
        if (C109.Checked == true)
        {
            Session[" j1"] = C109.Text;
        }
        if (C110.Checked == true)
        {
            Session[" j2"] = C110.Text;
        }
        if (C111.Checked == true)
        {
            Session[" j3"] = C111.Text;
        }
        if (C112.Checked == true)
        {
            Session[" j4"] = C112.Text;
        }
        if (C113.Checked == true)
        {
            Session[" j5"] = C113.Text;
        }
        if (C114.Checked == true)
        {
            Session[" j6"] = C114.Text;
        }
        if (C115.Checked == true)
        {
            Session[" j7"] = C115.Text;
        }
        if (C116.Checked == true)
        {
            Session[" j8"] = C116.Text;
        }
        if (C117.Checked == true)
        {
            Session[" j9"] = C117.Text;
        }
        if (C118.Checked == true)
        {
            Session[" j10"] = C118.Text;
        }
        if (C119.Checked == true)
        {
            Session[" j11"] = C119.Text;
        }
        if (C120.Checked == true)
        {
            Session[" j12"] = C120.Text;
        }

        Response.Redirect("~/Combo menu.aspx");
    }
    protected void btnProceed_Click(object sender, EventArgs e)
    {
        //Session for A Row
        if (C1.Checked == true)
        {
            Session["a1"] = C1.Text;
        }
        if (C2.Checked == true)
        {
            Session["a2"] = C2.Text;
        }
        if (C3.Checked == true)
        {
            Session["a3"] = C3.Text;
        }
        if (C4.Checked == true)
        {
            Session["a4"] = C4.Text;
        }
        if (C5.Checked == true)
        {
            Session["a5"] = C5.Text;
        }
        if (C6.Checked == true)
        {
            Session["a6"] = C6.Text;
        }
        if (C7.Checked == true)
        {
            Session["a7"] = C7.Text;
        }
        if (C8.Checked == true)
        {
            Session["a8"] = C8.Text;
        }
        if (C9.Checked == true)
        {
            Session["a9"] = C9.Text;
        }
        if (C10.Checked == true)
        {
            Session["a10"] = C10.Text;
        }
        if (C11.Checked == true)
        {
            Session["a11"] = C11.Text;
        }
        if (C12.Checked == true)
        {
            Session["a12"] = C12.Text;
        }

        //Session for B Row
        if(C13.Checked == true)
        {
            Session[" b1"] = C13.Text;
        }
        if (C14.Checked == true)
        {
            Session[" b2"] = C14.Text;
        }
        if (C15.Checked == true)
        {
            Session[" b3"] = C15.Text;
        }
        if (C16.Checked == true)
        {
            Session[" b4"] = C16.Text;
        }
        if (C17.Checked == true)
        {
            Session[" b5"] = C17.Text;
        }
        if (C18.Checked == true)
        {
            Session[" b6"] = C18.Text;
        }
        if (C19.Checked == true)
        {
            Session[" b7"] = C19.Text;
        }
        if (C20.Checked == true)
        {
            Session[" b8"] = C20.Text;
        }
        if (C21.Checked == true)
        {
            Session[" b9"] = C21.Text;
        }
        if (C22.Checked == true)
        {
            Session[" b10"] = C22.Text;
        }
        if (C23.Checked == true)
        {
            Session[" b11"] = C23.Text;
        }
        if (C24.Checked == true)
        {
            Session[" b12"] = C24.Text;
        }

        //Session for C Row
        if (C25.Checked == true)
        {
            Session[" c1"] = C25.Text;
        }
        if (C26.Checked == true)
        {
            Session[" c2"] = C26.Text;
        }
        if (C27.Checked == true)
        {
            Session[" c3"] = C27.Text;
        }
        if (C28.Checked == true)
        {
            Session[" c4"] = C28.Text;
        }
        if (C29.Checked == true)
        {
            Session[" c5"] = C29.Text;
        }
        if (C30.Checked == true)
        {
            Session[" c6"] = C30.Text;
        }
        if (C31.Checked == true)
        {
            Session[" c7"] = C31.Text;
        }
        if (C32.Checked == true)
        {
            Session[" c8"] = C32.Text;
        }
        if (C33.Checked == true)
        {
            Session[" c9"] = C33.Text;
        }
        if (C34.Checked == true)
        {
            Session[" c10"] = C34.Text;
        }
        if (C35.Checked == true)
        {
            Session[" c11"] = C35.Text;
        }
        if (C36.Checked == true)
        {
            Session[" c12"] = C36.Text;
        }

        //Session for D Row
        if (C37.Checked == true)
        {
            Session[" d1"] = C37.Text;
        }
        if (C38.Checked == true)
        {
            Session[" d2"] = C38.Text;
        }
        if (C39.Checked == true)
        {
            Session[" d3"] = C39.Text;
        }
        if (C40.Checked == true)
        {
            Session[" d4"] = C40.Text;
        }
        if (C41.Checked == true)
        {
            Session[" d5"] = C41.Text;
        }
        if (C42.Checked == true)
        {
            Session[" d6"] = C42.Text;
        }
        if (C43.Checked == true)
        {
            Session[" d7"] = C43.Text;
        }
        if (C44.Checked == true)
        {
            Session[" d8"] = C44.Text;
        }
        if (C45.Checked == true)
        {
            Session[" d9"] = C45.Text;
        }
        if (C46.Checked == true)
        {
            Session[" d10"] = C46.Text;
        }
        if (C47.Checked == true)
        {
            Session[" d11"] = C47.Text;
        }
        if (C48.Checked == true)
        {
            Session[" d12"] = C48.Text;
        }

        //Session for E Row
        if (C49.Checked == true)
        {
            Session[" e1"] = C49.Text;
        }
        if (C50.Checked == true)
        {
            Session[" e2"] = C50.Text;
        }
        if (C51.Checked == true)
        {
            Session[" e3"] = C51.Text;
        }
        if (C52.Checked == true)
        {
            Session[" e4"] = C52.Text;
        }
        if (C53.Checked == true)
        {
            Session[" e5"] = C53.Text;
        }
        if (C54.Checked == true)
        {
            Session[" e6"] = C54.Text;
        }
        if (C55.Checked == true)
        {
            Session[" e7"] = C55.Text;
        }
        if (C56.Checked == true)
        {
            Session[" e8"] = C56.Text;
        }
        if (C57.Checked == true)
        {
            Session[" e9"] = C57.Text;
        }
        if (C58.Checked == true)
        {
            Session[" e10"] = C58.Text;
        }
        if (C59.Checked == true)
        {
            Session[" e11"] = C59.Text;
        }
        if (C60.Checked == true)
        {
            Session[" e12"] = C60.Text;
        }

        //Session for F Row
        if (C61.Checked == true)
        {
            Session[" f1"] = C61.Text;
        }
        if (C62.Checked == true)
        {
            Session[" f2"] = C62.Text;
        }
        if (C63.Checked == true)
        {
            Session[" f3"] = C63.Text;
        }
        if (C64.Checked == true)
        {
            Session[" f4"] = C64.Text;
        }
        if (C65.Checked == true)
        {
            Session[" f5"] = C65.Text;
        }
        if (C66.Checked == true)
        {
            Session[" f6"] = C66.Text;
        }
        if (C67.Checked == true)
        {
            Session[" f7"] = C67.Text;
        }
        if (C68.Checked == true)
        {
            Session[" f8"] = C68.Text;
        }
        if (C69.Checked == true)
        {
            Session[" f9"] = C69.Text;
        }
        if (C70.Checked == true)
        {
            Session[" f10"] = C70.Text;
        }
        if (C71.Checked == true)
        {
            Session[" f11"] = C71.Text;
        }
        if (C72.Checked == true)
        {
            Session[" f12"] = C72.Text;
        }

        //Session for G Row
        if (C73.Checked == true)
        {
            Session[" g1"] = C73.Text;
        }
        if (C74.Checked == true)
        {
            Session[" g2"] = C74.Text;
        }
        if (C75.Checked == true)
        {
            Session[" g3"] = C75.Text;
        }
        if (C76.Checked == true)
        {
            Session[" g4"] = C76.Text;
        }
        if (C77.Checked == true)
        {
            Session[" g5"] = C77.Text;
        }
        if (C78.Checked == true)
        {
            Session[" g6"] = C78.Text;
        }
        if (C79.Checked == true)
        {
            Session[" g7"] = C79.Text;
        }
        if (C80.Checked == true)
        {
            Session[" g8"] = C80.Text;
        }
        if (C81.Checked == true)
        {
            Session[" g9"] = C81.Text;
        }
        if (C82.Checked == true)
        {
            Session[" g10"] = C82.Text;
        }
        if (C83.Checked == true)
        {
            Session[" g11"] = C83.Text;
        }
        if (C84.Checked == true)
        {
            Session[" g12"] = C84.Text;
        }

        //Session for H Row
        if (C85.Checked == true)
        {
            Session[" h1"] = C85.Text;
        }
        if (C86.Checked == true)
        {
            Session[" h2"] = C86.Text;
        }
        if (C87.Checked == true)
        {
            Session[" h3"] = C87.Text;
        }
        if (C88.Checked == true)
        {
            Session[" h4"] = C88.Text;
        }
        if (C89.Checked == true)
        {
            Session[" h5"] = C89.Text;
        }
        if (C90.Checked == true)
        {
            Session[" h6"] = C90.Text;
        }
        if (C91.Checked == true)
        {
            Session[" h7"] = C91.Text;
        }
        if (C92.Checked == true)
        {
            Session[" h8"] = C92.Text;
        }
        if (C93.Checked == true)
        {
            Session[" h9"] = C93.Text;
        }
        if (C94.Checked == true)
        {
            Session[" h10"] = C94.Text;
        }
        if (C95.Checked == true)
        {
            Session[" h11"] = C95.Text;
        }
        if (C96.Checked == true)
        {
            Session[" h12"] = C96.Text;
        }

        //Session for I Row
        if (C97.Checked == true)
        {
            Session[" i1"] = C97.Text;
        }
        if (C98.Checked == true)
        {
            Session[" i2"] = C98.Text;
        }
        if (C99.Checked == true)
        {
            Session[" i3"] = C99.Text;
        }
        if (C100.Checked == true)
        {
            Session[" i4"] = C100.Text;
        }
        if (C101.Checked == true)
        {
            Session[" i5"] = C101.Text;
        }
        if (C102.Checked == true)
        {
            Session[" i6"] = C102.Text;
        }
        if (C103.Checked == true)
        {
            Session[" i7"] = C103.Text;
        }
        if (C104.Checked == true)
        {
            Session[" i8"] = C104.Text;
        }
        if (C105.Checked == true)
        {
            Session[" i9"] = C105.Text;
        }
        if (C106.Checked == true)
        {
            Session[" i10"] = C106.Text;
        }
        if (C107.Checked == true)
        {
            Session[" i11"] = C107.Text;
        }
        if (C108.Checked == true)
        {
            Session[" i12"] = C108.Text;
        }
        //Session for J Row
        if (C109.Checked == true)
        {
            Session[" j1"] = C109.Text;
        }
        if (C110.Checked == true)
        {
            Session[" j2"] = C110.Text;
        }
        if (C111.Checked == true)
        {
            Session[" j3"] = C111.Text;
        }
        if (C112.Checked == true)
        {
            Session[" j4"] = C112.Text;
        }
        if (C113.Checked == true)
        {
            Session[" j5"] = C113.Text;
        }
        if (C114.Checked == true)
        {
            Session[" j6"] = C114.Text;
        }
        if (C115.Checked == true)
        {
            Session[" j7"] = C115.Text;
        }
        if (C116.Checked == true)
        {
            Session[" j8"] = C116.Text;
        }
        if (C117.Checked == true)
        {
            Session[" j9"] = C117.Text;
        }
        if (C118.Checked == true)
        {
            Session[" j10"] = C118.Text;
        }
        if (C119.Checked == true)
        {
            Session[" j11"] = C119.Text;
        }
        if (C120.Checked == true)
        {
            Session[" j12"] = C120.Text;
        }
        //to check already booked
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
       
       

        Response.Redirect("~/Bill.aspx");
    }
    protected void C4_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C5_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C6_CheckedChanged(object sender, EventArgs e)
    {
        if(C6.Checked==true)
        {
        i += 1;
        }
    }
    protected void C7_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C8_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C9_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C10_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C11_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C12_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C13_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C14_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C15_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C16_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C17_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C18_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C19_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C20_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C21_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C22_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C23_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C24_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C25_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C26_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C27_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C28_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C29_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C30_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C31_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C32_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C33_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C34_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C35_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C36_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C37_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C38_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C39_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C40_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C41_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C42_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C43_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C44_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C45_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C46_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C47_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C48_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C49_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C50_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C51_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C52_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C53_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C54_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C55_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C56_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C57_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C58_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C59_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C60_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C61_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C62_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C63_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C64_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C65_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C66_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C67_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C68_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C69_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C70_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C71_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C72_CheckedChanged(object sender, EventArgs e)
    {
        i += 1;
    }
    protected void C73_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C74_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C75_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C76_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C77_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C78_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C79_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C80_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C81_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C82_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C83_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C84_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C85_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C86_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C87_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C88_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C89_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C90_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C91_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C92_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C93_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C94_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C95_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C96_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C97_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C98_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C99_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C100_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C101_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C102_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C103_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C104_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C105_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C106_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C107_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C108_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C109_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C110_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C111_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C112_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C113_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C114_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C115_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C116_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C117_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C118_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C119_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void C120_CheckedChanged(object sender, EventArgs e)
    {
        j += 1;
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        lblTNS.Text = "";
        txtTotal.Text = "";
        btnAddon.Enabled = false;
        btnBack.Visible = true;
        btnCancel.Visible = false ;

    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/demobk.aspx");
    }
}