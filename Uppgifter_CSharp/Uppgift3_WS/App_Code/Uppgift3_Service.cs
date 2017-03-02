using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using System.Web.Services;
using DataAccessLayer;
using Models;
[WebService(Namespace = "Grupp7", Description = "This web service has multiple web methods for retrieving data from the Cronus-database. " +
                                                "The web service also has methods for inserting, deleting and updating data in the Employee table, these methods will " +
                                                "return an int of value 1 if the query executed succesfully and 0 otherwise. If an error occurs the methods will throw a FaultException for .NET environments " +
                                                "and a RemoteException for Java environments. These exceptions must be handled by the client.")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]

public class Service : System.Web.Services.WebService
{
    public Service () 
    {

    }

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }

    [WebMethod]
    public List<Employee> GetEmployees()
    {
        return Dal.GetEmployees();
    }

    [WebMethod]
    public List<EmployeeRelative> GetEmployeeRelatives()
    {
        return Dal.GetEmployeeRelatives();
    }

    [WebMethod]
    public List<Employee> GetSickleave()
    {
        return Dal.GetSickleave();
    }

    [WebMethod]
    public List<Employee> GetMostSick()
    {
        return Dal.GetMostSick();
    }
    [WebMethod]
    public List<string> GetKeys()
    {
        return Dal.GetKeys();
    }
    [WebMethod]
    public List<Index> GetIndices()
    {
        return Dal.GetIndices();
    }
    [WebMethod]
    public List<TableConstraint> GetConstraints()
    {
        return Dal.GetConstraints();
    }
    [WebMethod]
    public List<string> GetTablesOne()
    {
        return Dal.GetTablesOne();
    }
    [WebMethod]
    public List<string> GetTablesTwo()
    {
        return Dal.GetTablesTwo();
    }
    [WebMethod]
    public List<string> GetColumnsOne()
    {
        return Dal.GetColumnsOne();
    }
    [WebMethod]
    public List<string> GetColumnsTwo()
    {
        return Dal.GetColumnsTwo();
    }

    [WebMethod]
    public int UpdateEmployee(string employeeNumber, string firstname, string lastname)
    {
        return Dal.UpdateEmployee(employeeNumber, firstname, lastname);
    }

    [WebMethod]
    public int AddEmployee(string employeeNumber, string firstname, string lastname)
    {
        return Dal.AddEmployee(employeeNumber, firstname, lastname);
    }

    [WebMethod]
    public int DeleteEmployee(string employeeNumber)
    {
        return Dal.DeleteEmployee(employeeNumber);
    }
}