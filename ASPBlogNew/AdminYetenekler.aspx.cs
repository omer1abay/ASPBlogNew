using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminYetenekler : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int id = Convert.ToInt16( Request.QueryString["ID"]);
        DataSetTableAdapters.TblYeteneklerTableAdapter dt = new DataSetTableAdapters.TblYeteneklerTableAdapter();
        Repeater1.DataSource = dt.GetDataSkills();
        Repeater1.DataBind();

        if(id != 0)
        {
            dt.DeleteSkills(Convert.ToInt16(id));
            Response.Redirect("AdminYetenekler.aspx");
        }

    }
}