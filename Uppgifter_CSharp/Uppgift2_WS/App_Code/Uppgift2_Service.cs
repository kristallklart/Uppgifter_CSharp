using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

[WebService(Namespace = "Grupp7",
            Description = "This web service has multiple web methods which all takes zero arguments and returns an object " +
                          "collection of all the entities in a given table in the Friendly Database if successful. If an error " +
                          "occurs the methods will return a collection of objects where the first element is a string with " +
                          "an error message. The client application must check the first element in the array to handle errors.")]
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
    /// <summary>
    /// sdfef
    /// </summary>
    /// <returns></returns>
    [WebMethod]
    public User GetUser()
    {
        User user = new User();
        user.FirstName = "Kalle";
        return user;
    }

    [WebMethod]
    public List<User> GetUsers()
    {
        List<User> users = new List<User>();
        User user = new User();
        User user2 = new User();
        user.FirstName = "Kalle";
        user2.FirstName = "Jake";
        users.Add(user);
        users.Add(user2);
        return users;
    }

    [WebMethod]
    [System.Xml.Serialization.XmlInclude(typeof(User))] 
    public List<object> GetAllUsers()
    {
        //SoapException e = new SoapException();
        return Dal.GetAllUsers();
    }

    [WebMethod]
    [System.Xml.Serialization.XmlInclude(typeof(Purpose))]
    public List<object> GetAllPurposes()
    {
        return Dal.GetAllPurposes();
    }

    [WebMethod]
    [System.Xml.Serialization.XmlInclude(typeof(Location))]
    public List<object> GetAllLocations()
    {
        return Dal.GetAllLocations();
    }

    [WebMethod]
    [System.Xml.Serialization.XmlInclude(typeof(UserLocationPurpose))]
    public List<object> GetAllUserLocationPurposes()
    {
        return Dal.GetAllUserLocationPurposes();
    }

    [WebMethod]
    [System.Xml.Serialization.XmlInclude(typeof(FieldOfProfession))]
    public List<object> GetAllFieldOfProfessions()
    {
        return Dal.GetAllFieldOfProfessions();
    }

    //[WebMethod]
    //public List<Message> GetMessages()
    //{
    //    return Dal.GetMessages();
    //}
}