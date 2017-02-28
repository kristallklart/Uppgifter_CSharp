using System;
using System.ServiceModel;

namespace Uppgift1_Konsol
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileToOpen;
            bool contNewQuery = true;
            bool contWrongInput;
            Console.WriteLine("Welcome to the Open File Application!\n-------------------------------------\n");

            while (contNewQuery)
            {
                Console.Write("Please enter a filename: ");
                fileToOpen = Console.ReadLine();

                Console.WriteLine("\nThank you! Processing request...\n");
                
                Uppgift1_ServiceReference.Uppgift1_ServiceSoapClient proxy = new Uppgift1_ServiceReference.Uppgift1_ServiceSoapClient(); //Skapandet av en ny SOAP-klient

                try
                {
                    string fileContent = proxy.OpenFile(fileToOpen);
                    Console.WriteLine("File content");
                    Console.WriteLine("------------");
                    Console.WriteLine(fileContent);
                    Console.WriteLine();
                }
                catch (FaultException)
                {
                    Console.WriteLine("ERROR");
                    Console.WriteLine("------------");
                    Console.WriteLine("File could not be opened.\n");             
                }
 
                contWrongInput = true;
                while (contWrongInput)
                {
                    Console.Write("Do you wish to open a new file? Enter y for yes or n for no: ");
                    string choice = Console.ReadLine();
                    if (choice == "y" || choice == "Y")
                    {
                        contWrongInput = false;
                        Console.WriteLine();
                    }
                    else if (choice == "n" || choice == "N")
                    {
                        contNewQuery = false;
                        contWrongInput = false;
                    }
                    else
                    {

                        Console.WriteLine("\nUnknown input, please try again.\n");
                    }
                }
            }
        }
    }
}
