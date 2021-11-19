using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class cst_bill : System.Web.UI.Page
{
    int total;
    int totalprice;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable dt = new DataTable();
            DataRow dr;
            dt.Columns.Add("sno");
            dt.Columns.Add("food_id");
            dt.Columns.Add("name");
            dt.Columns.Add("quantity");
            dt.Columns.Add("price");
            dt.Columns.Add("totalprice");
               if (Request.QueryString["id"] != null)
            {
                if (Session["confirm"] == null)
                {

                    dr = dt.NewRow();
                    SqlConnection scon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\ROS.mdf;Integrated Security=True;User Instance=True;");
                    // String mycon = "Data Source=HP-PC\\SQLEXPRESS;Initial Catalog=haritiShopping;Integrated Security=True";
                    //SqlConnection scon = new SqlConnection(mycon);
                    String myquery = "select * from orderdetail where food_id=" + Request.QueryString["id"];
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = myquery;
                    cmd.Connection = scon;
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dr["sno"] = 1;
                    dr["food_id"] = ds.Tables[0].Rows[0]["food_id"].ToString();
                    dr["names"] = ds.Tables[0].Rows[0]["sub_menu"].ToString();
                   
                    dr["quantity"] = Request.QueryString["quantity"];
                    dr["price"] = ds.Tables[0].Rows[0]["price"].ToString();
                    int price = Convert.ToInt16(ds.Tables[0].Rows[0]["price"].ToString());
                    int quantity = Convert.ToInt16(Request.QueryString["quantity"].ToString());
                    totalprice = price * quantity;
                    dr["totalprice"] = totalprice;

                    dt.Rows.Add(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();

                    Session["confirm"] = dt;
                    GridView1.FooterRow.Cells[3].Text = "Total Amount ";
                    GridView1.FooterRow.Cells[4].Text = "with 5% GST";
                    GridView1.FooterRow.Cells[5].Text = grandtotal().ToString();
                    
                    
                    Response.Redirect("cst_cart.aspx");

                }
                else
                {

                    dt = (DataTable)Session["confirm"];
                    int sr;
                    sr = dt.Rows.Count;

                    dr = dt.NewRow();
                    SqlConnection scon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\ROS.mdf;Integrated Security=True;User Instance=True;");
                    String myquery = "select * from orderdetail where food_id=" + Request.QueryString["id"];
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = myquery;
                    cmd.Connection = scon;
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dr["sno"] = sr + 1;
                    dr["food_id"] = ds.Tables[0].Rows[0]["food_id"].ToString();
                    dr["name"] = ds.Tables[0].Rows[0]["sub_menu"].ToString();
                    
                    dr["quantity"] = Request.QueryString["quantity"];
                    dr["price"] = ds.Tables[0].Rows[0]["price"].ToString();
                    int price = Convert.ToInt16(ds.Tables[0].Rows[0]["price"].ToString());
                    int quantity = Convert.ToInt16(Request.QueryString["quantity"].ToString());
                    int totalprice = price * quantity;
                    dr["totalprice"] = totalprice;
                    dt.Rows.Add(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();

                    Session["confirm"] = dt;
                  GridView1.FooterRow.Cells[3].Text = "Total Amount ";
                    GridView1.FooterRow.Cells[4].Text = "with 5% GST";
                    GridView1.FooterRow.Cells[5].Text = grandtotal().ToString();
                     
                    Response.Redirect("cst_cart.aspx");

                }
            }
            else
            {
                dt = (DataTable)Session["confirm"];
                GridView1.DataSource = dt;
                GridView1.DataBind();
                if (GridView1.Rows.Count > 0)
                {
                    GridView1.FooterRow.Cells[3].Text = "Total Amount ";
                    GridView1.FooterRow.Cells[4].Text = "with 5% GST";
                    GridView1.FooterRow.Cells[5].Text = grandtotal().ToString();
                    

                }


            }
        }
        Label4.Text = DateTime.Now.ToShortDateString();
        findorderid();

    }
    public double grandtotal()
    {
        DataTable dt = new DataTable();
        dt = (DataTable)Session["confirm"];
        int nrow = dt.Rows.Count;
        int i = 0;
        double gtotal = 0;
        while (i < nrow)
        {
            gtotal = gtotal + Convert.ToInt32(dt.Rows[i]["totalprice"].ToString());

            i = i + 1;
        }
        gtotal = gtotal + (0.05 * gtotal);
        return gtotal;
    }
    public void findorderid()
    {
        string id = Session["email_id"].ToString();
        Label3.Text = id;
    }




    protected void Button1_Click(object sender, EventArgs e)
    {
        
        String updatepass = "insert into bill_payment(order_id,feedback,mobile_no,total_price,emp_name,bill_status) values('" + Label3.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + total + "','" + TextBox3.Text + "','" + 1 + "')";
        SqlConnection s = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\ROS.mdf;Integrated Security=True;User Instance=True;");

        s.Open();
        SqlCommand cmd1 = new SqlCommand();
        cmd1.CommandText = updatepass;
        cmd1.Connection = s;
        cmd1.ExecuteNonQuery();
        s.Close();
        Session.Remove("buyitem");
        Session.Remove("confirm");
        Session.Remove("email_id");
        Response.Redirect("basic_home.aspx");
    }
}
