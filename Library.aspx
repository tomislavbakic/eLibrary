<%@ Page Title="Prikaz knjiga" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Library.aspx.cs" Inherits="Biblioteka.Library" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div id="prikazKnjiga" runat="server" style =" text-align:center ;width:800px; margin: 20px auto; padding:20px 50px; background-color:silver; border-radius:7px;">
        <h2>Prikaz svih knjiga</h2>
        <asp:GridView HorizontalAlign="Center" ID="gvSveKnjige"  runat="server" AutoGenerateColumns="false" DataKeyNames="id" OnRowDeleting="gvSveKnjige_RowDeleting" ForeColor="#333333" GridLines="None" Width="700px"  HeaderStyle-Font-Bold="true" HeaderStyle-BackColor="Crimson" HeaderStyle-Height="50px">
            <AlternatingRowStyle BackColor="White" ForeColor="Crimson"/>
            <Columns>
                <asp:TemplateField Visible="true" HeaderText="#">
                    <ItemTemplate>
                        <asp:Label ID="lbID" runat="server" Text='<%# Bind("id") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Naslov knjige" ControlStyle-Font-Bold="true"  HeaderStyle-HorizontalAlign="Center">
                   
                    <ItemTemplate>
                        <asp:Label ID="lbNaslov" runat="server" Text='<%# Bind("naslov") %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle"/>
                </asp:TemplateField >
                <asp:TemplateField HeaderText="Pisac" >
                   
                    <ItemTemplate>
                        <asp:Label ID="lbAutor" runat="server" Text='<%# Bind("autor") %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle"/>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Godina izdanja">
                    
                    <ItemTemplate>
                        <asp:Label ID="lbGodinaIzdanja" runat="server" Text='<%# Bind("godinaIzdanja") %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Kolicina">
                   
                    <ItemTemplate>
                        <asp:Label CssClass="stil" ID="lbKolicina" runat="server" Text='<%# Bind("kolicina") %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle"/>
                </asp:TemplateField>
              
                <asp:CommandField ButtonType="Button" ShowDeleteButton="True" DeleteText="Naruci"  ControlStyle-Height ="50px">
                     <ControlStyle BackColor="Crimson" ForeColor="White"  />
                </asp:CommandField>

            </Columns>

             <EditRowStyle BackColor="#999999" />
            
            <HeaderStyle BackColor="Gray" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
         
        </asp:GridView>
    </div>
</asp:Content>