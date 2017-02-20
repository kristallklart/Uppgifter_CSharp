using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1_Konsol
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileToOpen;
            bool cont_NewQuery = true;
            bool cont_WrongInput = true;
            Console.WriteLine("Welcome to the Open File Application!\n-------------------------------------\n");

            while (cont_NewQuery == true)
            {
                Console.Write("Please enter a filename: ");
                fileToOpen = Console.ReadLine();

                Console.WriteLine("\nThank you! Processing request...\n");

                //OBS ServiceSoapClient proxy = new ServiceSoapClient(); //Skapandet av en ny SOAP-klient
                string fileContent;
                //OBS fileContent = proxy.OpenFile(fileToOpen); //Skicka ett filnamn eller dess absoluta sökväg till web servicen som returnerar dess innehåll.

                //Anrop till Web Services verkar kunna kasta SOAP-exceptions. Kolla upp det!

                Console.WriteLine("File content");
                Console.WriteLine("------------");
                //OBS Console.WriteLine(fileContent + "\n");
                //Console.ReadKey();
                cont_WrongInput = true;

                while (cont_WrongInput == true)
                {
                    Console.Write("Do you wish to open a new file? Enter y for yes or n for no:");
                    string choice = Console.ReadLine();
                    //Console.WriteLine("\n");
                    if (choice == "y" || choice == "Y")
                    {
                        cont_NewQuery = true;
                        cont_WrongInput = false;
                        Console.WriteLine();
                    }
                    else if (choice == "n" || choice == "N")
                    {
                        cont_NewQuery = false;
                        cont_WrongInput = false;
                    }
                    else
                    {
                        cont_WrongInput = true;
                        //while(cont_WrongInput == true)
                        Console.WriteLine("\nUnknown input, please try again.\n");
                    }
                }
            }
        }
    }
}
