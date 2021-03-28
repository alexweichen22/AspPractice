using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CheckBoxTest
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //comment out if statement below to appreciate the 
            //PostBack problem
            if (!IsPostBack)
            {
                CheckBoxList1.Items.Add("C");
                CheckBoxList1.Items.Add("C++");
                CheckBoxList1.Items.Add("C#");
                CheckBoxList1.Items.Add("Visual Basic 6.0");
                CheckBoxList1.Items.Add("VB.NET");
                CheckBoxList1.Items.Add("Pascal");
            }
        }

        protected void BtnOK_Click(object sender, EventArgs e)
        {
            LblResult.Text = "You chose: <b> "; //<b> bolds text

            foreach(ListItem lstItem in CheckBoxList1.Items)
            {
                if (lstItem.Selected==true)
                {
                    LblResult.Text += " <br />" + lstItem.Text;
                }
            }

            LblResult.Text += "</b>"; //this </b> finishes off the bold tag
        }
    }

        
    
}