using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ChatRoom : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            name.Text = Session["name"].ToString();
            number.Text = "目前線上人數:"+ Application["count"];

            //github test
        }

        protected void sendBtn_Click(object sender, EventArgs e)
        {
            string message = inputText.Text;
            Application["messageResult"] = Application["messageResult"] +Session["name"].ToString()+":&nbsp;"+message+"</br>";        
        }

        protected void countTimer_Tick(object sender, EventArgs e)
        { 
            if (Application["messageResult"] != null)
                chatResult.Text = Application["messageResult"].ToString();
        }
    }
}