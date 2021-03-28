using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelpMethods
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
          

        protected void RdoCups_CheckedChanged(object sender, EventArgs e)
        {
            calculateCups(1.0,"cups");//1 and cups are the arguments you are passing to
        }                             //the methods parameters

        protected void RdoPints_CheckedChanged(object sender, EventArgs e)
        {
            calculateCups(2.0,"pints"); //2 cups in a pint
        }

        protected void RdoQuarts_CheckedChanged(object sender, EventArgs e)
        {
            calculateCups(4.0,"quarts"); // 4 cups in a quart
        }

        protected void RdoGallons_CheckedChanged(object sender, EventArgs e)
        {
            calculateCups(16.0,"gallons"); //16 cups in a gallon
        }

        private void calculateCups( double CupRatio,string measureName) //CupRatio and measureName are the parameters of 
        {                                                               //this method
            if (TxtQuantity.Text.Trim().Length == 0)
            {
                LblResult.Text = "No number entered";
                return;
             }
                

            double quantity = 0.0;

            if (!Double.TryParse(TxtQuantity.Text, out quantity))
            {
                LblResult.Text = "Invalid Type of Number entered .. Maybe you entered a word";
                return;
            }
                

            
            double cups = quantity * CupRatio;

            
            LblResult.Text = quantity + " " + measureName + " is equal to " + cups.ToString() + " cups";
        }
    }
}