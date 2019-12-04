using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yeetlse_13
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void LoginButton_Click(object sender, EventArgs e)
        {
            if(Database.Login(UserNameTextBox.Text, PasswordTextBox.Text))
            {
                Session["CurrentUser"] = UserNameTextBox.Text;
                Response.Redirect("Contact.aspx");
            }
        }
    }
}