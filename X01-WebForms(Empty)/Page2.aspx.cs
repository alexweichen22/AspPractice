using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _L7B_EmptyWebForms2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour < 12)
            {
                LblPage2.Text = "Good Morning!";
            }
            else
            {
                LblPage2.Text = "Good Afternoon!";
            }
        }
    }
}