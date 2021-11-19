using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class cst_cart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable dt = new DataTable();
            DataRow dr;
            dt.Columns.Add("sno");
            dt.Columns.Add("food_id");
            dt.Columns.Add("sub_menu");
            dt.Columns.Add("quantity");
            dt.Columns.Add("price");
            dt.Columns.Add("totalprice");
            


            if (Request.QueryString["id"] != null)
            {
                if (Session["Buyitems"] == null)
                {

                    dr = dt.NewRow();

                    SqlConnection scon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\ROS.mdf;Integrated Security=True;User Instance=True;");
                    String myquery = "select * from menu_table where food_id=" + Request.QueryString["id"];
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = myquery;
                    cmd.Connection = scon;
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    dr["sno"] = 1;
                    dr["food_id"] = ds.Tables[0].Rows[0]["food_id"].ToString();
                    dr["sub_menu"] = ds.Tables[0].Rows[0]["sub_menu"].ToString();
                    dr["quantity"] = Request.QueryString["quantity"];
                    dr["price"] = ds.Tables[0].Rows[0]["price"].ToString();

                    int price = Convert.ToInt16(ds.Tables[0].Rows[0]["price"].ToString());
                    int quantity = Convert.ToInt16(Request.QueryString["quantity"].ToString());

                    int totalprice = price * quantity;
                    dr["totalprice"] = totalprice;

                    dt.Rows.Add(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();

                    Session["buyitems"] = dt;
                    GridView1.FooterRow.Cells[4].Text = "Total Amount";
                    GridView1.FooterRow.Cells[5].Text = grandtotal().ToString();
                    Response.Redirect("cst_cart.aspx");

                }
                else
                {

                    dt = (DataTable)Session["buyitems"];
                    int sr;
                    sr = dt.Rows.Count;

                    dr = dt.NewRow();

                    SqlConnection scon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\ROS.mdf;Integrated Security=True;User Instance=True;");
                    String myquery = "select * from menu_table where food_id=" + Request.QueryString["id"];
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = myquery;
                    cmd.Connection = scon;
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    dr["sno"] = 1;
                    dr["food_id"] = ds.Tables[0].Rows[0]["food_id"].ToString();
                    dr["sub_menu"] = ds.Tables[0].Rows[0]["sub_menu"].ToString();
                    dr["quantity"] = Request.QueryString["quantity"];
                    dr["price"] = ds.Tables[0].Rows[0]["price"].ToString();

                    int price = Convert.ToInt16(ds.Tables[0].Rows[0]["price"].ToString());
                    int quantity = Convert.ToInt16(Request.QueryString["quantity"].ToString());

                    int totalprice = price * quantity;
                    dr["totalprice"] = totalprice;

                    dt.Rows.Add(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();

                    Session["buyitems"] = dt;
                    GridView1.FooterRow.Cells[4].Text = "Total Amount";
                    GridView1.FooterRow.Cells[5].Text = grandtotal().ToString();
                    Response.Redirect("cst_cart.aspx");

                }
            }
            else
            {
                dt = (DataTable)Session["buyitems"];
                GridView1.DataSource = dt;
                GridView1.DataBind();
                if (GridView1.Rows.Count > 0)
                {
                    GridView1.FooterRow.Cells[4].Text = "Total Amount";
                    GridView1.FooterRow.Cells[5].Text =  grandtotal().ToString();

                }


            }
            Label2.Text = GridView1.Rows.Count.ToString();

        }

    }
    public int grandtotal()
    {
        DataTable dt = new DataTable();
        dt = (DataTable)Session["buyitems"];
        int nrow = dt.Rows.Count;
        int i = 0;
        int gtotal = 0;

        while (i < nrow)
        {
            gtotal = gtotal + Convert.ToInt32(dt.Rows[i]["totalprice"].ToString());

            i = i + 1;
        }
        return gtotal;
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        DataTable dt = new DataTable();
        dt = (DataTable)Session["buyitems"];


        for (int i = 0; i <= dt.Rows.Count - 1; i++)
        {
            int sr;
            int sr1;
            string qdata;
            string dtdata;
            sr = Convert.ToInt32(dt.Rows[i]["sno"].ToString());
            TableCell cell = GridView1.Rows[e.RowIndex].Cells[0];
            qdata = cell.Text;
            dtdata = sr.ToString();
            sr1 = Convert.ToInt32(qdata);

            if (sr == sr1)
            {
                dt.Rows[i].Delete();
                dt.AcceptChanges();
                break;

            }
        }

        for (int i = 1; i <= dt.Rows.Count; i++)
        {
            dt.Rows[i - 1]["sno"] = i;
            dt.AcceptChanges();
        }

        Session["buyitems"] = dt;
        Response.Redirect("cst_cart.aspx");
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlConnection scon1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\ROS.mdf;Integrated Security=True;User Instance=True;");
        String myquery1 = "select max(order_no) from orderdetail";
        SqlCommand cmd1 = new SqlCommand();
        cmd1.CommandText = myquery1;
        cmd1.Connection = scon1;

        SqlDataAdapter da1 = new SqlDataAdapter();
        da1.SelectCommand = cmd1;
        DataSet ds1 = new DataSet();
        da1.Fill(ds1);

        int order_no = Convert.ToInt16(ds1.Tables[0].Rows[0][0].ToString());
        order_no = order_no + 1;






        string id = Session["email_id"].ToString();
        //string id = "bhavu@gmail.com";


        string sno = GridView1.SelectedRow.Cells[0].Text;
        string food_id = GridView1.SelectedRow.Cells[1].Text;
        string name = GridView1.SelectedRow.Cells[2].Text;
        string price = GridView1.SelectedRow.Cells[3].Text;
        string qnt = GridView1.SelectedRow.Cells[4].Text;
        string date = DateTime.Now.ToShortDateString();



        String updatepass = "insert into orderdetail(order_no,order_id,sn_ro,food_id,sub_menu,price,quantity,dateoforder,order_status) values('" + order_no + "','" + id + "','" + sno + "','" + food_id + "','" + name + "','" + price + "','" + qnt + "','" + date + "','" + 0 + "')";

        SqlConnection s = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\ROS.mdf;Integrated Security=True;User Instance=True;");

        s.Open();
        SqlCommand c = new SqlCommand();
        c.CommandText = updatepass;
        c.Connection = s;
        c.ExecuteNonQuery();
        s.Close();




        Response.Redirect("cst_confirm.aspx?id=" + GridView1.SelectedRow.Cells[1].Text + "&quantity=" + GridView1.SelectedRow.Cells[4].Text);


    }

    
}