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
            int i = newSql.ErrorCode;
            switch (i)
            {
                case 2627:
                    errorMessage = "User already exists.";
                break;

                case 40:
                    errorMessage = "Could not open connection";
                break;

                case 208:
                    errorMessage = "Selected table does not exist";
                break;

                default:
                errorMessage = "Some fucking shit happened.";
                break;
            }
        }

        return errorMessage;
    }
}