using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Models;

namespace DataAccessLayer
{
    public static class Dal
    {
        private static string conStr;
        private static SqlConnection connection;
        private static SqlDataReader dataReader;
        private static List<Employee> employees;
        private static List<EmployeeRelative> employeeRelatives;
        private static List<string> dataList;
        private static List<Index> indices;
        private static List<TableConstraint> constraints;
        private static string Query { get; set; }

        static Dal()
        {
            conStr = ConfigurationManager.ConnectionStrings["Cronus"].ConnectionString;
        }

        public static List<Employee> GetEmployees()
        {
            try
            {
                OpenConnection();
                Query = "select [No_], [First Name], [Last Name], [Job Title], City from [CRONUS Sverige AB$Employee]";
                SqlCommand cmd = new SqlCommand(Query, connection);
                dataReader = cmd.ExecuteReader();
                employees = new List<Employee>();

                while (dataReader.Read())
                {
                    Employee e = new Employee();
                    e.EmployeeNumber = dataReader["No_"].ToString();
                    e.FirstName = dataReader["First Name"].ToString();
                    e.LastName = dataReader["Last Name"].ToString();
                    e.Title = dataReader["Job Title"].ToString();
                    e.City = dataReader["City"].ToString();

                    employees.Add(e);
                }
                return employees;
            }
            finally
            {
                CloseConnection();
            }
        }

        public static List<EmployeeRelative> GetEmployeeRelatives()
        {
            try
            {
                OpenConnection();
                Query = "select [Employee No_] , [First Name], [Last Name], [Relative Code] from [CRONUS Sverige AB$Employee Relative]";
                SqlCommand cmd = new SqlCommand(Query, connection);
                dataReader = cmd.ExecuteReader();
                employeeRelatives = new List<EmployeeRelative>();

                while (dataReader.Read())
                {
                    EmployeeRelative relative = new EmployeeRelative();
                    relative.FirstName = dataReader["First Name"].ToString();
                    relative.LastName = dataReader["Last Name"].ToString();
                    relative.EmployeeNumber = dataReader["Employee No_"].ToString();
                    employeeRelatives.Add(relative);
                }
                return employeeRelatives;
            }
            finally
            {
                CloseConnection();
            }
        }

        public static List<Employee> GetSickleave()
        {
            try
            {
                OpenConnection();
                Query = "select [Employee No_], [First Name], [Last Name], b.[From Date], b.[Cause of Absence Code] from [CRONUS Sverige AB$Employee] as a join [CRONUS Sverige AB$Employee Absence] as b on a.No_=b.[Employee No_] where (select year (b.[From Date]) as year) like '2004' and b.[Cause of Absence Code] = 'SJUK'";
                SqlCommand cmd = new SqlCommand(Query, connection);
                dataReader = cmd.ExecuteReader();
                employees = new List<Employee>();

                while (dataReader.Read())
                {
                    Employee e = new Employee();
                    e.FirstName = dataReader["First Name"].ToString();
                    e.LastName = dataReader["Last Name"].ToString();
                    e.EmployeeNumber = dataReader["Employee No_"].ToString();

                    DateTime date;
                    if (DateTime.TryParse(dataReader["From Date"].ToString(), out date))
                        e.FromDate = date;
                    e.AbsenceCause = dataReader["Cause of Absence Code"].ToString();
                    employees.Add(e);
                }
                return employees;
            }
            finally
            {
                CloseConnection();
            }
        }

        public static List<Employee> GetMostSick()
        {
            try
            {
                OpenConnection();
                Query = "select top 3 b.[First Name], Count(a.Description) as 'Number of days' from [CRONUS Sverige AB$Employee Absence] as a join [CRONUS Sverige AB$Employee] as b on b.No_=a.[Employee No_] where a.Description='Sjuk' group by b.[First Name],a.Description";
                SqlCommand cmd = new SqlCommand(Query, connection);
                dataReader = cmd.ExecuteReader();
                employees = new List<Employee>();

                while (dataReader.Read())
                {
                    Employee e = new Employee();
                    e.FirstName = dataReader["First Name"].ToString();
                    e.NumberOfSickDays = Convert.ToInt32(dataReader["Number of days"].ToString());
                    employees.Add(e);
                }
                return employees;
            }
            finally
            {
                CloseConnection();
            }
        }

