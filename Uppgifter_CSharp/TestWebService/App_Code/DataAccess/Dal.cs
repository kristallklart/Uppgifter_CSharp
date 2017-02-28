using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Dal
/// </summary>
public static class Dal
{
    private static SqlConnection connection;
    private static SqlDataReader dataReader;
    private static string conStr;
    private static List<Employee> allEmployees;

    static Dal()
    {
        conStr = ConfigurationManager.ConnectionStrings["Cronus"].ConnectionString;      
    }

    public static List<Employee> GetEmployees()
    {
        OpenConnection();
        string sqlString = "select [First Name], [Last Name], [Job Title], City from [CRONUS Sverige AB$Employee]";
        SqlCommand cmd = new SqlCommand(sqlString, connection);
        dataReader = cmd.ExecuteReader();
        allEmployees = new List<Employee>();

        while (dataReader.Read())
        {
            Employee e = new Employee();
            e.EmployeeNumber = dataReader["Employee No_"].ToString();
            e.FirstName = dataReader["First Name"].ToString();
            e.LastName = dataReader["Last Name"].ToString();
            e.Title = dataReader["Job Title"].ToString();
            e.City = dataReader["City"].ToString();
            
            allEmployees.Add(e);
        }
        return allEmployees;
    }
    private static void OpenConnection()
    {
        connection = new SqlConnection(conStr);
        connection.Open();
    }

    private static void CloseConnection()
    {
        if (dataReader != null)
        {
            dataReader.Close();
        }
        if (connection != null && connection.State != ConnectionState.Closed)
        {
            connection.Close();
        }
    }
}