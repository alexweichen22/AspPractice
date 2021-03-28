using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DaysBetweenDates
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnOK_Click(object sender, EventArgs e)
        {
            if (CalOne.SelectedDate > CalTwo.SelectedDate)
            {
                LblResult.Text = CalOne.SelectedDate.Subtract(CalTwo.SelectedDate).TotalDays.ToString();
            }
            else
            {
                LblResult.Text = CalTwo.SelectedDate.Subtract(CalOne.SelectedDate).TotalDays.ToString();
            }
        }
    }
}