using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["Name"] = TxtName.Text;
            //可以使用Session.Add("Name",TxtName.Text);
            Session["Email"] = TxtEmail.Text;
            //可以使用Session.Add("Email",TxtEmail.Text);
            Response.Redirect("ReceiveMessage.aspx");
        }
    }
}