<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminDeneyimGuncelle.aspx.cs" Inherits="AdminDeneyimGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

    <form id="Form1" runat ="server">
        <div class = "form-group">
            <div>
                <asp:Label ID="Label5" runat="server" Text="ID"></asp:Label>
                <asp:TextBox ID="txtId" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label1" runat="server" Text="BAŞLIK"></asp:Label>
                <asp:TextBox ID="txtBaslik" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br /> <!-- bir satır boşluk bırak -->
            <div>
                <asp:Label ID="Label2" runat="server" Text="ALTBAŞLIK"></asp:Label>
                <asp:TextBox ID="txtAltBaslik" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br /> <!-- bir satır boşluk bırak -->
            <div>
                <asp:Label ID="Label3" runat="server" Text="AÇIKLAMA"></asp:Label>
                <asp:TextBox ID="txtAciklama" runat="server" CssClass="form-control" Height="100px" TextMode="MultiLine"></asp:TextBox>
            </div>
            <br /> <!-- bir satır boşluk bırak -->
            <div>
                <asp:Label ID="Label4" runat="server" Text="TARİH"></asp:Label>
                <asp:TextBox ID="txtTarih" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <asp:Button ID ="btnGuncelle" runat="server" Text="Güncelle" CssClass="btn btn-primary" OnClick="Button1_Click" />

        </div>
    </form>

</asp:Content>

