using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

using System.Configuration;
using System.Data.SqlClient;
using System.Data;

[WebService(Namespace = "Grupp7",
            Description = "This web service has multiple web methods which all takes zero arguments and returns an object " +
                          "collection of all the entities in a given table in the Friendly Database if successful. If an error " +
                          "occurs the methods will throw a FaultException which must be handled by the client.")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]

public class Uppgift2_Service : System.Web.Services.WebService
{
    public Uppgift2_Service () 
    {
        //Uncomment the following line if using designed components 
        //InitializeComponent();
    }

    [WebMethod]
    public List<User> GetAllUsers()
    {
        return Dal.GetAllUsers();
    }

    [WebMethod]
    public List<Purpose> GetAllPurposes()
    {
        return Dal.GetAllPurposes();
    }

    [WebMethod]
    public List<Location> GetAllLocations()
    {
        return Dal.GetAllLocations();
    }

    [WebMethod]
    public List<UserLocationPurpose> GetAllUserLocationPurposes()
    {
        return Dal.GetAllUserLocationPurposes();
    }

    [WebMethod]
    public List<FieldOfProfession> GetAllFieldOfProfessions()
    {
        return Dal.GetAllFieldOfProfessions();
    }

    [WebMethod]
    public List<Message> GetAllMessages()
    {
        return Dal.GetAllMessages();
    }

    [WebMethod]
    public List<Match> GetAllMatches()
    {
        return Dal.GetAllMatches();
    }
}