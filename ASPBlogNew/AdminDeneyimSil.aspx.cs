using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminDeneyimSil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        short id = Convert.ToInt16(Request.QueryString["ID"]); //Diğer ekrandan aldığımız değer..
        DataSetTableAdapters.TblDeneyimTableAdapter dt = new DataSetTableAdapters.TblDeneyimTableAdapter();
        dt.DeleteExperience(id);
        Response.Redirect("AdminDeneyimler.aspx");
    }
}