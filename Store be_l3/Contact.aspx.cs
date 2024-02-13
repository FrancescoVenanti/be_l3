using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Store_be_l3
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.Cookies["ASPNET_COOKIE"] == null)
            {
                Response.Redirect("Default");
            }
            else if (Request.Cookies["Prodotti"] != null)
            {
                string[] prodotti = Request.Cookies["Prodotti"].Value.Split(',');
                string[] imgProdotti = Request.Cookies["imgCookie"].Value.Split(',');

                foreach (string item in prodotti)
                {
                    int i = 0;
                    lista_prodotti.InnerHtml += $"<li class='mb-3'><img height=50px class=me-3 src={imgProdotti[i]}/>{item}</>";
                    i++;
                }
                //wishlist.InnerText = Request.Cookies["Prodotti"].Value;

            }
            
        }
    }
}