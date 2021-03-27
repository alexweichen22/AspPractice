using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ArtistJournal
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            if (TxtStart.Text=="")
            {
                TxtStart.Text = Calendar1.SelectedDate.ToString();
                //TxtStart.Text = Calendar1.SelectedDate.ToLongDateString().ToString();
            }
            else
            {
                TxtEnd.Text = Calendar1.SelectedDate.ToString();
                //TxtEnd.Text = Calendar1.SelectedDate.ToLongDateString().ToString();
            }
        }

        protected void BtnClear_Click(object sender, EventArgs e)
        {
            TxtStart.Text = "";
            TxtEnd.Text = "";
        }
    }
}