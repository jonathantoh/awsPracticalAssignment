using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace NYP.DAL
{
    public class DalNYP
    {
        public int registerStudents(string Name, string Admin_No, string Course, string Contact_No, string PEM_Group, string Emergency_Person, string Emergency_Contact, int OSEP_ID)
        {
            int result = 0;
            string strConnString = ConfigurationManager.ConnectionStrings["NYP"].ConnectionString;
            SqlConnection myConnect = new SqlConnection(strConnString);
            string strCommand = "INSERT INTO Registration VALUES(@Name, @Admin_No, @Course, @Contact_No, @PEM_Group, @Emergency_Person, @Emergency_Contact, @OSEP_ID)";
            SqlCommand cmd = new SqlCommand(strCommand, myConnect);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Admin_No", Admin_No);
            cmd.Parameters.AddWithValue("@Course", Course);
            cmd.Parameters.AddWithValue("@Contact_No", Contact_No);
            cmd.Parameters.AddWithValue("@PEM_Group", PEM_Group);
            cmd.Parameters.AddWithValue("@Emergency_Person", Emergency_Person);
            cmd.Parameters.AddWithValue("@Emergency_Contact", Emergency_Contact);
            cmd.Parameters.AddWithValue("@OSEP_ID", OSEP_ID);
            myConnect.Open();
            result += cmd.ExecuteNonQuery();
            myConnect.Close();
            return result;

        }
    }
}