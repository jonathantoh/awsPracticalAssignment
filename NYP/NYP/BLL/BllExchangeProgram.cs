using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using NYP.DAL;

namespace NYP.BLL
{
    public class BllExchangeProgram
    {
        //private Double calculateRetailPrice(Double rrp)
        //{
        //    Double retailPrice;
        //    // we reduce the rpp by 5% and use Math.Round to round up the result to 2 decimal places.
        //    retailPrice = Math.Round(rrp * 0.95, 2);
        //    return retailPrice;
        //}
        public DataSet getExchangeProgramList()
        {
            DalFlyTA dal;
            DataSet dataSetBooksList;
            //DataTable dt;

            //Double rrp;
            dal = new DalFlyTA();
            dataSetBooksList = dal.GetPrograms();

            // Business Logic
            // Acme Book Shop wants to offer the books at 5% below RRP, so we need to write
            // code here to create a new column in the data and fill it with the new price.
            //
            // 1. Get a reeference to the Data Table
            //dt = dataSetBooksList.Tables[0];
            //// 2. Add a new column
            //dt.Columns.Add("RetailPrice", typeof(double));
            //// 3. Check table is not empty
            //if (dt.Rows.Count != 0)
            //{
            //    //// 4. Loop through each row, calculate the retail price 
            //    //// and store into the new column
            //    //foreach (DataRow dr in dt.Rows)
            //    //{
            //    //    // Get RRP
            //    //    rrp = Convert.ToDouble(dr["rrp"]);
            //    //    // Calculate retail price and store in new column
            //    //    dr["RetailPrice"] = calculateRetailPrice(rrp);

            //    //}

            //}
            return dataSetBooksList;
        }

        public int register(string Name, string Admin_No, string Course, string Contact_No, string PEM_Group, string Emergency_Person, string Emergency_Contact, int OSEP_ID)
        {
            DalNYP myCat = new DalNYP();
            int result = myCat.registerStudents(Name, Admin_No, Course, Contact_No, PEM_Group, Emergency_Person, Emergency_Contact, OSEP_ID);

            return result;
        }

        public int increaseSeats(int Id)
        {
            DalFlyTA myCat = new DalFlyTA();
            int result = myCat.increaseSeats(Id);

            return result;
        }
    }
}