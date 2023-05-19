using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cerez_Hosgeldiniz
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        HttpCookie cer = new HttpCookie("hos");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["hos"] != null)
            {
                cer = Request.Cookies["hos"];
                int zsayi = Convert.ToInt32(cer["zs"]);
                zsayi++;
                cer["zs"] = zsayi.ToString();
                cer.Expires=DateTime.Now.AddYears(1);
                Response.Cookies.Add(cer);
                Response.Write("hoş geldiniz bu sayfamınza" + " " + zsayi + ". ziyaretiniz");

            }
            else
            {
                cer["zs"] = "1";
                cer.Expires= DateTime.Now.AddMonths(6);
                Response.Cookies.Add(cer);
                Response.Write("hoşgeldiniz bu sayfamızı ilk ziyaretininzdir");
            }
        }
    }
}