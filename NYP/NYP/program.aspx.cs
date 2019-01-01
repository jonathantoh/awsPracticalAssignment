using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using NYP.BLL;

namespace NYP
{
    public partial class program : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
                BindBooksList();
        }
        private void BindBooksList()
        {
            BllExchangeProgram myCat = new BllExchangeProgram();
            DataSet ds;
            ds = myCat.getExchangeProgramList();
            GV_Exchange_List.DataSource = ds;
            GV_Exchange_List.DataBind();
        }

        protected void regiser_Click(object sender, EventArgs e)
        {
            Response.Redirect("registration.aspx");
        }
    }
}