using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminEgitim : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSetTableAdapters.TblEgitimTableAdapter dt = new DataSetTableAdapters.TblEgitimTableAdapter();
        Repeater1.DataSource = dt.GetDataEducation();
        Repeater1.DataBind();
    }
}