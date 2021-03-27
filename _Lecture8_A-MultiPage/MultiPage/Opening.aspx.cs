using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MultiPage
{
    public partial class Opening : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour < 12)
            {
                LblStatus.Text = "Good Morning";
            }
            else
            {
                LblStatus.Text = "Good Night";
            }
        }
    }
}