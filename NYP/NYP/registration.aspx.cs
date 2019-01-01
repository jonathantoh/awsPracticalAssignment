using NYP.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NYP
{
    public partial class registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadSubjects();
        }

        private void LoadSubjects()
        {

            DataTable subjects = new DataTable();

                try
                {
                    BllExchangeProgram myCat = new BllExchangeProgram();
                    DataSet ds;
                    ds = myCat.getExchangeProgramList();
                    ddlProgram.DataSource = ds;
                    ddlProgram.DataTextField = "Title";
                    ddlProgram.DataValueField = "Id";
                    ddlProgram.DataBind();
                }
                catch (Exception ex)
                {
                    // Handle the error
                }


            // Add the initial item - you can add this even if the options from the
            // db were not successfully loaded
            //ddlProgram.Items.Insert(0, new ListItem("<Select Subject>", "0"));

        }

        protected void Register_Click(object sender, EventArgs e)
        {
            BllExchangeProgram myCat = new BllExchangeProgram();
            int result = myCat.register(nameTxt.Text, adminTxt.Text, coursetxt.Text, contactTxt.Text, pemTxt.Text, emergencyPerson.Text, emergencyContact.Text, System.Convert.ToInt32(ddlProgram.SelectedValue));

            if (result == 1)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Inserted Successfully')", true);
                int id = System.Convert.ToInt32(ddlProgram.SelectedValue);
                int result2 = myCat.increaseSeats(id);

                if (result2 == 1)
                {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Increased registered Successfully')", true);

                }else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Increased registered Unsuccessfully')", true);

                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Inserted Unsuccessfully')", true);
            }
        }
    }
}