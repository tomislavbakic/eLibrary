using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblioteka
{
    public partial class Registracija : System.Web.UI.Page
    {
        BibliotekaDataContext bdc = new BibliotekaDataContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btRegistruj_Click(object sender, EventArgs e)
        {

            var clan = bdc.korisniks.Where(c => c.username.Equals(tbUsername.Text)).FirstOrDefault();
            if (clan == null)
            {
                korisnik k = new korisnik();

                k.adresa = tbAdresa.Text;
                k.brojTelefona = tbBrojTelefona.Text;
                k.email = tbEmail.Text;
                k.ime = tbIme.Text;
                k.prezime = tbPrezime.Text;
                k.username = tbUsername.Text;
                k.uloga = "clan";
                k.password = tbPassword.Text;

                bdc.korisniks.InsertOnSubmit(k);
                bdc.SubmitChanges();

                var nc = bdc.korisniks.Where(n => n.username.Equals(k.username)).FirstOrDefault();

                Session["autorizovan"] = nc.id;
                Session["admin"] = 0;
                Response.Redirect("Library");
            }
            else
            {
                Response.Write("<script> alert('Korisnicko ime je zauzeto!')</script>");
            }
        }
    }
}