using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1_Konsol
{
    public static class Controller
    {
        public static string GetFileContent(string s)
        {
            return FileHandler.GetFileContent(s);
        }
    }
}
