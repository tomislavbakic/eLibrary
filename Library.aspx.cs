using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblioteka
{

 

    public partial class Library : System.Web.UI.Page
    {
        BibliotekaDataContext bdc = new BibliotekaDataContext();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                BindDataToGridView();

            
        }

        private void BindDataToGridView()
        {
            var knjige = from k in bdc.knjigas
                         select new {id = k.id,naslov = k.naslov,autor = k.autor.ime + " "+ k.autor.prezime,godinaIzdanja =  k.godinaIzdanja,kolicina =  k.kolicina };

            
            gvSveKnjige.DataSource = knjige.OrderBy(p => p.naslov);
            gvSveKnjige.DataBind();
        }

        protected void gvSveKnjige_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            if (Session["autorizovan"] != null)
            {
                int id = int.Parse(gvSveKnjige.DataKeys[e.RowIndex].Value.ToString());
                int kolicina = 0;

                var stanje = from k in bdc.knjigas
                             where k.id == id
                             select new { kolicina = k.kolicina };

                kolicina = stanje.FirstOrDefault().kolicina;

                if (kolicina > 0)
                {
                    kolicina = kolicina - 1;

                    var knjiga = bdc.knjigas.Where(k => k.id.Equals(id)).FirstOrDefault();

                    knjiga.kolicina = kolicina;

                    bdc.SubmitChanges();
                   
                    BindDataToGridView();

                    //ovde mora da se upise u tabelu iznajmljivanje
                    zaduzenje z = new zaduzenje();

                    z.sifraKorisnika = (int)Session["autorizovan"];
                    z.sifraKnjige = id;
                    z.datumZaduzenja = DateTime.Now;

                    bdc.zaduzenjes.InsertOnSubmit(z);
                    bdc.SubmitChanges();

                    var korisnik = bdc.korisniks.Where(k => k.id.Equals(z.sifraKorisnika)).FirstOrDefault();
                    string ime = korisnik.ime + " " + korisnik.prezime;
                    string adresa = korisnik.adresa;
                    string naslov = knjiga.naslov;
                    Response.Write("<script> alert('Korisnik " + ime + " je uspesno porucio knjigu ``" + naslov + "`` i bice isporucena na adresu:" + adresa+"')</script>");
                }
                else
                {
                    Response.Write("<script> alert('Na stanju nema trenutno knjiga!')</script>");
                }
            }
            else
            {
                Response.Write("<script> alert('Prvo se morate ulogovati da bi mogli da narucite knjigu.')</script>");
                for(int i=1;i<1000;i++)
                { }
                Response.Redirect("~/Login");
            }

        }
    }
}