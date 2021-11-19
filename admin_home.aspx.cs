using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
   
    protected void btnchngpswd_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin_chng_pswd.aspx");
    }
    protected void btnempreg_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin_emp_res.aspx");
    }
    protected void btnempdetails_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin_employee_detail.aspx");
    }
    protected void btnsctdetails_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin_cst_details.aspx");
    }
    protected void btneditoffers_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin_product_add.aspx");
    }
    protected void btnbilldet_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin_show_product.aspx");
    }
    protected void btnvehdet_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin_paid_order.aspx");
    }
    protected void btntandc_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin_pending_order.aspx");
    }
    //protected void btnroutdet_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("admin_rout_details.aspx");
    //}
}