using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblioteka
{
    public partial class GodMode : System.Web.UI.Page
    {
        BibliotekaDataContext bdc = new BibliotekaDataContext();

        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (Session["autorizovan"] == null || Session["admin"].Equals(0))
            {
                Response.Redirect("~/Login");
            }

            if (!Page.IsPostBack)
            {
                BindDataToGridView();
                dajPisce();
            }

        }

        private void dajPisce()
        {
            var autori = from a in bdc.autors
                         select new { id = a.id, ime = a.ime + " " + a.prezime };

            ddlAutor.DataSource = autori.OrderBy(a => a.ime);
            ddlAutor.DataTextField = "ime";
            ddlAutor.DataValueField = "id";
            ddlAutor.DataBind();
        }
        private void BindDataToGridView()
        {
            var knjige = from k in bdc.knjigas
                         select new { id = k.id, naslov = k.naslov, autor = k.autor.ime + " " + k.autor.prezime, godinaIzdanja = k.godinaIzdanja, kolicina = k.kolicina };


            gvSveKnjige.DataSource = knjige.OrderBy(k => k.naslov);
            gvSveKnjige.DataBind();
        }

        protected void gvSveKnjige_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = int.Parse(gvSveKnjige.DataKeys[e.RowIndex].Value.ToString());            
            var knjiga = bdc.knjigas.Where(k => k.id.Equals(id)).FirstOrDefault();
            var zaduzenje = bdc.zaduzenjes.Where(z => z.sifraKnjige.Equals(id));
            foreach (var item in zaduzenje)
            {
                bdc.zaduzenjes.DeleteOnSubmit(item);
            }

            bdc.knjigas.DeleteOnSubmit(knjiga);
            bdc.SubmitChanges();
            BindDataToGridView();

        }

        protected void dodajAutora_Click(object sender, EventArgs e)
        {
            string ime = tbImeAutora.Text;
            string prezime = tbPrezimeAutora.Text;

            var autor = bdc.autors.Where(a => a.ime.Equals(ime) && a.prezime.Equals(prezime)).FirstOrDefault();

            if(autor == null)
            {
                autor a = new autor();

                a.ime = ime;
                a.prezime = prezime;

                bdc.autors.InsertOnSubmit(a);
                bdc.SubmitChanges();

                tbPrezimeAutora.Text = null;
                tbImeAutora.Text = null;
                error.InnerText = null;
                Response.Redirect("~/GodMode");
            }
            else
            {
                error.InnerText = "Autor vec postoji u bazi!";
            }
        }

        protected void brDodajKnjigu_Click(object sender, EventArgs e)
        {
            knjiga k = new knjiga();

            k.idAutora = int.Parse(ddlAutor.SelectedValue); 
            k.kolicina = int.Parse(tbKolicina.Text);
            k.godinaIzdanja = int.Parse(tbGodinaIzdanja.Text);
            k.naslov = tbNaslov.Text;

            bdc.knjigas.InsertOnSubmit(k);
            bdc.SubmitChanges();

            BindDataToGridView();

            tbNaslov.Text = null;
            tbKolicina.Text = null;
            tbGodinaIzdanja.Text = null;
        }

        protected void gvSveKnjige_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvSveKnjige.EditIndex = e.NewEditIndex;
            BindDataToGridView();
        }

        protected void gvSveKnjige_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = int.Parse(gvSveKnjige.DataKeys[e.RowIndex].Value.ToString());
            int kolicina = 0, godinaIzdanja = 0;
            string naslov = "";

            var knjiga = bdc.knjigas.Where(k => k.id.Equals(id)).FirstOrDefault();

            TextBox tbNaslovE = gvSveKnjige.Rows[e.RowIndex].Cells[2].FindControl("tbNaslov") as TextBox;
            if(tbNaslovE != null)
            {
                naslov = tbNaslovE.Text;
                knjiga.naslov = naslov;
            }
            TextBox tbKolicinaE = gvSveKnjige.Rows[e.RowIndex].Cells[5].FindControl("tbKolicina") as TextBox;
            if (tbKolicinaE != null)
            {
                kolicina = int.Parse(tbKolicinaE.Text);
                knjiga.kolicina = kolicina;
            }

            TextBox tbGodinaIzdanjaE = gvSveKnjige.Rows[e.RowIndex].Cells[4].FindControl("tbGodinaIzdanja") as TextBox;
            if (tbGodinaIzdanjaE != null)
            {
                godinaIzdanja = int.Parse(tbGodinaIzdanjaE.Text);
                knjiga.godinaIzdanja = godinaIzdanja;
            }

            bdc.SubmitChanges();
            gvSveKnjige.EditIndex = -1;
            BindDataToGridView();
            

        }

        protected void gvSveKnjige_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvSveKnjige.EditIndex = -1;
            BindDataToGridView();
        }
    }
}