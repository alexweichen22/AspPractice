using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _L7B_EmptyWebForms2
{
    public partial class Lesson10_Pizza : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnPurchase_Click(object sender, EventArgs e)
        {
            double totalPrice = 0;
            foreach(ListItem list in CBListChoice.Items)
            {
                if(list.Selected == true)
                {
                    totalPrice += Double.Parse(list.Value);

                }

            }
            if (RBtnRegular.Checked == true) { totalPrice += 5.0; }
            if (RBtnXLarge.Checked == true) { totalPrice += 7.5; }
            LblTotal.Text = "Total: " + totalPrice;
        }
    }
}