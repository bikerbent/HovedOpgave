using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yeetlse_13
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                andersandsmor.Text = Session["CurrentUser"].ToString();
        }
    }
}