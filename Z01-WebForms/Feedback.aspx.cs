using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Z01_WebForms
{
    public partial class Feedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ListItem itemMale = new ListItem("Male", "0");
                rbtnGender.Items.Add(itemMale);
                rbtnGender.Items.Add(new ListItem("Female", "1"));
                rbtnGender.Items.Add(new ListItem("Others", "2"));
                rbtnGender.Items.Add("Would rather not to say!");

                dlistCourse.Items.Add("Javascript");
                dlistCourse.Items.Add("Python");

                ListBox1.Items.Add("Assignment1");
                ListBox1.Items.Add("Assignment2");
                ListBox1.Items.Add("Assignment3");
                ListBox1.Items.Add("Quiz1");
                ListBox1.Items.Add("Quiz2");
                ListBox1.Items.Add("Project");

                ListBox1.SelectionMode = ListSelectionMode.Multiple;
                ListBox2.SelectionMode = ListSelectionMode.Multiple;

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string submitted = "";
            foreach(ListItem i in ListBox1.Items)
            {
                if (i.Selected == true)
                {
                    ListBox2.Items.Add(i);
                    submitted += i.Text + " ";
                }
            }

            lblDisplay.Text = txtStudentName.Text + "(" + rbtnGender.SelectedItem.Text + "), you took course " +
                   dlistCourse.SelectedValue + ", you completed: " + submitted;


        }
    }
}