using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ASPBlog : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Hakkımda kısmı veritabanından getirildi..
        DataSetTableAdapters.TblHakkimdaTableAdapter dt = new DataSetTableAdapters.TblHakkimdaTableAdapter(); //nesnemizi ürettik
        Repeater1.DataSource = dt.GetDataAbout(); //tablomuzu repeater ile bağladık
        Repeater1.DataBind();

        //Deneyimlerim kısmı veritabanından getirildi..
        DataSetTableAdapters.TblDeneyimTableAdapter dt1 = new DataSetTableAdapters.TblDeneyimTableAdapter();
        Repeater2.DataSource = dt1.GetDataExperience();
        Repeater2.DataBind();

        //Eğitim hayatım getirildi..
        DataSetTableAdapters.TblEgitimTableAdapter dt2 = new DataSetTableAdapters.TblEgitimTableAdapter();
        Repeater3.DataSource = dt2.GetDataEducation();
        Repeater3.DataBind();

        //Yetenekler Getir
        DataSetTableAdapters.TblYeteneklerTableAdapter dt3 = new DataSetTableAdapters.TblYeteneklerTableAdapter();
        Repeater4.DataSource = dt3.GetDataSkills();
        Repeater4.DataBind();

        //Hobiler Getir
        DataSetTableAdapters.TblHobilerTableAdapter dt5 = new DataSetTableAdapters.TblHobilerTableAdapter();
        Repeater5.DataSource = dt5.GetDataHobbies();
        Repeater5.DataBind();

        //Oduller Getir
        DataSetTableAdapters.TblOdullerTableAdapter dt6 = new DataSetTableAdapters.TblOdullerTableAdapter();
        Repeater6.DataSource = dt6.GetData();
        Repeater6.DataBind();

    }
}