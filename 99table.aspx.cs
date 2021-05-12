using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _99table : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // GET,透過網址傳遞資訊,輸入的格式都是字串String
            if (Request.QueryString["number1"] != null && Request.QueryString["number2"] != null)//使用GET製作99乘法表
            {
                Response.Write("<table border=2><tr><td>");//非置中呈現
                Label1.Text = "<center><table border=4><tr><td>";//置中呈現
                String sum = "";// 儲存全部輸出結果

                for (int x = 1; x <= int.Parse(Request.QueryString["number1"]); x++)
                {
                    for (int y = 1; y <= int.Parse(Request.QueryString["number2"]); y++)
                    {
                        sum = "&nbsp;"+x.ToString()+"*"+y.ToString()+"="+(x*y).ToString()+"&nbsp;"+"</br>";// 輸出顯示為 _x * y = xy_

                        if (y == int.Parse(Request.QueryString["number2"]))
                        {
                            if (x % 3 == 0)
                            {
                                if (int.Parse(Request.QueryString["number1"]) % 9 == 0 && x == int.Parse(Request.QueryString["number1"]))
                                {
                                    sum = sum + "</td></tr></table>";//計算結束
                                }
                                else
                                {
                                    sum = sum + "</td></tr><tr><td>";//滿3格換列
                                }
                            }
                            else if (x == int.Parse(Request.QueryString["number1"]))
                            {
                                sum = sum + "</td></tr></table></h3>";//計算結束
                            }
                            else
                            {
                                sum = sum + "</td><td>";//換格
                            }
                        }
                        Response.Write(sum);//輸出資訊
                        Label1.Text = Label1.Text + sum; //輸出資訊
                    }
                }
            }
        }
    }
}