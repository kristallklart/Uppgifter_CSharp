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
                            Console.WriteLine("\n USER\n");
                            List<User> u = Controller.GetAllUsers();
                            foreach (User i in u)
                            {
                                Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}\n", i.UserName, i.FirstName, i.LastName, i.BirthDate, i.Profession, i.Industry);
                            }
                            break;
                        case ("2"):
                            Console.WriteLine("\n LOCATION\n");
                            List<Location> l = Controller.GetAllLocations();
                            foreach (Location i in l)
                            {
                                Console.WriteLine("{0}\n", i.City);
                            }
                            break;
                        case ("3"):
                            Console.WriteLine("\n USER/LOCATION/PURPOSE\n");
                            List<UserLocationPurpose> ulp = Controller.GetAllUserLocationPurposes();
                            foreach (UserLocationPurpose i in ulp)
                            {
                                Console.WriteLine("{0}, {1}, {2}, {3}, {4}\n", i.Username, i.City, i.Purposetype, i.FromDate, i.ToDate);
                            }
                            break;
                        case ("4"):
                            Console.WriteLine("\n FIELD OF PROFESSION\n");
                            List<FieldOfProfession> f = Controller.GetAllFieldOfProfessions();
                            foreach (FieldOfProfession i in f)
                            {
                                Console.WriteLine("{0}\n", i.Industry);
                            }
                            break;
                        case ("5"):
                            Console.WriteLine("\n MATCH\n");
                            List<Match> m = Controller.GetAllMatches();
                            foreach (Match i in m)
                            {
                                Console.WriteLine("{0}, {1}\n", i.Username, i.MatchUsername);
                            }
                            break;
                        case ("6"):
                            Console.WriteLine("\n MESSAGE\n");
                            List<Message> me = Controller.GetAllMessages();
                            foreach (Message i in me)
                            {
                                Console.WriteLine("{0}, {1}, {2}, {3}\n", i.Id, i.Sender, i.Content, i.Reciever);
                            }
                            break;
                        case ("7"):
                            Console.WriteLine("\n PURPOSE\n");
                            List<Purpose> p = Controller.GetAllPurposes();
                            foreach (Purpose i in p)
                            {
                                Console.WriteLine("{0}\n", i.PurposeType);
                            }
                            break;

                        default:
                            Console.WriteLine("That table doesn't exist, please enter a valid number (1-8).");
                            break;
                    }
                    Console.WriteLine("Do you want to see another table? Type y for yes, n to exit");
                    x = Console.ReadLine();
                    if(x == "n")
                    {
                        on = false;
                    }
                  
                }
                

                catch (FaultException)
                {
                    Console.WriteLine("The table couldn't be loaded");
                }
            } 
        }
    }
}
