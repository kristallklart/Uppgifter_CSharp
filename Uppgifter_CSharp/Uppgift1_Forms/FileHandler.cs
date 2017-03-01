using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift1_Forms.Uppgift1_ServiceReference;

namespace Uppgift1_Forms
{
    public static class FileHandler
    {
        private static Uppgift1_ServiceSoapClient proxy = new Uppgift1_ServiceSoapClient(); //Skapar en ny proxy-referens
        public static string GetFileContent(string s)
        {
            return proxy.OpenFile(s);
        }
    }
}
