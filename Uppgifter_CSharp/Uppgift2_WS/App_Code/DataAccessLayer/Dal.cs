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
    }

    public static List<User> GetUsers()
    {
        try
        {
            OpenConnection();
            //connection = null;
            //dataReader = null;
            //connection = new SqlConnection(conStr);
            //connection.Open();
            //string test = dataReader.GetName(5); //Används för att hämta ett namn på en given kolumn i tabellen.
            
            string sqlString = "select * from Users";
            SqlCommand cmd = new SqlCommand(sqlString, connection);
            dataReader = cmd.ExecuteReader();
            
            List<User> users = new List<User>();

            while (dataReader.Read())
            {
                User aUser = new User();
                aUser.UserName = dataReader["UserName"].ToString();
                aUser.FirstName = dataReader["FirstName"].ToString();
                aUser.LastName = dataReader["LastName"].ToString();
                aUser.About = dataReader["About"].ToString();
                aUser.Profession = dataReader["Profession"].ToString();
                aUser.Industry = dataReader["Industry"].ToString();
                //aUser.BirthDate
                //aUser.Password
                users.Add(aUser);
            }
            return users;
        }
        catch (Exception)
        {

        }
        finally
        {
            CloseConnection();
        }
        return null;
    }

    public static List<Purpose> GetPurposes()
    {
        try
        {
            OpenConnection();
            string sqlString = "select * from Purposes";
            SqlCommand cmd = new SqlCommand(sqlString, connection);
            dataReader = cmd.ExecuteReader();

            List<Purpose> purposes = new List<Purpose>();

            while (dataReader.Read())
            {
                Purpose purpose = new Purpose();
                purpose.PurposeType = dataReader["Purposetype"].ToString();
                purposes.Add(purpose);
            }
            return purposes;
        }
        catch (Exception)
        {

        }
        finally
        {
            CloseConnection();
        }
        return null;
    }

    public static List<Location> GetLocations()
    {
        try
        {
            OpenConnection();
            string sqlString = "select * from Locations";
            SqlCommand cmd = new SqlCommand(sqlString, connection);
            dataReader = cmd.ExecuteReader();

            List<Location> locations = new List<Location>();

            while (dataReader.Read())
            {
                Location location = new Location();
                location.City = dataReader["City"].ToString();
                locations.Add(location);
            }
            return locations;
        }
        catch (Exception)
        {

        }
        finally
        {
            CloseConnection();
        }
        return null;
    }

    public static List<UserLocationPurpose> GetUserLocationPurposes()
    {
        try
        {
            OpenConnection();
            string sqlString = "select * from User_Location_Purposes";
            SqlCommand cmd = new SqlCommand(sqlString, connection);
            dataReader = cmd.ExecuteReader();

            List<UserLocationPurpose> userLocationPurposes = new List<UserLocationPurpose>();

            while (dataReader.Read())
            {
                UserLocationPurpose userLocationPurpose = new UserLocationPurpose();
                userLocationPurpose.City = dataReader["City"].ToString();
                userLocationPurpose.Username = dataReader["Username"].ToString();
                userLocationPurpose.Purposetype = dataReader["Purposetype"].ToString();
            }
            return userLocationPurposes;
        }
        catch(Exception)
        {
            
        }
        finally
        {
            CloseConnection();
        }
        return null;
    }
    
    public static List<FieldOfProfession> GetFieldOfProfessions()
    {
        try
        {
            OpenConnection();
            string sqlString = "select * from FieldOfProfessions";
            SqlCommand cmd = new SqlCommand(sqlString, connection);
            dataReader = cmd.ExecuteReader();

            List<FieldOfProfession> fieldOfProfessions = new List<FieldOfProfession>();

            while (dataReader.Read())
            {
                FieldOfProfession fieldOfProfession = new FieldOfProfession();
                fieldOfProfession.Industry = dataReader["Industry"].ToString();
                fieldOfProfessions.Add(fieldOfProfession);
            }
            return fieldOfProfessions;
        }
        catch(Exception)
        {

        }
        finally
        {
            CloseConnection();
        }
        return null;
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
        catch(Exception)
        {

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
}