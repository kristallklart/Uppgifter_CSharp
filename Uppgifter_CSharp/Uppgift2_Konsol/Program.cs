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
            string x = null;
            Console.WriteLine("Welcome to Friendly Database application!");
            Console.WriteLine("-----------------------------------------\n");
            bool on = true;

            while (on)
            {
                Console.WriteLine("Table to open");
                Console.WriteLine("-------------");
                Console.WriteLine("1. User.");
                Console.WriteLine("2. Location.");
                Console.WriteLine("3. User/location/purpose.");
                Console.WriteLine("4. Field of Profession.");
                Console.WriteLine("5. Match.");
                Console.WriteLine("6. Message.");
                Console.WriteLine("7. Purpose.");

                Console.Write("\nSelect table (1-7): ");
                x = Console.ReadLine();
                try {
                    switch (x)
                    {
                        case ("1"):
                            Console.WriteLine("\nThank you! Processing request...");
                            List<User> u = Controller.GetAllUsers();
                            Console.WriteLine("\nUSER");
                            Console.WriteLine("----\n");
                            foreach (User i in u)
                            {
                                Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}\n", i.UserName, i.FirstName, i.LastName, i.BirthDate, i.Profession, i.Industry, i.Password);
                            }
                            break;
                        case ("2"):
                            Console.WriteLine("\nThank you! Processing request...");
                            List<Location> l = Controller.GetAllLocations();
                            Console.WriteLine("\nLOCATION");
                            Console.WriteLine("--------\n");
                            foreach (Location i in l)
                            {
                                Console.WriteLine("{0}\n", i.City);
                            }
                            break;
                        case ("3"):
                            Console.WriteLine("\nThank you! Processing request...");
                            List<UserLocationPurpose> ulp = Controller.GetAllUserLocationPurposes();
                            Console.WriteLine("\nUSER/LOCATION/PURPOSE");
                            Console.WriteLine("---------------------\n");
                            foreach (UserLocationPurpose i in ulp)
                            {
                                Console.WriteLine("{0}, {1}, {2}, {3}, {4}\n", i.Username, i.City, i.Purposetype, i.FromDate, i.ToDate);
                            }
                            break;
                        case ("4"):
                            Console.WriteLine("\nThank you! Processing request...");
                            List<FieldOfProfession> f = Controller.GetAllFieldOfProfessions();
                            Console.WriteLine("\nFIELD OF PROFESSION");
                            Console.WriteLine("------------------\n");
                            foreach (FieldOfProfession i in f)
                            {
                                Console.WriteLine("{0}\n", i.Industry);
                            }
                            break;
                        case ("5"):
                            Console.WriteLine("\nThank you! Processing request...");
                            List<Match> m = Controller.GetAllMatches();
                            Console.WriteLine("\nMATCH");
                            Console.WriteLine("-----\n");
                            foreach (Match i in m)
                            {
                                Console.WriteLine("{0}, {1}\n", i.Username, i.MatchUsername);
                            }
                            break;
                        case ("6"):
                            Console.WriteLine("\nThank you! Processing request...");
                            List<Message> me = Controller.GetAllMessages();
                            Console.WriteLine("\nMESSAGE");
                            Console.WriteLine("-------\n");
                            foreach (Message i in me)
                            {
                                Console.WriteLine("{0}, {1}, {2}, {3}\n", i.Id, i.Sender, i.Content, i.Reciever);
                            }
                            break;
                        case ("7"):
                            Console.WriteLine("\nThank you! Processing request...");
                            List<Purpose> p = Controller.GetAllPurposes();
                            Console.WriteLine("\nPURPOSE");
                            Console.WriteLine("-------\n");
                            foreach (Purpose i in p)
                            {
                                Console.WriteLine("{0}\n", i.PurposeType);
                            }
                            break;

                        default:
                            Console.WriteLine("\nThat table doesn't exist, please enter a valid number (1-7): ");
                            break;
                    }
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.Write("Do you want to show another table? Type y for yes, n to exit: ");
                    x = Console.ReadLine();
                    Console.WriteLine("\n");
                    while (x != "y" && x != "n")
                    {
                        Console.Write("Unknown input! Type y to show another table, n to exit: ");
                        x = Console.ReadLine();
                        Console.WriteLine("\n");
                    }
                    if (x == "n")
                    {
                        on = false;
                    }
                    else if (x != "y")
                    {
                        on = true;
                    }
                }
                catch (FaultException)
                {
                    Console.WriteLine("Error: The table couldn't be loaded");
                }
            } 
        }
    }
}
