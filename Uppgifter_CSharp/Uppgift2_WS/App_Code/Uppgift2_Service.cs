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
    public void/*List<User>*/ GetUsers()
    {
        List<User> users = new List<User>();
        User user = new User();
        User user2 = new User();
        user.FirstName = "Kalle";
        user2.FirstName = "Jake";
        users.Add(user);
        users.Add(user2);
        //return users;
        
        string conStr = ConfigurationManager.ConnectionStrings["Databasen"].ConnectionString;
        SqlConnection connection = new SqlConnection(conStr);
        //SqlDataReader dataReader;

        List<User> allUsers = new List<User>();

        connection.Open();
        string sqlString = "INSERT INTO Users([Username],[FirstName],[LastName],[Birthdate],[Profession],[Password],[About],[Industry]) VALUES('Nero','Alea','Stewart','1988-09-07 05:09:45','Polis','QMD08NXS3RA','Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur sed tortor. Integer aliquam adipiscing lacus. Ut nec urna et arcu imperdiet ullamcorper. Duis at lacus.','Detaljhandel'),('Macy','Rhonda','Webster','1976-07-04 11:49:37','Försäljare','AQG12GEY2HQ','Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur sed tortor. Integer aliquam adipiscing lacus. Ut nec urna et arcu imperdiet','Detaljhandel'),('Haviva','Dorian','Cox','1960-08-17 00:08:22','Polis','MLN44BJN8TI','Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur sed tortor. Integer aliquam adipiscing lacus. Ut nec urna et arcu imperdiet ullamcorper. Duis at','Juridik'),('Mallory','Teagan','Valencia','1989-03-09 15:44:43','Lokförare','LPE80YEP7SC','Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur sed tortor. Integer aliquam adipiscing lacus. Ut nec urna et arcu imperdiet ullamcorper. Duis at lacus. Quisque purus sapien, gravida non, sollicitudin a, malesuada id, erat. Etiam vestibulum','Bygg'),('Yasir','Kiayada','Vargas','1982-04-26 04:27:11','Kock','COB58EHG4AN','Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur sed tortor. Integer aliquam adipiscing lacus. Ut nec urna et arcu imperdiet ullamcorper. Duis at lacus. Quisque purus sapien, gravida non, sollicitudin a, malesuada id, erat. Etiam vestibulum','Reklam'),('Octavia','Adara','Burns','1974-05-21 05:33:38','Polis','GFH27FIC3OR','Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur sed tortor. Integer aliquam adipiscing lacus. Ut nec urna et arcu imperdiet ullamcorper. Duis','Media'),('Stalon','Hiram','Hendrix','1972-09-23 10:22:15','Veterinär','POY51MEP2YV','Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur sed tortor. Integer aliquam adipiscing lacus. Ut nec urna et arcu imperdiet ullamcorper. Duis at lacus. Quisque purus sapien, gravida','Finans'),('Hedda','Leilani','Madden','1970-03-25 12:49:06','IT-Tekniker','MNV49WRA7OB','Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur sed tortor. Integer aliquam adipiscing lacus. Ut nec urna et arcu imperdiet ullamcorper. Duis at lacus. Quisque purus','Reklam'),('Nathaniel','Suki','Hawkins','1986-08-18 01:59:49','Murare','KDL24EFG9VZ','Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur sed tortor. Integer aliquam adipiscing lacus. Ut nec urna et arcu imperdiet ullamcorper. Duis at lacus.','Bygg'),('Guinevere','Sara','Mathews','1984-11-24 19:05:33','Ekonom','MZW76HGA4OY','Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur sed tortor. Integer aliquam adipiscing lacus. Ut nec urna et arcu imperdiet ullamcorper. Duis at lacus. Quisque purus sapien, gravida non, sollicitudin a, malesuada id, erat. Etiam vestibulum massa rutrum magna.','Ekonomi')";
        SqlCommand cmd = new SqlCommand(sqlString, connection);
        int i = cmd.ExecuteNonQuery();
        //dataReader = cmd.ExecuteReader();

        //while (dataReader.Read())
        //{
        //    User aUser = new User();
        //    aUser.UserName = dataReader["UserName"].ToString();
        //    aUser.FirstName = dataReader["FirstName"].ToString();
        //    aUser.LastName = dataReader["LastName"].ToString();
        //    aUser.About = dataReader["About"].ToString();
        //    aUser.Profession = dataReader["Profession"].ToString();
        //    aUser.Industry = dataReader["Industry"].ToString();
        //    allUsers.Add(aUser);
        //}
        //return allUsers;
    }

    [WebMethod]
    [System.Xml.Serialization.XmlInclude(typeof(User))]
    public List<object> GetObjects()
    {
        object o = new object();
        object o2 = new object();
        List<object> objects = new List<object>();
        User user = new User();

        objects.Add(user);
        objects.Add(o2);
        return objects;
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