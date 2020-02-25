<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Biblioteka._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron" style="background-color:crimson; margin-top: 20px;">
        <h1>eBiblioteka</h1>
        <p class="lead">Online platforma za iznajmljivanje knjiga.</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Registracija</h2>
            <p>
                Ukoliko korisnik nema nalog potrebno je da se registruje.
                Samo registrovani korisnici mogu iznajmljivati knjige.
            </p>
            <p>
                <a class="btn btn-default" href="Registracija">Registruj se &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Biblioteka</h2>
            <p>
                Ovde mozete videti sve knjige koje se nalaze u eBiblioteci i mozete izabrati zeljenu knjigu.
            </p>
            <p>
                 <a class="btn btn-default" href="Login">Prijavi se &raquo;</a> &nbsp;&nbsp;
                <a class="btn btn-default" href="Library">Izaberi knjigu &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Prijava admina</h2>
            <p>
                Admin ima pristup svim podacima. Nakon prijave moze da dodaje i brise knjige i dodaje nove autore.
            </p>
            <p>
               
                <a class="btn btn-default" href="GodMode">Pristup &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
