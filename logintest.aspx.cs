using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class logintest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["logined"] != null && Session["logined"].ToString() == "1")
            {
                Response.Redirect("Rock-paper-scissors");
            }
            else
            {
                if (Request.Form["TextBox2"] != null && Request.Form["passwd2"] != null)
                {
                    if (Request.Form["TextBox2"] == "lccnet" && Request.Form["passwd2"] == "123456")
                    {
                        Application["count"] = Convert.ToInt32(Application["count"]) + 1;
                        Session["logined"] = "1";
                        Response.Redirect("Rock-paper-scissors");
                    }
                }
                else
                {
                    Response.Write("尚未輸入帳號密碼");//顯示尚未輸入帳號密碼
                }
            }
        }
    }
}