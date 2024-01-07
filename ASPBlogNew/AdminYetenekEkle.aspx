<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminYetenekEkle.aspx.cs" Inherits="AdminYetenekEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <form id="Form1" runat ="server">
        <div class = "form-group">
            <div>
                <asp:Label ID="Label1" runat="server" Text="BAŞLIK"></asp:Label>
                <asp:TextBox ID="txtYetenek" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <asp:Button ID ="btnGuncelle" runat="server" Text="Kaydet" CssClass="btn btn-primary" OnClick="Button1_Click" />
        </div>
    </form>
</asp:Content>

