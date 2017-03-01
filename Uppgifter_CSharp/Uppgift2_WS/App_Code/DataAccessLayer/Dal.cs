using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
//using FriendlyDBModel;

/// <summary>
/// Summary description for Dal
/// </summary>
public static class Dal
{
    private static SqlConnection connection;
    private static SqlDataReader dataReader;
    private static string conStr;
    private static List<User> allUsers;
    private static List<Purpose> allPurposes;
    private static List<Location> allLocations;
    private static List<UserLocationPurpose> allUserLocationPurposes;
    private static List<FieldOfProfession> allFieldOfProfessions;
    private static List<Message> allMessages;
    private static List<Match> allMatches;
    
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
        conStr = ConfigurationManager.ConnectionStrings["FriendlyDB"].ConnectionString;
        //conStr = "server=localhost; Trusted_Connection=yes; database=FriendlyDB";
    }

    public static List<User> GetAllUsers()
    {
        try
        {
            OpenConnection();

            string sqlString = "select * from Users";
            SqlCommand cmd = new SqlCommand(sqlString, connection);
            dataReader = cmd.ExecuteReader();
            allUsers = new List<User>();

            while (dataReader.Read())
            {
                User aUser = new User();
                aUser.UserName = dataReader["UserName"].ToString();
                aUser.FirstName = dataReader["FirstName"].ToString();
                aUser.LastName = dataReader["LastName"].ToString();
            
                DateTime dateTime;
                if(DateTime.TryParse(dataReader["BirthDate"].ToString(), out dateTime))
                    aUser.BirthDate = dateTime;
            
                aUser.Profession = dataReader["Profession"].ToString();
                aUser.Password = "Encrypted"; //We do not present the password, picture or UserLocationPurpose
                aUser.About = dataReader["About"].ToString();
                aUser.Industry = dataReader["Industry"].ToString();

                allUsers.Add(aUser);
            }
            return allUsers;
        }
        finally
        {
            CloseConnection();
        }
    }

    public static List<Purpose> GetAllPurposes()
    {
        try 
        { 
            OpenConnection();
            string sqlString = "select * from Purposes";
            SqlCommand cmd = new SqlCommand(sqlString, connection);
            dataReader = cmd.ExecuteReader();

            allPurposes = new List<Purpose>();

            while (dataReader.Read())
            {
                Purpose purpose = new Purpose();
                purpose.PurposeType = dataReader["Purposetype"].ToString();
                allPurposes.Add(purpose);
            }
            return allPurposes;
        }
        finally
        {
            CloseConnection();
        }
    }

    public static List<Location> GetAllLocations()
    {
        try
        {
            OpenConnection();
            string sqlString = "select * from Locations";
            SqlCommand cmd = new SqlCommand(sqlString, connection);
            dataReader = cmd.ExecuteReader();

            allLocations = new List<Location>();

            while (dataReader.Read())
            {
                Location location = new Location();
                location.City = dataReader["City"].ToString();
                allLocations.Add(location);
            }
            return allLocations;
        }
        finally
        {
            CloseConnection();
        }

    }

    public static List<UserLocationPurpose> GetAllUserLocationPurposes()
    {
        try
        {
            OpenConnection();
            string sqlString = "select * from User_Location_Purpose";
            SqlCommand cmd = new SqlCommand(sqlString, connection);
            dataReader = cmd.ExecuteReader();

            allUserLocationPurposes = new List<UserLocationPurpose>();

            while (dataReader.Read())
            {
                UserLocationPurpose userLocationPurpose = new UserLocationPurpose();
                userLocationPurpose.City = dataReader["City"].ToString();
                userLocationPurpose.Username = dataReader["Username"].ToString();
                userLocationPurpose.Purposetype = dataReader["Purposetype"].ToString();
            
                DateTime fromDate;
                DateTime toDate;
                if (DateTime.TryParse(dataReader["FromDate"].ToString(), out fromDate))
                    userLocationPurpose.FromDate = fromDate;
                if (DateTime.TryParse(dataReader["ToDate"].ToString(), out toDate))
                    userLocationPurpose.ToDate = toDate;
            
                allUserLocationPurposes.Add(userLocationPurpose);
            }
            return allUserLocationPurposes;
        }
        finally
        {
            CloseConnection();  
        }
    }
    
    public static List<FieldOfProfession> GetAllFieldOfProfessions()
    {
        try
        {
            OpenConnection();
            string sqlString = "select * from FieldOfProfessions";
            SqlCommand cmd = new SqlCommand(sqlString, connection);
            dataReader = cmd.ExecuteReader();

            allFieldOfProfessions = new List<FieldOfProfession>();

            while (dataReader.Read())
            {
                FieldOfProfession fieldOfProfession = new FieldOfProfession();
                fieldOfProfession.Industry = dataReader["Industry"].ToString();
                allFieldOfProfessions.Add(fieldOfProfession);
            }
            return allFieldOfProfessions;
        }
        finally
        {
            CloseConnection();
        }
    }

    public static List<Message> GetAllMessages()
    {
        try
        {
            OpenConnection();
            string sqlString = "select * from Messages";
            SqlCommand cmd = new SqlCommand(sqlString, connection);
            dataReader = cmd.ExecuteReader();

            allMessages = new List<Message>();

            while (dataReader.Read())
            {
                Message message = new Message();
                message.Id = Int32.Parse(dataReader["Id"].ToString());
                message.Sender = dataReader["Sender"].ToString();
                message.Reciever = dataReader["Reciever"].ToString();
                message.Content = dataReader["Content"].ToString();
                allMessages.Add(message);
            }
            return allMessages;
        }
        finally
        {
            CloseConnection();
        }
    }

    public static List<Match> GetAllMatches()
    {
        try
        {
            OpenConnection();
            string sqlString = "select * from Match";
            SqlCommand cmd = new SqlCommand(sqlString, connection);
            dataReader = cmd.ExecuteReader();

            allMatches = new List<Match>();

            while (dataReader.Read())
            {
                Match match = new Match();
                match.MatchUsername = dataReader["Matchusername"].ToString();
                match.Username = dataReader["Username"].ToString();
                allMatches.Add(match);
            }
            return allMatches;
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