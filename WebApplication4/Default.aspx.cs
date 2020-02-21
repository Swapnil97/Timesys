using System;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Web.UI;

namespace WebApplication4
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Upload_Click(object sender, EventArgs e)
        {
            //declare variables - edit these based on your particular situation   
            string ssqltable = "TimesheetExcel";
            string excelFilePath = "C:/Users/v7112231/Desktop/CombinedOne.xlsx";
            // make sure your sheet name is correct, here sheet name is sheet1,
            //so you can change your sheet name if have different
            string myexceldataquery = "select [Week Commence],[Team],[Shift],[Name],[Application],[Task],[Reference Number],[Activity],[Release],[Priority/Severity],[Description],[Start Date],[Hours spent this week],[Month] from [Sheet1$]";
            try
            {
                //create our connection strings   
               // string sexcelconnectionstring = @"provider=microsoft.jet.oledb.4.0;data source=" + excelFilePath + ";extended properties=" + "\"excel 8.0;hdr=yes;\"";
                string ssqlconnectionstring = "Data Source=INAIRDT541647;Initial Catalog=TrailTimeSys;Integrated Security=True";
                string sexcelconnectionstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excelFilePath + ";Extended Properties=" + "\"excel 12.0;hdr=yes;\"";
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
                Label1.Text = "Successful Uploading";
            }
            catch (Exception ex)
            {
                //handle exception  
                Label1.Text = ex.Message;
            }
        }
    }
    }