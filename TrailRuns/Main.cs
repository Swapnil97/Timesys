﻿using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TrailRuns
{
    public class Main
    {
        public void ImportDataFromExcel(string excelFilePath)
        {
            //declare variables - edit these based on your particular situation   
            string ssqltable = "Runone";
            // make sure your sheet name is correct, here sheet name is sheet1,
            //so you can change your sheet name if have different
            string myexceldataquery = "select Top 10 * from [TimesheetExample$]";
            try
            {
                //create our connection strings   
            string sexcelconnectionstring = @"provider=microsoft.jet.oledb.4.0;data source=" + excelFilePath + ";extended properties=" + "\"excel 8.0;hdr=yes;\"";
                string ssqlconnectionstring = "Data Source=INAIRDT541647;Initial Catalog=TimeSys;Integrated Security=True";
                //execute a query to erase any previous data from our destination table   
                string sclearsql = "delete from " + ssqltable;
                SqlConnection sqlconn = new SqlConnection(ssqlconnectionstring);
                SqlCommand sqlcmd = new SqlCommand(sclearsql, sqlconn);
                sqlconn.Open();
                sqlcmd.ExecuteNonQuery();
                sqlconn.Close();
                //series of commands to bulk copy data from the excel file into our sql table   
                OleDbConnection oledbconn = new OleDbConnection(sexcelconnectionstring);
                OleDbCommand oledbcmd = new OleDbCommand(myexceldataquery, oledbconn);
                oledbconn.Open();
                OleDbDataReader dr = oledbcmd.ExecuteReader();
                SqlBulkCopy bulkcopy = new SqlBulkCopy(ssqlconnectionstring);
                bulkcopy.DestinationTableName = ssqltable;
                while (dr.Read())
                {
                    bulkcopy.WriteToServer(dr);
                }
                dr.Close();
                oledbconn.Close();
            }
            catch (Exception)
            {
                //handle exception   
                Console.WriteLine("Debug to find out the error:");
            }
        }
    }
}