        public static List<string> GetKeys()
        {
            try
            {
                OpenConnection();
                Query = "select top 20 column_name as [Key] from [Demo Database NAV (5-0)].INFORMATION_SCHEMA.KEY_COLUMN_USAGE";
                SqlCommand cmd = new SqlCommand(Query, connection);
                dataReader = cmd.ExecuteReader();
                dataList = new List<string>();

                while (dataReader.Read())
                {
                    string test = dataReader["Key"].ToString();
                    dataList.Add(test);
                }
                return dataList;
            }
            finally
            {
                CloseConnection();
            }
        }

        public static List<Index> GetIndices()
        {
            try
            {
                OpenConnection();
                Query = "select top 20 object_id as 'Object ID', name as 'Name', index_id as 'Index ID', type as 'Type', type_desc as 'Type Desc' from [Demo Database NAV (5-0)].sys.indexes order by object_id";
                SqlCommand cmd = new SqlCommand(Query, connection);
                dataReader = cmd.ExecuteReader();
                indices = new List<Index>();

                while (dataReader.Read())
                {
                    Index i = new Index();
                    i.ObjectId = dataReader["Object ID"].ToString();
                    i.IndexId = dataReader["Index ID"].ToString();
                    i.Name = dataReader["Name"].ToString();
                    i.Type = dataReader["Type"].ToString();
                    i.TypeDescription = dataReader["Type Desc"].ToString();
                    indices.Add(i);
                }
                return indices;
            }
            finally
            {
                CloseConnection();
            }
        }

        public static List<TableConstraint> GetConstraints()
        {
            try
            {
                OpenConnection();
                Query = "select top 20 CONSTRAINT_CATALOG as 'Constraint Catalog', CONSTRAINT_NAME as 'Constraint Name', TABLE_CATALOG as 'Table Catalog' from [Demo Database NAV (5-0)].INFORMATION_SCHEMA.TABLE_CONSTRAINTS order by TABLE_NAME";
                SqlCommand cmd = new SqlCommand(Query, connection);
                dataReader = cmd.ExecuteReader();
                constraints = new List<TableConstraint>();

                while (dataReader.Read())
                {
                    TableConstraint t = new TableConstraint();
                    t.TableConstraintCatalog = dataReader["Constraint Catalog"].ToString();
                    t.Name = dataReader["Constraint Name"].ToString();
                    t.TableCatalog = dataReader["Table Catalog"].ToString();
                    constraints.Add(t);
                }
                return constraints;
            }
            finally
            {
                CloseConnection();
            }
        }

        public static List<string> GetTablesOne()
        {
            try
            {
                OpenConnection();
                Query = "select TABLE_NAME as [All tables in CRONUS Sverige AB] from [Demo Database NAV (5-0)].INFORMATION_SCHEMA.TABLES";
                SqlCommand cmd = new SqlCommand(Query, connection);
                dataReader = cmd.ExecuteReader();
                dataList = new List<string>();

                while (dataReader.Read())
                {
                    string data = dataReader["All tables in CRONUS Sverige AB"].ToString();
                    dataList.Add(data);
                }
                return dataList;
            }
            finally
            {
                CloseConnection();
            }
        }

        public static List<string> GetTablesTwo()
        {
            try
            {
                OpenConnection();
                Query = "use [Demo Database NAV (5-0)] select name as [All tables in CRONUS Sverige AB] from sys.sysobjects where xtype ='U'";
                SqlCommand cmd = new SqlCommand(Query, connection);
                dataReader = cmd.ExecuteReader();
                dataList = new List<string>();

                while (dataReader.Read())
                {
                    string data = dataReader["All tables in CRONUS Sverige AB"].ToString();
                    dataList.Add(data);
                }
                return dataList;
            }
            finally
            {
                CloseConnection();
            }
        }

