using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminEgitimEkle : System.Web.UI.Page
{
    int id;

    protected void Page_Load(object sender, EventArgs e)
    {
        
        id = Convert.ToInt16(Request.QueryString["ID"]); 

        if (id != 0)
        {
            DataSetTableAdapters.TblEgitimTableAdapter dt = new DataSetTableAdapters.TblEgitimTableAdapter();
            
            if (Page.IsPostBack == false)
            {
                TextBox1.Text = dt.GetDataById(Convert.ToInt16(id))[0].BASLIK;
                TextBox2.Text = dt.GetDataById(Convert.ToInt16(id))[0].ALTBASLIK;
                TextBox3.Text = dt.GetDataById(Convert.ToInt16(id))[0].ACIKLAMA;
                TextBox4.Text = dt.GetDataById(Convert.ToInt16(id))[0].GNO;
                TextBox5.Text = dt.GetDataById(Convert.ToInt16(id))[0].TARIH;
            }
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        DataSetTableAdapters.TblEgitimTableAdapter dt = new DataSetTableAdapters.TblEgitimTableAdapter();
        if (id != 0)
        {
            dt.UpdateEducation(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, Convert.ToInt16(id));
            Response.Redirect("AdminEgitim.aspx");
        }
        else
        {
            dt.InsertEducation(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text);
            Response.Redirect("AdminEgitim.aspx");
        }
    }
}