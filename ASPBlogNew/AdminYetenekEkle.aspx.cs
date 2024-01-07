using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminYetenekEkle : System.Web.UI.Page
{
    DataSetTableAdapters.TblYeteneklerTableAdapter dt = new DataSetTableAdapters.TblYeteneklerTableAdapter();
    int id;

    protected void Page_Load(object sender, EventArgs e)
    {
        id = Convert.ToInt16( Request.QueryString["ID"]);

        if (id != 0)
        {
            if (Page.IsPostBack == false)
            {
                txtYetenek.Text = dt.GetSkillById(Convert.ToInt16(id))[0].YETENEK;
            }
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (id != 0)
        {
            dt.UpdateSkill(txtYetenek.Text, Convert.ToInt16(id));
        }
        else
        {
            dt.InsertSkill(txtYetenek.Text);
        }
        Response.Redirect("AdminYetenekler.aspx");
    }
}