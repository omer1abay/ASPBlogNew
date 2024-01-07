using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminDeneyimGuncelle : System.Web.UI.Page
{
    
    

    protected void Page_Load(object sender, EventArgs e)
    {
        DataSetTableAdapters.TblDeneyimTableAdapter dt = new DataSetTableAdapters.TblDeneyimTableAdapter();
        short id = Convert.ToInt16(Request.QueryString["ID"]);

        if (Page.IsPostBack == false)
        {
            txtId.Enabled = false;
            txtId.Text = id.ToString();
            txtBaslik.Text = dt.GetDataById(id)[0].BASLIK;
            txtAltBaslik.Text = dt.GetDataById(id)[0].ALTBASLIK;
            txtAciklama.Text = dt.GetDataById(id)[0].ACIKLAMA;
            txtTarih.Text = dt.GetDataById(id)[0].TARIH;
        }
        

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.TblDeneyimTableAdapter dt = new DataSetTableAdapters.TblDeneyimTableAdapter();
        short id = Convert.ToInt16(Request.QueryString["ID"]);
        dt.UpdateExperience(txtBaslik.Text, txtAltBaslik.Text, txtAciklama.Text, txtTarih.Text, Convert.ToInt16(txtId.Text));
        Response.Redirect("AdminDeneyimler.aspx");
    }
}