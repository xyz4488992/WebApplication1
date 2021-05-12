using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ReceiveMessage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LbName.Text = Session["Name"].ToString();
            LbEmail.Text = Session["Email"].ToString();
            //Session["Name"].Remove();
            //Session["Email"].Remove();
        }
    }
}