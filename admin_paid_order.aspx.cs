using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class admin_paid_order : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HtmlMeta metatag = new HtmlMeta();
        metatag.HttpEquiv = "refresh";
        metatag.Content = "10";
        this.Page.Header.Controls.Add(metatag);
    }
}