
<%@ Page Title="Prikaz knjiga" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registracija.aspx.cs" Inherits="Biblioteka.Registracija" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div id="divRegistracija" class="jumbotron" style="width:600px; margin: 20px auto;">
        <asp:Label runat="server" Text="Ime:" ></asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox runat="server" ID="tbIme"  ></asp:TextBox><br /><br />
            
        <asp:Label runat="server" Text="Prezime:" ></asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox runat="server" ID="tbPrezime" ></asp:TextBox><br /><br />
            
        <asp:Label runat="server" Text="Adresa:" ></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox runat="server" ID="tbAdresa" ></asp:TextBox><br /><br />
            
        <asp:Label runat="server" Text="E-mail:" ></asp:Label> &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox runat="server" ID="tbEmail" ></asp:TextBox><br /><br />
            
        <asp:Label runat="server" Text="Broj telefona:" ></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox runat="server" ID="tbBrojTelefona" ></asp:TextBox><br /><br />
        
        <asp:Label runat="server" Text="Korisnicko ime:" ></asp:Label>&nbsp;&nbsp;
        <asp:TextBox runat="server" ID="tbUsername" ></asp:TextBox><br /><br />
            
        <asp:Label runat="server" Text="Sifra:" ></asp:Label>&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox runat="server" ID="tbPassword" ></asp:TextBox><br /><br />

        <asp:Button ID="btRegistruj" Text="Registruj se"  runat="server" OnClick="btRegistruj_Click"/><br /><br />
         
            U koliko ste vec registrovani, prijavite se:
       
            <a href="Login">Prijavi se &raquo;</a>
        
    </div>
</asp:Content>