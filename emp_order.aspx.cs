using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data;
using System.Data.SqlClient;

public partial class emp_order : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HtmlMeta metatag = new HtmlMeta();
        metatag.HttpEquiv = "refresh";
        metatag.Content = "10";
        this.Page.Header.Controls.Add(metatag);

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        foreach (GridViewRow row in GridView1.Rows)
        {

            CheckBox ck = (row.Cells[2].FindControl("ck1") as CheckBox);

            if (ck.Checked == true)
            {
                // DropDownList dlist = (row.Cells[2].FindControl("DropDownList1") as DropDownList);
                int rollno = Convert.ToInt32(row.Cells[0].Text);
                updaterow(rollno, "1");
            }

        }
        GridView1.DataBind();
    }

    private void updaterow(int rollno, String markstatus)
    {


        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\ROS.mdf;Integrated Security=True;User Instance=True;");
        String updatedata = "Update orderdetail set order_status='" + markstatus + "' where order_no=" + rollno;
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = updatedata;
        cmd.Connection = con;
        cmd.ExecuteNonQuery();

    }

}