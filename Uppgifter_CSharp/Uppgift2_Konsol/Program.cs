using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift2_Konsol
{
    class Program
    {
        static void Main(string[] args)
        {
            Uppgift2_ServiceReference.Uppgift2_ServiceSoapClient proxy = new Uppgift2_ServiceReference.Uppgift2_ServiceSoapClient();
            //Uppgift2_ServiceReference.Person[] persons = proxy.GetAllPersons();
            //Uppgift2_ServiceReference.User aUser = proxy.getUser();
            
            //List<Uppgift2_ServiceReference.User> users = new List<Uppgift2_ServiceReference.User>(); 
            Uppgift2_ServiceReference.User[] users = proxy.GetUsers();
            Uppgift2_ServiceReference.Purpose[] purposes = proxy.GetPurposes();

            Console.WriteLine(users.Length);
            Console.ReadKey();

            for(int i = 0; i < users.Length; i++)
            {
                Console.WriteLine(users[i].UserName);
                Console.WriteLine(users[i].FirstName);
                Console.WriteLine(users[i].LastName);
                Console.WriteLine(users[i].About);
                Console.WriteLine(users[i].Profession);
                Console.WriteLine(users[i].Industry);
            }
            Console.ReadKey();

            for (int i = 0; i < purposes.Length; i++)
            {
                Console.WriteLine(purposes[i].PurposeType);
            }
            Console.ReadKey();
        }
    }
}
