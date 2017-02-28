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
    private static List<EmployeeRelative> allEmployeRelatives;
    //asdasdasd

    static Dal()
    {
        conStr = ConfigurationManager.ConnectionStrings["Cronus"].ConnectionString;      
    }

    public static List<Employee> GetEmployees()
    {
        OpenConnection();
        string sqlString = "select [No_], [First Name], [Last Name], [Job Title], City from [CRONUS Sverige AB$Employee]";
        SqlCommand cmd = new SqlCommand(sqlString, connection);
        dataReader = cmd.ExecuteReader();
        allEmployees = new List<Employee>();

        while (dataReader.Read())
        {
            Employee e = new Employee();
            e.EmployeeNumber = dataReader["No_"].ToString();
            e.FirstName = dataReader["First Name"].ToString();
            e.LastName = dataReader["Last Name"].ToString();
            e.Title = dataReader["Job Title"].ToString();
            e.City = dataReader["City"].ToString();
            
            allEmployees.Add(e);
        }
        CloseConnection();
        return allEmployees;
    }

    public static List<EmployeeRelative> GetEmployeeRelatives()
    {       
        OpenConnection();
        string sqlString = "select [Employee No_] , [First Name], [Last Name], [Relative Code] from [CRONUS Sverige AB$Employee Relative]";
        SqlCommand cmd = new SqlCommand(sqlString, connection);
        dataReader = cmd.ExecuteReader();
        allEmployeRelatives = new List<EmployeeRelative>();

        while (dataReader.Read())
        {
            EmployeeRelative relative = new EmployeeRelative();
            relative.FirstName = dataReader["First Name"].ToString();
            relative.LastName = dataReader["Last Name"].ToString();
            relative.EmployeeNumber = dataReader["Employee No_"].ToString();
            allEmployeRelatives.Add(relative);
        }
        CloseConnection();
        return allEmployeRelatives;
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