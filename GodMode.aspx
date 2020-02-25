<%@ Page Title="Admin" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GodMode.aspx.cs" Inherits="Biblioteka.GodMode" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <div style="background-color:rgba(138, 136, 136, 0.50);padding:20px; border-radius:7px;">  
        <div>
            <h2 runat="server">Novi autor</h2>
            <asp:Label runat="server" Text="Ime: "></asp:Label>
            <asp:TextBox runat="server" ID="tbImeAutora"></asp:TextBox>
            <asp:Label runat="server" Text="  Prezime: "></asp:Label>
            <asp:TextBox runat="server" ID="tbPrezimeAutora"></asp:TextBox> 
            <asp:Button runat="server" Text="Dodaj autora" id="dodajAutora" OnClick="dodajAutora_Click"/>
            <p id="error" style="color:red;" runat="server"></p>
            <hr />
        </div>
        <div>
            <h2 runat="server">Dodaj novu knjigu</h2>
            <asp:Label runat="server" Text="Naslov:"></asp:Label>
            <asp:TextBox runat="server" ID="tbNaslov"></asp:TextBox>
            <asp:DropDownList ID="ddlAutor" runat="server"></asp:DropDownList>
        
            <asp:Label runat="server" Text=" Godina izdanja: "></asp:Label>
            <asp:TextBox runat="server" ID="tbGodinaIzdanja"></asp:TextBox>
            <asp:Label runat="server" Text=" Kolicina: "></asp:Label>
            <asp:TextBox runat="server" ID="tbKolicina"></asp:TextBox>
            <asp:Button runat="server" ID="brDodajKnjigu"  Text="Dodaj knjigu" OnClick="brDodajKnjigu_Click"/> <br /><br />
            <hr />

             <h2 runat="server">Prikaz svih knjiga</h2>
             <asp:GridView HorizontalAlign="Center" ID="gvSveKnjige"  runat="server" AutoGenerateColumns="false" DataKeyNames="id" OnRowEditing="gvSveKnjige_RowEditing" OnRowCancelingEdit="gvSveKnjige_RowCancelingEdit" OnRowUpdating="gvSveKnjige_RowUpdating"  OnRowDeleting="gvSveKnjige_RowDeleting" ForeColor="#333333" GridLines="None" Width="1000px"  HeaderStyle-Font-Bold="true" HeaderStyle-BackColor="Crimson" HeaderStyle-Height="50px">
            <AlternatingRowStyle BackColor="White" ForeColor="Crimson"/>
            <Columns>
                <asp:TemplateField Visible="true" HeaderText="#">
                   
                    <ItemTemplate>
                        <asp:Label ID="lbID" runat="server" Text='<%# Bind("id") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Naslov knjige" ControlStyle-Font-Bold="true"   HeaderStyle-HorizontalAlign="Center">
                    <EditItemTemplate>
                        <asp:TextBox  ID="tbNaslov" runat="server" Text='<%# Bind("naslov") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbNaslov" runat="server" Text='<%# Bind("naslov") %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle"/>
                </asp:TemplateField >
                <asp:TemplateField HeaderText="Pisac" >
                   
                    <ItemTemplate>
                        <asp:Label ID="lbAutor" runat="server" Text='<%# Bind("autor") %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"/>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Godina izdanja">
                    <EditItemTemplate>
                        <asp:TextBox  ID="tbGodinaIzdanja" runat="server" Text='<%# Bind("godinaIzdanja") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbGodinaIzdanja" runat="server" Text='<%# Bind("godinaIzdanja") %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Kolicina">
                    <EditItemTemplate>
                        <asp:TextBox  ID="tbKolicina" runat="server" Text='<%# Bind("kolicina") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label  ID="lbKolicina" runat="server" Text='<%# Bind("kolicina") %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"/>
                </asp:TemplateField>

                <asp:CommandField ButtonType="Button" ShowEditButton="True" DeleteText="Izmeni">
                     <ControlStyle BackColor="Green" ForeColor="White" />
                </asp:CommandField>
                <asp:CommandField ButtonType="Button" ShowDeleteButton="True" DeleteText="Obrisi">
                     <ControlStyle BackColor="Red" ForeColor="White" />
                </asp:CommandField>

            </Columns>

             
            <HeaderStyle BackColor="Crimson" Font-Bold="True" ForeColor="White" HorizontalAlign="Center"/>
            <PagerStyle BackColor="#284175" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            
        </asp:GridView>








        </div>
    </div> 
</asp:Content>