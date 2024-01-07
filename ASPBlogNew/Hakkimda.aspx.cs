using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Hakkimda : System.Web.UI.Page
{
    DataSetTableAdapters.TblHakkimdaTableAdapter dt = new DataSetTableAdapters.TblHakkimdaTableAdapter();

    protected void Page_Load(object sender, EventArgs e)
    {
        //verileri getirme

        if (Page.IsPostBack == false) //sayfayı bir kere yükledikten sonra hafızadaki veriyi değil de güncellenmiş veriyi getirir.
        {
            TextBox1.Text = dt.GetDataAbout()[0].AD;
            TextBox2.Text = dt.GetDataAbout()[0].SOYAD;
            TextBox3.Text = dt.GetDataAbout()[0].ADRES;
            TextBox4.Text = dt.GetDataAbout()[0].EMAIL;
            TextBox5.Text = dt.GetDataAbout()[0].TELEFON;
            TextBox6.Text = dt.GetDataAbout()[0].HAKKIMDA;
            TextBox7.Text = dt.GetDataAbout()[0].FOTOGRAF;
        }

        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        dt.UpdateAbout(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text);
        Response.Redirect("ASPBlog.aspx"); // yönlendirme işlemi

    }
}