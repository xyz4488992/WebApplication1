using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class SessionTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {//判斷是否為初次執行
                if (Object.Equals(Session["AdminName"], null))
                {//判斷在Session["AdminName"]是否存在值
                    Response.Redirect("ErrorPage.aspx", true);
                }
                else
                {//要是存在則記錄下這個人的使用者名稱
                    Name.Text = Session["AdminName"].ToString();
                }
            }
        }
    }
}