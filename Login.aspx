<%@ Page Title="Prijava korisnika" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Biblioteka.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
 
         <div class="jumbotron" style="margin: 20px auto; width:500px;">
                <h2>Prijava</h2>
                <asp:Label runat="server" Text="Korisnicko ime:" ></asp:Label>
                <asp:TextBox runat="server" ID="tbUsernameLogin" ></asp:TextBox><br /><br />
            
                <asp:Label runat="server" Text="Sifra:" ></asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox runat="server"  ID="tbSifraLogin"  TextMode="Password">
         
                </asp:TextBox><br /><br />

                <asp:Button ID="login" runat="server" Text="Login" OnClick="login_Click"/>
                <br />
                <p style="color:red;" id="error" runat="server"></p>
        </div>
    
</asp:Content>