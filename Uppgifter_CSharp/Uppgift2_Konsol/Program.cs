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
            Uppgift2_ServiceReference.Person[] persons = proxy.GetAllPersons();

            Console.WriteLine(persons[0].name);
            
        }
    }
}
