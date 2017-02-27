using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for ErrorHandler
/// </summary>
public static class ErrorHandler
{
    //public ErrorHandler()
    //{
    //    //
    //    // TODO: Add constructor logic here
    //    //
    //}

    public static string HandleError(Exception e)
    {
        string errorMessage = null;
        if (e is SqlException)
        {
            SqlException newSql = e as SqlException;
            int i = newSql.Number;
            switch (i)
            {
                case 1449:
                    errorMessage = "Could not connect to database. Invalid server connection string.";
                break;

                case 208:
                    errorMessage = "Selected table does not exist.";
                break;

                case 1479: //Timeout från databasen
                    errorMessage = "Could not connect to database. Check your network connection.";
                break;

                default:
                    errorMessage = "Unknown error.";
                break;
            }
        }

        return errorMessage;
    }
}