        public static List<string> GetColumnsOne()
        {
            try
            {
                OpenConnection();
                Query = "select COLUMN_NAME as [Employee Columns] from [Demo Database NAV (5-0)].INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = 'CRONUS Sverige AB$Employee'";
                SqlCommand cmd = new SqlCommand(Query, connection);
                dataReader = cmd.ExecuteReader();
                dataList = new List<string>();

                while (dataReader.Read())
                {
                    string data = dataReader["Employee Columns"].ToString();
                    dataList.Add(data);
                }
                return dataList;
            }
            finally
            {
                CloseConnection();
            }
        }

        public static List<string> GetColumnsTwo()
        {
            try
            {
                OpenConnection();
                Query = "select name as [Employee Columns] from sys.columns where object_id=object_ID('CRONUS Sverige AB$Employee')";
                SqlCommand cmd = new SqlCommand(Query, connection);
                dataReader = cmd.ExecuteReader();
                dataList = new List<string>();

                while (dataReader.Read())
                {
                    string data = dataReader["Employee Columns"].ToString();
                    dataList.Add(data);
                }
                return dataList;
            }
            finally
            {
                CloseConnection();
            }
        }

        public static int UpdateEmployee(string employeeNumber, string firstname, string lastname)
        {
            try
            {
                OpenConnection();
                Query = "update[CRONUS Sverige AB$Employee] set [First Name] = @FirstName, [Last Name] = @LastName where No_ = @EmployeeNumber";
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.Add(new SqlParameter("@EmployeeNumber", employeeNumber));
                cmd.Parameters.Add(new SqlParameter("@FirstName", firstname));
                cmd.Parameters.Add(new SqlParameter("@LastName", lastname));
                int result = cmd.ExecuteNonQuery();
                return result;
            }
            finally
            {
                CloseConnection();
            }
        }

        public static int AddEmployee(string employeeNumber, string firstname, string lastname)
        {
            try
            {
                OpenConnection();
                Query = "insert into [dbo].[CRONUS Sverige AB$Employee] ([No_],[First Name],[Middle Name] ,[Last Name],[Initials],[Job Title],[Search Name],[Address],[Address 2],[City],[Post Code],[County],[Phone No_],[Mobile Phone No_],[E-Mail],[Alt_ Address Code],[Alt_ Address Start Date],[Alt_ Address End Date],[Picture],[Birth Date],[Social Security No_],[Union Code],[Union Membership No_],[Sex],[Country_Region Code],[Manager No_],[Emplymt_ Contract Code],[Statistics Group Code],[Employment Date],[Status],[Inactive Date],[Cause of Inactivity Code],[Termination Date],[Grounds for Term_ Code],[Global Dimension 1 Code],[Global Dimension 2 Code],[Resource No_],[Last Date Modified],[Extension],[Pager],[Fax No_],[Company E-Mail],[Title],[Salespers__Purch_ Code],[No_ Series]) values(@EmployeeNumber, @FirstName, '', @LastName,'','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','')";
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.Add(new SqlParameter("@EmployeeNumber", employeeNumber));
                cmd.Parameters.Add(new SqlParameter("@FirstName", firstname));
                cmd.Parameters.Add(new SqlParameter("@LastName", lastname));
                return cmd.ExecuteNonQuery();
            }
            finally
            {
                CloseConnection();
            }
        }

        public static int DeleteEmployee(string employeeNumber)
        {
            try
            {
                OpenConnection();
                Query = "delete from [CRONUS Sverige AB$Employee] where No_ = @EmployeeNumber;";
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.Add(new SqlParameter("@EmployeeNumber", employeeNumber));
                return cmd.ExecuteNonQuery();
            }
            finally
            {
                CloseConnection();
            }
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

}
