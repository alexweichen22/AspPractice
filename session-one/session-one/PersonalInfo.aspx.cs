using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace session_one
{
    public partial class PersonalInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                lblWelcome.Text = "Welcome to Our page for the first time";
            }
        }


        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            lblWelcome.Text = "";
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;

            

            lblResult.Text = string.Format("The personal info {0} , {1}", firstName, lastName);

            lblResult.BackColor = System.Drawing.Color.Magenta;

            BtnSubmit.Text = "SUBMITTED";
            tbl.Style["background-color"] = "red";


            //tbl.BgColor = "red";
            //change the color of a reset button from the server
        }
    }
}