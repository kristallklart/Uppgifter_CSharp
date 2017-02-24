using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

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
    public class Person
    {
        public string name;
        public int age;

        //public Person(string name, int age)
        //{
        //    this.name = name;
        //    this.age = age;
        //}
    }

    public Uppgift2_Service () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public List<Person> GetAllPersons() {
        List<Person> testLista = new List<Person>();
        //Person p1 = new Person("Mannen", 34);
        //Person p2 = new Person("Kvinnan", 43);
        Person p1 = new Person();
        Person p2 = new Person();
        p1.name = "Mannen";
        p1.age = 34;
        p2.name = "Kvinnan";
        p2.age = 43;

        testLista.Add(p1);
        testLista.Add(p2);
        return testLista;
    }

    [WebMethod]
    public List<object> GetAllUsers()
    {
        return Dal.GetAllUsers();
    }

    [WebMethod]
    public List<object> GetAllPurposes()
    {
        return Dal.GetAllPurposes();
    }

    [WebMethod]
    public List<object> GetAllLocations()
    {
        return Dal.GetAllLocations();
    }

    [WebMethod]
    public List<object> GetAllUserLocationPurposes()
    {
        return Dal.GetAllUserLocationPurposes();
    }

    [WebMethod]
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