using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static int ct = 3;        //設定遊戲時間三秒   
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["logined"] == null)
            {
                //Response.Redirect("Signup");
            }
            Label1.Text = "目前線上人數:" + Application["count"];
        }

        protected void button_click(object sender, ImageClickEventArgs e)
        {
            int user = 0;  //設定玩家變數，布設定為1，剪刀設定為2，石頭設定為3
            if (sender == ImageButton1)
            {
                user = 1;
                Player.Text = "玩家出布";
            }
            else if (sender == ImageButton2)
            {
                user = 2;
                Player.Text = "玩家出剪刀";
            }
            else if (sender == ImageButton3)
            {
                user = 3;
                Player.Text = "玩家出石頭";
            }

            Random rnd = new Random(); //透過亂數設定電腦數值，布設定為1，剪刀設定為2，石頭設定為3
            int computer = rnd.Next(1, 4);
            if (computer == 1)
            {
                Computer.Text = "電腦出布";
                ComputerImage.ImageUrl = "~/Picture/paper.png";
            }
            else if (computer == 2)
            {
                Computer.Text = "電腦出剪刀";
                ComputerImage.ImageUrl = "~/Picture/scissors.png";
            }
            else if (computer == 3)
            {
                Computer.Text = "電腦出石頭";
                ComputerImage.ImageUrl = "~/Picture/stone.png";
            }

            if ((user == 1 && computer == 1) ||
                (user == 2 && computer == 2) ||
                (user == 3 && computer == 3))
            {
                Result.Text = "雙方平手";
            }
            else if ((user == 1 && computer == 2) ||
                (user == 2 && computer == 3) ||
                (user == 3 && computer == 1))
            {
                Result.Text = "電腦獲勝";
            }
            else if ((user == 1 && computer == 3) ||
                (user == 2 && computer == 1) ||
                (user == 3 && computer == 2))
            {
                Result.Text = "玩家獲勝";
            }
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            ct--;
            Label2.Text = "倒數計時: " + ct.ToString();
            
            if (ct == 0)
            {
                Player.Text = "時間到，遊戲結束"; 
                Result.Text = "時間到，遊戲結束";
                Computer.Text = "時間到，遊戲結束";
                ImageButton1.Enabled = false;
                ImageButton2.Enabled = false;
                ImageButton3.Enabled = false;
                Timer1.Enabled = false;
            }
        }
    }
}