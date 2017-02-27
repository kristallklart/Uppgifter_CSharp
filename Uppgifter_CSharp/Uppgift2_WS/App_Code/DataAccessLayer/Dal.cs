﻿using System;
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
    
    private static List<object> errorMessage;
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
    }

    public static List<User> GetAllUsers()
    {
        result.Clear();
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
            aUser.About = dataReader["About"].ToString();
            aUser.Profession = dataReader["Profession"].ToString();
            aUser.Industry = dataReader["Industry"].ToString();
            allUsers.Add(aUser);
            result.Add(aUser);
        }
        CloseConnection();
        return allUsers;
    }

    public static List<Purpose> GetAllPurposes()
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
        CloseConnection();
        return allPurposes;
    }

    public static List<Location> GetAllLocations()
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
            result.Add(location);
            allLocations.Add(location);
        }
        CloseConnection();
        return allLocations;
    }

    public static List<UserLocationPurpose> GetAllUserLocationPurposes()
    {
        OpenConnection();
        string sqlString = "select * from User_Location_Purposes";
        SqlCommand cmd = new SqlCommand(sqlString, connection);
        dataReader = cmd.ExecuteReader();

        allUserLocationPurposes = new List<UserLocationPurpose>();

        while (dataReader.Read())
        {
            UserLocationPurpose userLocationPurpose = new UserLocationPurpose();
            userLocationPurpose.City = dataReader["City"].ToString();
            userLocationPurpose.Username = dataReader["Username"].ToString();
            userLocationPurpose.Purposetype = dataReader["Purposetype"].ToString();
            allUserLocationPurposes.Add(userLocationPurpose);
        }
        CloseConnection();
        return allUserLocationPurposes;
    }
    
    public static List<FieldOfProfession> GetAllFieldOfProfessions()
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
        CloseConnection();
        return allFieldOfProfessions;
    }

    //public static List<Message> GetMessages()
    //{

    //}

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