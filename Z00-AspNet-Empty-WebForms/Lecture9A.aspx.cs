using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _L7B_EmptyWebForms2
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblCity.Text = DListCity.Text;
        }


        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblGender.Text = RBListGender.SelectedValue;
        }

        protected void RBtnJunior_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtnJunior.Checked == true)
            {
                LblAgeGroup.Text = RBtnJunior.Text;
            }
            else if (RBtnAdult.Checked == true)
            {
                LblAgeGroup.Text = RBtnAdult.Text;
            }
            else if (RBtnSenior.Checked == true)
            {
                LblAgeGroup.Text = RBtnSenior.Text;
            }
        }

        protected void RBtnAdult_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtnJunior.Checked == true)
            {
                LblAgeGroup.Text = RBtnJunior.Text;
            }
            else if (RBtnAdult.Checked == true)
            {
                LblAgeGroup.Text = RBtnAdult.Text;
            }
            else if (RBtnSenior.Checked == true)
            {
                LblAgeGroup.Text = RBtnSenior.Text;
            }
        }

        protected void RBtnSenior_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtnJunior.Checked == true)
            {
                LblAgeGroup.Text = RBtnJunior.Text;
            }
            else if (RBtnAdult.Checked == true)
            {
                LblAgeGroup.Text = RBtnAdult.Text;
            }
            else if (RBtnSenior.Checked == true)
            {
                LblAgeGroup.Text = RBtnSenior.Text;
            }
        }

        protected void CBoxDay_CheckedChanged(object sender, EventArgs e)
        {
            string shifts = "";
            if (CBoxDay.Checked == true)
            {
                shifts += " " + CBoxDay.Text + " ";
            }
            else if (CBoxNight.Checked == true)
            {
                shifts += " " + CBoxNight.Text + " ";
            }
            LblWorkShifts.Text = shifts;
        }

        protected void CBoxNight_CheckedChanged(object sender, EventArgs e)
        {
                        string shifts = "";
            if (CBoxDay.Checked == true)
            {
                shifts += " " + CBoxDay.Text + " ";
            }
            else if (CBoxNight.Checked == true)
            {
                shifts += " " + CBoxNight.Text + " ";
            }
            LblWorkShifts.Text = shifts;
        }

        protected void DDListEmoji_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DDListEmoji.Text == "Happy")
            {
                ImgEmoji.ImageUrl = "images/images2.jpg";
            }
            if (DDListEmoji.Text == "Scary")
            {
                ImgEmoji.ImageUrl = "images/images1.jpg";
            }
        }
    }
}