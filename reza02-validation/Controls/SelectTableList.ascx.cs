using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace validation.Controls
{
    public partial class SelectTableList : System.Web.UI.UserControl
    {

        public string Title { 
            get { return lblTitle.Text; } 
            set { lblTitle.Text = value; } 
        }

        //1- Get a bunch of fruits to populate the source list view
        //2- Add Events to the 4 buttons to move the fruits from source to destination

        //3- Practice the validation controls for submitting the ADDRESS FORM
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}