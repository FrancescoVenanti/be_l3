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



        protected void AggiungiProdottoAlCookie(string valoreProdotto)
        {

            HttpCookie cookie = Request.Cookies["Prodotti"] ?? new HttpCookie("Prodotti");


            string valoreEsistente = cookie.Value;

            if (string.IsNullOrEmpty(valoreEsistente))
            {
                cookie.Value = valoreProdotto;
            }
            else
            {
                cookie.Value = valoreEsistente + "," + valoreProdotto;
            }

            cookie.Expires = DateTime.Now.AddDays(365);
            Response.Cookies.Add(cookie);
        }

        protected void AggiungiImgProdotto(string imgProdotto)
        {

            HttpCookie cookie = Request.Cookies["imgCookie"] ?? new HttpCookie("imgCookie");


            string valoreEsistente = cookie.Value;

            if (string.IsNullOrEmpty(valoreEsistente))
            {
                cookie.Value = imgProdotto;
            }
            else
            {
                cookie.Value = valoreEsistente + "," + imgProdotto;
            }

            cookie.Expires = DateTime.Now.AddDays(365);
            Response.Cookies.Add(cookie);
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            AggiungiProdottoAlCookie(prodotto1.InnerText);
            AggiungiImgProdotto(imgProdotto1.Src);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            AggiungiProdottoAlCookie(prodotto2.InnerText);
            AggiungiImgProdotto(imgProdotto2.Src);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            AggiungiProdottoAlCookie(prodotto3.InnerText);
            AggiungiImgProdotto(imgProdotto3.Src);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            AggiungiProdottoAlCookie(prodotto4.InnerText);
            AggiungiImgProdotto(imgProdotto4.Src);
        }
    }
}