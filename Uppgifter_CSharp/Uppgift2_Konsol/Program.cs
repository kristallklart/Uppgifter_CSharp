using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift2_Konsol.Uppgift2_ServiceReference;

namespace Uppgift2_Konsol
{
    class Program
    {
        static void Main(string[] args)
        {
          
            //        //Uppgift2_ServiceReference.Person[] persons = proxy.GetAllPersons();
            Uppgift2_ServiceSoapClient proxy = new Uppgift2_ServiceSoapClient();

            List<User> users = new List<User>(); 
            //        Uppgift2_ServiceReference.User[] users = proxy.GetUsers();
            //        Uppgift2_ServiceReference.Purpose[] purposes = proxy.GetPurposes();
            //        Uppgift2_ServiceReference.FieldOfProfession[] fieldOfProfessions = proxy.GetFieldOfProfessions();
            //        Uppgift2_ServiceReference.Location[] locations = proxy.GetLocations();
            //        Uppgift2_ServiceReference.UserLocationPurpose[] userLocationPurposes = proxy.GetUserLocationPurposes();

            //        Console.WriteLine(users.Length);
            //        Console.ReadKey();
            users = proxy.GetAllUsers();

                    foreach(User i in users)
                    {
                        Console.WriteLine(i.UserName);
                        Console.WriteLine(i.FirstName);
                        Console.WriteLine(i.LastName);
                        Console.WriteLine(i.About);
                        Console.WriteLine(i.Profession);
                        Console.WriteLine(i.Industry);
                    }
                    Console.ReadKey();

            //        for (int i = 0; i < purposes.Length; i++)
            //        {
            //            Console.WriteLine(purposes[i].PurposeType);
            //        }
            //        Console.ReadKey();

            //        for (int i = 0; i < fieldOfProfessions.Length; i++)
            //        {
            //            Console.WriteLine(fieldOfProfessions[i].Industry);
            //        }
            //        Console.ReadKey();

            //        for (int i = 0; i < locations.Length; i++)
            //        {
            //            Console.WriteLine(locations[i].City);
            //        }

            //        for (int i = 0; i < userLocationPurposes.Length; i++)
            //        {
            //            Console.WriteLine(userLocationPurposes[i].City);
            //            Console.WriteLine(userLocationPurposes[i].Location);
            //            Console.WriteLine(userLocationPurposes[i].Purposetype);
            //        }
            //        Console.ReadKey();
        }
    }
}
