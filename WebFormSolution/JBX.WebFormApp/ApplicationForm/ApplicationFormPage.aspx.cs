using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JBX.WebFormApp.ApplicationForm
{
    public partial class ApplicationFormPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.resultLabel.Text = "Intro";
        }

        protected void formSubmitButton_Click(object sender, EventArgs e)
        {
            this.resultLabel.Text = $"{this.firstName.Text} {this.lastName.Text}";
        }
    }
}