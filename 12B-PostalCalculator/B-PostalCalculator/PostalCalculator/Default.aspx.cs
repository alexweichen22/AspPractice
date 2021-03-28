using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostalCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RdoGround_CheckedChanged(object sender, EventArgs e)
        {
            Postage();
        }

        protected void RdoAir_CheckedChanged(object sender, EventArgs e)
        {
            Postage();
        }

        protected void RdoNextDay_CheckedChanged(object sender, EventArgs e)
        {
            Postage();
        }

        private void Postage()
        {

            //do the values in the textboxes and checkboxes exist
            if (!valuesExist())
            {
                LblResult.Text = "You are missing one or more numbers";
                return;
            }

            double w = double.Parse(TxtWidth.Text);
            double h = double.Parse(TxtHeight.Text);
            double l = double.Parse(TxtLength.Text);

            //what is the volume
            double volume = 0.0;
            volume = GetVolume(w,h,l);

            //what is the multiplier
            double postageMultiplier = getPostageMultiplier();

            //what is the cost
            double cost = volume * postageMultiplier;

            //show result
            LblResult.Text = "Your parcel will cost " + cost.ToString("c");


        }

        private double getPostageMultiplier()
        {

            if (RdoGround.Checked)
                return .15;
            else if (RdoAir.Checked)
                return .25;
            else if (RdoNextDay.Checked)
                return .45;
            else
                return 0;
        }

        private double GetVolume(double x, double y, double z)
        {           

           double volume = 0;

           volume = x * y * z;

           return volume;            
        }

        private bool valuesExist()
        {
           if (TxtWidth.Text.Trim().Length == 0 || TxtHeight.Text.Trim().Length == 0 || TxtLength.Text.Trim().Length==0)
                return false;                     

            return true;
        }
    }
}