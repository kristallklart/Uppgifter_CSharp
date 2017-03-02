using System.Collections.Generic;
using System.Web.Services;
using DataAccessLayer;
using Model;

[WebService(Namespace = "Grupp7",
            Description = "This web service has multiple web methods which all takes no arguments and returns a " +
                          "collection of all the entities in a given table in the Friendly Database if successful. If an error " +
                          "occurs the methods will throw a FaultException in .NET environemts and a RemoteException in Java. " + 
                          "These exceptions must be handled by the client.")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]

public class Uppgift2_Service : System.Web.Services.WebService
{
    public Uppgift2_Service () 
    {

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