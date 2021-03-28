using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//Note: Need to add the lines below to Web.config to avoid error:
//WebForms UnobtrusiveValidationMode requires a ScriptResourceMapping for 'jquery'. 
//Please add a ScriptResourceMapping named jquery(case-sensitive).

//<appSettings>
//    <add key = "ValidationSettings:UnobtrusiveValidationMode" value="None"/>
//  </appSettings>


namespace ValidatedCustomerForm
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            LblMessage.Text = TxtName.Text + " " +  TxtAge.Text;
        }

       
    }
}