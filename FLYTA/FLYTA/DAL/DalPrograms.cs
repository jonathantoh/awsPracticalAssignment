﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Text;

namespace FLYTA.DAL
{
        public class DalPrograms
        {
        private String errMsg;
        DalDbConn dbCon = new DalDbConn();

            //Display at OSEP Page
            public SqlDataReader getReader()
            {
                string connString = ConfigurationManager.ConnectionStrings["FLY-TA"].ConnectionString;
                SqlConnection myConnect = new SqlConnection(connString);
                string strComText = "SELECT * FROM OSEP";
                SqlCommand cmd = new SqlCommand(strComText, myConnect);
                myConnect.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return reader;
            }

        public DataSet GetAll()
        {
            StringBuilder sql;
            SqlDataAdapter da;
            DataSet booksData;

            SqlConnection conn = dbCon.GetConnection();
            booksData = new DataSet();
            sql = new StringBuilder();
            sql.AppendLine("SELECT * FROM OSEP");
            

            try
            {
                da = new SqlDataAdapter(sql.ToString(), conn);
                da.Fill(booksData);
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return booksData;
        }

        public DataSet GetAllAvailableOSEP()
        {
            StringBuilder sql;
            SqlDataAdapter da;
            DataSet osepData;
            SqlConnection conn = dbCon.GetConnection();
            osepData = new DataSet();
            sql = new StringBuilder();
            sql.AppendLine("Select *");
            sql.AppendLine("From OSEP");
            sql.AppendLine("Where Quota > No_Of_Registered");
            try
            {
                da = new SqlDataAdapter(sql.ToString(), conn);
                da.Fill(osepData);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return osepData;
        }

        public int IncreaseRegisteredSeats(int Id)
        {
            StringBuilder sql;
            SqlCommand SQLcmd;
            int result = 0;
            SqlConnection conn = dbCon.GetConnection();
            sql = new StringBuilder();
            sql.AppendLine("Update OSEP");
            sql.AppendLine("Set No_OF_Registered = No_OF_Registered + 1");
            sql.AppendLine("Where Id=@Id");
            conn.Open();
            try
            {
                SQLcmd = new SqlCommand(sql.ToString(), conn);
                SQLcmd.Parameters.AddWithValue("@Id", Id);
                result = SQLcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return result;
        }



        public int insertExchangeProgram(string Title, string Description, string Duration, string Accommodation_Type, int Quota, int No_Of_Registered, int Fees)
            {
                int result = 0;
                string strConnString = ConfigurationManager.ConnectionStrings["FLY_TA"].ConnectionString;
                SqlConnection myConnect = new SqlConnection(strConnString);
                string strCommand = "Insert OSEP (Title, Description, Duration, Accommodation_Type, Quota, No_Of_Registered, Fees) Values(@Title, @Description, @Duration, @Accommodation_Type, @Quota, @No_Of_Registered, @Fees)";
                SqlCommand cmd = new SqlCommand(strCommand, myConnect);
                cmd.Parameters.AddWithValue("@Title", Title);
                cmd.Parameters.AddWithValue("@Description", Description);
                cmd.Parameters.AddWithValue("@Duration", Duration);
                cmd.Parameters.AddWithValue("@Accommodation_Type", Accommodation_Type);
                cmd.Parameters.AddWithValue("@Quota", Quota);
                cmd.Parameters.AddWithValue("@No_Of_Registered", No_Of_Registered);
                cmd.Parameters.AddWithValue("@Fees", Fees);
                myConnect.Open();
                result += cmd.ExecuteNonQuery();
                myConnect.Close();
                return result;
            }



        }
    }