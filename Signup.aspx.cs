using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBox1.Text = "請輸入帳號"; 
                TextBox2.Text = "請輸入密碼";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "pratice") //當帳號輸入正確
            {
                Label3.Text = "帳號正確";  //顯示輸入正確
                TextBox1.Text = "";  //清除輸入資訊
                if (TextBox2.Text == "123456")  //判斷密碼
                {
                    Label4.Text = "密碼正確";
                    TextBox2.Text = "";
                    Application["count"] = Convert.ToInt32(Application["count"]) + 1;
                    Session["logined"] = 1;
                    Response.Redirect("~/Rock-paper-scissors");
                }
                else if (TextBox2.Text != "123456")
                {
                    Label4.Text = "密碼錯誤";
                    TextBox2.Text = "";
                }
            }
            else if(TextBox1.Text !="pratice")  //當帳號輸入錯誤
            {
                Label3.Text = "帳號錯誤";  //顯示輸入正確
                TextBox1.Text = "";  //清除輸入資訊
                if (TextBox2.Text == "123456")  //判斷密碼
                {
                    Label4.Text = "密碼正確";
                    TextBox2.Text = "";
                }
                else if (TextBox2.Text != "123456")
                {
                    Label4.Text = "密碼錯誤";
                    TextBox2.Text = "";
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "pratice") //當帳號輸入正確
            {
                Label3.Text = "帳號正確";  //顯示輸入正確
                TextBox1.Text = "";  //清除輸入資訊
                if (TextBox2.Text == "123456")  //判斷密碼
                {
                    Label4.Text = "密碼正確";
                    TextBox2.Text = "";
                    Application["count"] = Convert.ToInt32(Application["count"]) + 1;
                    Session["logined"] = 1; 
                    Session["name"] = TextBox3.Text.ToString();
                    Response.Redirect("~/ChatRoom");
                }
                else if (TextBox2.Text != "123456")
                {
                    Label4.Text = "密碼錯誤";
                    TextBox2.Text = "";
                }
            }
            else if (TextBox1.Text != "pratice")  //當帳號輸入錯誤
            {
                Label3.Text = "帳號錯誤";  //顯示輸入正確
                TextBox1.Text = "";  //清除輸入資訊
                if (TextBox2.Text == "123456")  //判斷密碼
                {
                    Label4.Text = "密碼正確";
                    TextBox2.Text = "";
                }
                else if (TextBox2.Text != "123456")
                {
                    Label4.Text = "密碼錯誤";
                    TextBox2.Text = "";
                }
            }
        }
    }
}