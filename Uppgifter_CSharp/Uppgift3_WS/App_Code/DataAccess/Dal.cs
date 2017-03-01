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
    private static string conStr;
    private static SqlConnection Connection { get; set; }
    private static SqlDataReader DataReader { get; set; }   
    private static List<Employee> Employees { get; set; }
    private static List<EmployeeRelative> EmployeeRelatives { get; set; }
    private static List<string> DataList { get; set; }
    private static List<Index> Indices { get; set; }
    private static List<Constraint> Constraints { get; set; }
    private static string Query { get; set; }

    static Dal()
    {
        conStr = ConfigurationManager.ConnectionStrings["Cronus"].ConnectionString;      
    }

    public static List<Employee> GetEmployees()
    {
        OpenConnection();
        Query = "select [No_], [First Name], [Last Name], [Job Title], City from [CRONUS Sverige AB$Employee]";
        SqlCommand cmd = new SqlCommand(Query, Connection);
        DataReader = cmd.ExecuteReader();
        Employees = new List<Employee>();

        while (DataReader.Read())
        {
            Employee e = new Employee();
            e.EmployeeNumber = DataReader["No_"].ToString();
            e.FirstName = DataReader["First Name"].ToString();
            e.LastName = DataReader["Last Name"].ToString();
            e.Title = DataReader["Job Title"].ToString();
            e.City = DataReader["City"].ToString();
            
            Employees.Add(e);
        }
        CloseConnection();
        return Employees;
    }

    public static List<EmployeeRelative> GetEmployeeRelatives()
    {       
        OpenConnection();
        Query = "select [Employee No_] , [First Name], [Last Name], [Relative Code] from [CRONUS Sverige AB$Employee Relative]";
        SqlCommand cmd = new SqlCommand(Query, Connection);
        DataReader = cmd.ExecuteReader();
        EmployeeRelatives = new List<EmployeeRelative>();

        while (DataReader.Read())
        {
            EmployeeRelative relative = new EmployeeRelative();
            relative.FirstName = DataReader["First Name"].ToString();
            relative.LastName = DataReader["Last Name"].ToString();
            relative.EmployeeNumber = DataReader["Employee No_"].ToString();
            EmployeeRelatives.Add(relative);
        }
        CloseConnection();
        return EmployeeRelatives;
    }

    public static List<Employee> GetSickleave()
    {
        OpenConnection();
        Query = "select [Employee No_], [First Name], [Last Name], b.[From Date], b.[Cause of Absence Code] from [CRONUS Sverige AB$Employee] as a join [CRONUS Sverige AB$Employee Absence] as b on a.No_=b.[Employee No_] where (select year (b.[From Date]) as year) like '2004' and b.[Cause of Absence Code] = 'SJUK'";
        SqlCommand cmd = new SqlCommand(Query, Connection);
        DataReader = cmd.ExecuteReader();
        Employees = new List<Employee>();

        while (DataReader.Read())
        {
            Employee e = new Employee();
            e.FirstName = DataReader["First Name"].ToString();
            e.LastName = DataReader["Last Name"].ToString();
            e.EmployeeNumber = DataReader["Employee No_"].ToString();
           
            DateTime date;
            if (DateTime.TryParse(DataReader["From Date"].ToString(), out date))
                e.FromDate = date;
            e.AbsenceCause = DataReader["Cause of Absence Code"].ToString();
            Employees.Add(e);
        }
        CloseConnection();
        return Employees;
        
    }

    public static List<Employee> GetMostSick()
    {
        OpenConnection();
        Query = "select top 3 b.[First Name], Count(a.Description) as 'Number of days' from [CRONUS Sverige AB$Employee Absence] as a join [CRONUS Sverige AB$Employee] as b on b.No_=a.[Employee No_] where a.Description='Sjuk' group by b.[First Name],a.Description";
        SqlCommand cmd = new SqlCommand(Query, Connection);
        DataReader = cmd.ExecuteReader();
        Employees = new List<Employee>();

        while (DataReader.Read())
        {
            Employee e = new Employee();
            e.FirstName = DataReader["First Name"].ToString();
            e.NumberOfSickDays = Convert.ToInt32(DataReader["Number of days"].ToString());
            Employees.Add(e);
        }
        CloseConnection();
        return Employees;
    }

    public static List<string> GetKeys()
    {
        OpenConnection();
        Query = "select top 20 column_name as [Key] from [Demo Database NAV (5-0)].INFORMATION_SCHEMA.KEY_COLUMN_USAGE";
        SqlCommand cmd = new SqlCommand(Query, Connection);
        DataReader = cmd.ExecuteReader();
        DataList = new List<string>();

        while (DataReader.Read())
        {
            string test = DataReader["Key"].ToString();
            DataList.Add(test);
        }
        CloseConnection();
        return DataList;
    }

    public static List<Index> GetIndices()
    {
        OpenConnection();
        Query = "select top 20 object_id as 'Object ID', name as 'Name', index_id as 'Index ID', type as 'Type', type_desc as 'Type Desc' from [Demo Database NAV (5-0)].sys.indexes order by object_id";
        SqlCommand cmd = new SqlCommand(Query, Connection);
        DataReader = cmd.ExecuteReader();
        Indices = new List<Index>();

        while (DataReader.Read())
        {
            Index i = new Index();
            i.ObjectId = DataReader["Object ID"].ToString();
            i.IndexId = DataReader["Index ID"].ToString();
            i.Name = DataReader["Name"].ToString();
            i.Type = DataReader["Type"].ToString();
            i.TypeDescription = DataReader["Type Desc"].ToString();
            Indices.Add(i);
        }
        CloseConnection();
        return Indices;
    }

    public static List<Constraint> GetConstraints()
    {
        OpenConnection();
        Query = "select top 20 CONSTRAINT_CATALOG as 'Constraint Catalog', CONSTRAINT_NAME as 'Constraint Name', TABLE_CATALOG as 'Table Catalog' from [Demo Database NAV (5-0)].INFORMATION_SCHEMA.TABLE_CONSTRAINTS order by TABLE_NAME";
        SqlCommand cmd = new SqlCommand(Query, Connection);
        DataReader = cmd.ExecuteReader();
        Constraints = new List<Constraint>();

        while (DataReader.Read())
        {
            Constraint c = new Constraint();
            c.ConstraintCatalog = DataReader["Constraint Catalog"].ToString();
            c.Name = DataReader["Constraint Name"].ToString();
            c.TableCatalog = DataReader["Table Catalog"].ToString();
            Constraints.Add(c);
        }
        CloseConnection();
        return Constraints;
    }

    public static List<string> GetTablesOne()
    {
        OpenConnection();
        Query = "select TABLE_NAME as [All tables in CRONUS Sverige AB] from [Demo Database NAV (5-0)].INFORMATION_SCHEMA.TABLES";
        SqlCommand cmd = new SqlCommand(Query, Connection);
        DataReader = cmd.ExecuteReader();
        DataList = new List<string>();

        while (DataReader.Read())
        {
            string data = DataReader["All tables in CRONUS Sverige AB"].ToString();
            DataList.Add(data);
        }
        CloseConnection();
        return DataList;
    }

    public static List<string> GetTablesTwo()
    {
        OpenConnection();
        Query = "use [Demo Database NAV (5-0)] select name as [All tables in CRONUS Sverige AB] from sys.sysobjects where xtype ='U'";
        SqlCommand cmd = new SqlCommand(Query, Connection);
        DataReader = cmd.ExecuteReader();
        DataList = new List<string>();

        while (DataReader.Read())
        {
            string data = DataReader["All tables in CRONUS Sverige AB"].ToString();
            DataList.Add(data);
        }
        CloseConnection();
        return DataList;
    }
    public static List<string> GetColumnsOne()
    {
        OpenConnection();
        Query = "select COLUMN_NAME as [Employee Columns] from [Demo Database NAV (5-0)].INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = 'CRONUS Sverige AB$Employee'";
        SqlCommand cmd = new SqlCommand(Query, Connection);
        DataReader = cmd.ExecuteReader();
        DataList = new List<string>();

        while (DataReader.Read())
        {
            string data = DataReader["Employee Columns"].ToString();
            DataList.Add(data);
        }
        CloseConnection();
        return DataList;
    }
    public static List<string> GetColumnsTwo()
    {
        OpenConnection();
        Query = "select name as [Employee Columns] from sys.columns where object_id=object_ID('CRONUS Sverige AB$Employee')";
        SqlCommand cmd = new SqlCommand(Query, Connection);
        DataReader = cmd.ExecuteReader();
        DataList = new List<string>();

        while (DataReader.Read())
        {
            string data = DataReader["Employee Columns"].ToString();
            DataList.Add(data);
        }
        CloseConnection();
        return DataList;
    }
    private static void OpenConnection()
    {
        Connection = new SqlConnection(conStr);
        Connection.Open();
    }

    private static void CloseConnection()
    {
        if (DataReader != null)
        {
            DataReader.Close();
        }
        if (Connection != null && Connection.State != ConnectionState.Closed)
        {
            Connection.Close();
        }
    }
}