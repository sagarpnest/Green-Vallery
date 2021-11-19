using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Cst_menu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["cat"] != null)
            {
                DataList1.DataSourceID = null;
                DataList1.DataSource = SqlDataSource2;
                DataList1.DataBind();
            }
        }

        if (!IsPostBack)
        {
            DataTable dt = new DataTable();
            dt = (DataTable)Session["buyitems"];
            if (dt != null)
            {

                Label3.Text = dt.Rows.Count.ToString();
            }
            else
            {
                Label3.Text = "0";

            }
        }
    }

   protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {

        if (e.CommandName == "add2cart")
        {
            //Response.Redirect("add2cart.aspx?id=" + e.CommandArgument.ToString ());
            DropDownList dlist = (DropDownList)(e.Item.FindControl("DropDownList1"));
            Response.Redirect("cst_cart.aspx?id=" + e.CommandArgument.ToString() + "&quantity=" + dlist.SelectedItem.ToString());
        }


    }

    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        DataList1.DataSourceID = null;
        DataList1.DataSource = SqlDataSource1;
        DataList1.DataBind();
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("cst_menu.aspx?cat=soup");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("cst_menu.aspx?cat=Starter");
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("cst_menu.aspx?cat=Paneer");
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Response.Redirect("cst_menu.aspx?cat=Veg");
    }
    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        Response.Redirect("cst_menu.aspx?cat=Roti");
    }
    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        Response.Redirect("cst_menu.aspx?cat=Rice");
    }
}