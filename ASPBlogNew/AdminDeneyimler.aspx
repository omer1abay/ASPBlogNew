<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminDeneyimler.aspx.cs" Inherits="AdminDeneyimler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">

    <form id="Form1" runat="server">
        <!-- Kenarlı tablo -->
        <table class="table table-bordered">
            <tr>
                <th>
                    <!-- tablo başlığı -->
                    ID
                </th>
                <th>
                    <!-- tablo başlığı -->
                    BAŞLIK
                </th>
                <th>
                    <!-- tablo başlığı -->
                    ALTBAŞLIK
                </th>
                <th>
                    <!-- tablo başlığı -->
                    AÇIKLAMA
                </th>
                <th>
                    <!-- tablo başlığı -->
                    TARİH
                </th>
                <th>
                    <!-- tablo başlığı -->
                    İŞLEMLER
                </th>

            </tr>
            <tbody>
                <!-- Tablo bodysi-->
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <th><%# Eval("ID") %></th>
                            <td><%# Eval("BASLIK") %></td>
                            <td><%# Eval("ALTBASLIK") %></td>
                            <td><%# Eval("ACIKLAMA") %></td>
                            <td><%# Eval("TARIH") %></td>
                            <td>
                                <!-- ID değeri ile birlikte silme ve güncelleme ekranlarına butonlarla beraber yönlendirdik-->
                                <asp:HyperLink NavigateUrl='<%# "AdminDeneyimSil.aspx?ID=" + Eval("ID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink>
                                <asp:HyperLink NavigateUrl='<%# "AdminDeneyimGuncelle.aspx?ID=" + Eval("ID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">Güncelle</asp:HyperLink>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>

        </table>
        <asp:HyperLink NavigateUrl="~/AdminDeneyimEkle.aspx" ID="HyperLink3" runat="server" CssClass="btn btn-info">Deneyim Ekle</asp:HyperLink>
    </form>
</asp:Content>

