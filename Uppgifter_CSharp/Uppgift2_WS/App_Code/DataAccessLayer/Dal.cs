using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Dal
/// </summary>
public static class Dal
{
    private static SqlConnection connection;
    private static SqlDataReader dataReader;
    private static string conStr;
    //private static List<object> allUsers;
    //private static List<object> allPurposes;
    //private static List<object> allLocations;
    //private static List<object> allUserLocationPurposes;
    //private static List<object> allFieldOfProfessions;
    //private static List<object> allMessages;
    //private static List<object> errorMessage;

    private static List<object> result;

    //public SqlConnection Connection
    //{
    //    get { return connection; }
    //    set { connection = value; }
    //}
    //public SqlDataReader DataReader
    //{
    //    get { return dataReader; }
    //    set { dataReader = value; }
    //}
    //public string ConStr
    //{
    //    get { return conStr; }
    //    set { conStr = value; }
    //}

	static Dal()
	{
        conStr = ConfigurationManager.ConnectionStrings["Databasen"].ConnectionString;
        //conStr = "server=localhost; Trusted_Connection=yes; database=FriendlyDB";
        result = new List<object>();
    }

    public static List<object> GetAllUsers()
    {
        try
        {
            //result = new List<object>();
            OpenConnection();

            string sqlString = "select * from Users";
            SqlCommand cmd = new SqlCommand(sqlString, connection);
            dataReader = cmd.ExecuteReader();
            //allUsers = new List<object>();

            while (dataReader.Read())
            {
                User aUser = new User();
                aUser.UserName = dataReader["UserName"].ToString();
                aUser.FirstName = dataReader["FirstName"].ToString();
                aUser.LastName = dataReader["LastName"].ToString();
                aUser.About = dataReader["About"].ToString();
                aUser.Profession = dataReader["Profession"].ToString();
                aUser.Industry = dataReader["Industry"].ToString();
                //allUsers.Add(aUser);
                result.Add(aUser);
            }

            return result;
            //return allUsers;
        }
        catch (SqlException e)
        {
            return ReturnError(e);
            //int fel = e.Number;
            //string errorMessage = ErrorHandler.HandleError(e);
            //result.Clear();
            //result.Add(errorMessage);
            
            //List<object> allUsersAndMessage = new List<object>();
            //allUsersAndMessage.Add(errorMessage);
            //foreach (object o in allUsers)
            //{
            //    allUsersAndMessage.Add(o);
            //}
            //return allUsersAndMessage;

            //return result;
        }
        finally
        {
            CloseConnection();
            result.Clear();
        }
    }

    public static List<object> GetAllPurposes()
    {
        try
        {
            OpenConnection();
            string sqlString = "select * from Purposes";
            SqlCommand cmd = new SqlCommand(sqlString, connection);
            dataReader = cmd.ExecuteReader();

            //allPurposes = new List<object>();

            while (dataReader.Read())
            {
                Purpose purpose = new Purpose();
                purpose.PurposeType = dataReader["Purposetype"].ToString();
                //allPurposes.Add(purpose);
                result.Add(purpose);
            }
            //return allPurposes;
            return result;
        }
        catch (SqlException e)
        {
            //string errorMessage = ErrorHandler.HandleError(e);
            //List<object> allPurposesAndMessage = new List<object>();
            //allPurposesAndMessage.Add(errorMessage);
            //foreach (object o in allUsers)
            //{
            //    allPurposesAndMessage.Add(o);
            //}
            //return allPurposesAndMessage;
            return ReturnError(e);
        }
        finally
        {
            CloseConnection();
            result.Clear();
        }
    }

    public static List<object> GetAllLocations()
    {
        try
        {
            OpenConnection();
            string sqlString = "select * from Locations";
            SqlCommand cmd = new SqlCommand(sqlString, connection);
            dataReader = cmd.ExecuteReader();

            //allLocations = new List<object>();

            while (dataReader.Read())
            {
                Location location = new Location();
                location.City = dataReader["City"].ToString();
                result.Add(location);
                //allLocations.Add(location);
            }
            return result;
            //return allLocations;
        }
        catch (SqlException e)
        {
            //string errorMessage = ErrorHandler.HandleError(e);
            //List<object> allLocationsAndMessage = new List<object>();
            //allLocationsAndMessage.Add(errorMessage);
            //foreach (object o in allUsers)
            //{
            //    allLocationsAndMessage.Add(o);
            //}
            //return allLocationsAndMessage;
            return ReturnError(e);
        }
        finally
        {
            CloseConnection();
            result.Clear();
        }
    }

    public static List<object> GetAllUserLocationPurposes()
    {
        try
        {
            OpenConnection();
            string sqlString = "select * from User_Location_Purposes";
            SqlCommand cmd = new SqlCommand(sqlString, connection);
            dataReader = cmd.ExecuteReader();

            //allUserLocationPurposes = new List<object>();

            while (dataReader.Read())
            {
                UserLocationPurpose userLocationPurpose = new UserLocationPurpose();
                userLocationPurpose.City = dataReader["City"].ToString();
                userLocationPurpose.Username = dataReader["Username"].ToString();
                userLocationPurpose.Purposetype = dataReader["Purposetype"].ToString();
                result.Add(userLocationPurpose);
            }
            return result;
            //return allUserLocationPurposes;
        }
        catch(SqlException e)
        {
            //string errorMessage = ErrorHandler.HandleError(e);
            //List<object> allUserLocationPurposesAndMessage = new List<object>();
            //allUserLocationPurposesAndMessage.Add(errorMessage);
            //foreach (object o in allUsers)
            //{
            //    allUserLocationPurposesAndMessage.Add(o);
            //}
            //return allUserLocationPurposesAndMessage;
            return ReturnError(e);
        }
        finally
        {
            CloseConnection();
            result.Clear();
        }
    }
    
    public static List<object> GetAllFieldOfProfessions()
    {
        try
        {
            OpenConnection();
            string sqlString = "select * from FieldOfProfessions";
            SqlCommand cmd = new SqlCommand(sqlString, connection);
            dataReader = cmd.ExecuteReader();

            //allFieldOfProfessions = new List<object>();

            while (dataReader.Read())
            {
                FieldOfProfession fieldOfProfession = new FieldOfProfession();
                fieldOfProfession.Industry = dataReader["Industry"].ToString();
                //allFieldOfProfessions.Add(fieldOfProfession);
                result.Add(fieldOfProfession);
            }
            return result;
            //return allFieldOfProfessions;
        }
        catch(SqlException e)
        {
            //string errorMessage = ErrorHandler.HandleError(e);
            //List<object> allFieldOfProfessionsAndMessage = new List<object>();
            //allFieldOfProfessionsAndMessage.Add(errorMessage);
            //foreach (object o in allFieldOfProfessionsAndMessage)
            //{
            //    allFieldOfProfessionsAndMessage.Add(o);
            //}
            //return allFieldOfProfessionsAndMessage;
            return ReturnError(e);
        }
        finally
        {
            CloseConnection();
            result.Clear();
        }
    }

    //public static List<Message> GetMessages()
    //{

    //}

    private static void OpenConnection()
    {
        connection = new SqlConnection(conStr);
        try
        {
            connection.Open();
        }
        catch(SqlException e)
        {
            ErrorHandler.HandleError(e);
        }
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
    private static List<object> ReturnError(Exception e)
    {
        string errorMessage = ErrorHandler.HandleError(e);
        result.Clear();
        result.Add(errorMessage);
        return result;
    }
}