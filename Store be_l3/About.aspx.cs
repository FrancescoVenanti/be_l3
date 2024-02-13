using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Store_be_l3
{
    public partial class About : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["ASPNET_COOKIE"] != null)
            {
                username_par.InnerText = "Ciao " + Request.Cookies["ASPNET_COOKIE"]["Username"];
               
            }
            else
            {
                Response.Redirect("Default");
            }
        }

        

        protected void Button1_Click(object sender, EventArgs e)
        {
            string pr1;
            string pr2;
            string pr3;
            string pr4;

            HttpCookie cookie = new HttpCookie("Prodotti");
            cookie.Expires = DateTime.Now.AddDays(5);
            cookie.Values["prpdotto1"] = prodotto1.InnerText;

            if (Request.Cookies["Prodotti"] != null)
            {
                pr1 = Request.Cookies["Prodotti"]["Prodotto1"];
                pr2 = Request.Cookies["Prodotti"]["Prodotto2"];
                pr3 = Request.Cookies["Prodotti"]["Prodotto3"];
                pr4 = Request.Cookies["Prodotti"]["Prodotto4"];

                cookie.Values["prpdotto2"] = pr2;
                cookie.Values["prpdotto3"] = pr3;
                cookie.Values["prpdotto4"] = pr4;
            }
            
            Response.Cookies.Add(cookie);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string pr1;
            string pr2;
            string pr3;
            string pr4;

            HttpCookie cookie = new HttpCookie("Prodotti");
            cookie.Expires = DateTime.Now.AddDays(5);
            cookie.Values["prpdotto2"] = prodotto2.InnerText;

            if (Request.Cookies["Prodotti"] != null)
            {
                pr1 = Request.Cookies["Prodotti"]["Prodotto1"];
                pr2 = Request.Cookies["Prodotti"]["Prodotto2"];
                pr3 = Request.Cookies["Prodotti"]["Prodotto3"];
                pr4 = Request.Cookies["Prodotti"]["Prodotto4"];

                cookie.Values["prpdotto1"] = pr1;
                cookie.Values["prpdotto3"] = pr3;
                cookie.Values["prpdotto4"] = pr4;
            }

            Response.Cookies.Add(cookie);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string pr1;
            string pr2;
            string pr3;
            string pr4;

            HttpCookie cookie = new HttpCookie("Prodotti");
            cookie.Expires = DateTime.Now.AddDays(5);
            cookie.Values["prpdotto3"] = prodotto3.InnerText;

            if (Request.Cookies["Prodotti"] != null)
            {
                pr1 = Request.Cookies["Prodotti"]["Prodotto1"];
                pr2 = Request.Cookies["Prodotti"]["Prodotto2"];
                pr3 = Request.Cookies["Prodotti"]["Prodotto3"];
                pr4 = Request.Cookies["Prodotti"]["Prodotto4"];

                cookie.Values["prpdotto2"] = pr2;
                cookie.Values["prpdotto1"] = pr1;
                cookie.Values["prpdotto4"] = pr4;
            }

            Response.Cookies.Add(cookie);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string pr1;
            string pr2;
            string pr3;
            string pr4;

            HttpCookie cookie = new HttpCookie("Prodotti");
            cookie.Expires = DateTime.Now.AddDays(5);
            cookie.Values["prpdotto4"] = prodotto4.InnerText;

            if (Request.Cookies["Prodotti"] != null)
            {
                pr1 = Request.Cookies["Prodotti"]["Prodotto1"];
                pr2 = Request.Cookies["Prodotti"]["Prodotto2"];
                pr3 = Request.Cookies["Prodotti"]["Prodotto3"];
                pr4 = Request.Cookies["Prodotti"]["Prodotto4"];

                cookie.Values["prpdotto2"] = pr2;
                cookie.Values["prpdotto3"] = pr3;
                cookie.Values["prpdotto1"] = pr1;
            }

            Response.Cookies.Add(cookie);
        }
    }
}