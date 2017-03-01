using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

[WebService(Namespace = "Grupp7", Description = "bladflkjasdf")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]

public class Service : System.Web.Services.WebService
{
    public Service () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
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
    public List<Constraint> GetConstraints()
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
}