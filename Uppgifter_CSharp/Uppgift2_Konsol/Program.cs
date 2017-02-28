using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift2_Konsol.Uppgift2_ServiceReference;
using Uppgift2_Konsol.ControllerLayer;
using System.ServiceModel;

namespace Uppgift2_Konsol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Friendly DB application!\n-----------------------------\n");
            Console.WriteLine("Tables to open:\n"
                + "1. User\n2. Location\n3. User/location/purpose\n4. Field of Profession\n5. Match\n6. Message\n7. Purpose\n");



            bool on = true;

            while (on)
            {
                Console.Write("\nSelect table (1-8): ");
                string x = Console.ReadLine();
                try {
                    switch (x)
                    {
                        case ("1"):
                            Console.WriteLine("\nUSER\n");
                            List<User> u = Controller.GetAllUsers();
                            foreach (User i in u)
                            {
                                Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}\n", i.UserName, i.FirstName, i.LastName, i.BirthDate, i.Profession, i.Industry);
                            }
                            on = false;
                            break;
                        case ("2"):
                            Console.WriteLine("\nLOCATION\n");
                            List<Location> l = Controller.GetAllLocations();
                            foreach (Location lo in l)
                            {
                                Console.WriteLine("{0}\n", lo.City);
                            }
                            on = false;
                            break;
                        case ("3"):
                            Console.WriteLine("\nUSER/LOCATION/PURPOSE\n");
                            List<UserLocationPurpose> ulp = Controller.GetAllUserLocationPurposes();
                            foreach (UserLocationPurpose i in ulp)
                            {
                                Console.WriteLine("{0}, {1}, {2}, {3}, {4}\n", i.Username, i.City, i.Purposetype, i.FromDate, i.ToDate);
                            }
                            on = false;
                            break;
                        case ("4"):
                            Console.WriteLine("Knapp 4");
                            on = false;
                            break;
                        case ("5"):
                            Console.WriteLine("Knapp 5");
                            on = false;
                            break;
                        case ("6"):
                            Console.WriteLine("Knapp 6");
                            on = false;
                            break;
                        case ("7"):
                            Console.WriteLine("Knapp 7");
                            on = false;
                            break;
                        case ("8"):
                            Console.WriteLine("Knapp 8");
                            on = false;
                            break;

                        default:
                            Console.WriteLine("That table doesn't exist, please enter a valid number (1-8).");
                            break;
                    }
                }
                catch (FaultException)
                {
                    Console.WriteLine("The table couldn't be loaded");
                }
            }
            Console.ReadLine();

            /*        //Uppgift2_ServiceReference.Person[] persons = proxy.GetAllPersons();
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
            //        Console.ReadKey();*/
        }
    }
}
