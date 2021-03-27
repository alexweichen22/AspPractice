using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            //Panel1.Visible = true;
        }        
    }

    protected void RdoOn_CheckedChanged(object sender, EventArgs e)
    {
        //Panel1.Visible = true;
    }
    protected void RdoOff_CheckedChanged(object sender, EventArgs e)
    {
        //Panel1.Visible = false;
    }
    protected void BtnGotoAbout_Click(object sender, EventArgs e)
    {
        string QueryString="";
        //QueryString = "?ID=" + TxtName.Text;
        Response.Redirect("about.aspx" + QueryString);
    }
}
