using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThePostBackProblem
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Postback problem
            //When you change the values for the calendar or textbox
            //those changes are never reflected after submitting them
            //with the button click...
            //thats becuase the default values always reload after very submmision

            //Easiest solution is to include code that does one thing if its the 
            //first time the page is loaded and do another if it's not

            //if (Page.IsPostBack==false) //same as saying if (!Page.IsPostBack)
            //{
            TxtMy.Text = "Welcome";
            CalMy.SelectedDate = DateTime.Now.Date.AddDays(2); //moves current day to 2 days later
            //}                                                //and makes it the auto selected date
            
        }

        protected void BtnOK_Click(object sender, EventArgs e)
        {
            LblResult.Text = TxtMy.Text + " - " + CalMy.SelectedDate.ToLongDateString();
        }
    }
}