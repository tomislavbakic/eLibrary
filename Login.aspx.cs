using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblioteka
{
    public partial class Login : System.Web.UI.Page
    {
        BibliotekaDataContext bdc = new BibliotekaDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_Click(object sender, EventArgs e)
        {
            string user = tbUsernameLogin.Text;
            string pass = tbSifraLogin.Text;

            if (user == null || pass == null)
            {
                error.InnerText = "Korisnicko ime i lozinka moraju biti popunjeni";
                Response.Redirect("~/Login");
            }
            var korisnik = bdc.korisniks.Where(k => k.username.Equals(user) && k.password.Equals(pass)).FirstOrDefault();
            if (korisnik != default(korisnik))
            {
                Session["autorizovan"] = korisnik.id;
                if (korisnik.uloga.Equals("admin"))
                {
                    Session["admin"] = 1;
                    Response.Redirect("~/GodMode");
                }
                else
                {
                    Session["admin"] = 0;
                    Response.Redirect("~/Library");
                }
            }
            else
            {
                error.InnerText = "Pogresno korisnicko ime ili lozinka";
            }
        }
    }
}