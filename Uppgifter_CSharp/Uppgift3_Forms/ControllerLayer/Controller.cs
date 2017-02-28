using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift3_Forms.Uppgift3_ServiceReference;

namespace Uppgift3_Forms.ControllerLayer
{
    public static class Controller
    {
        public static ServiceSoapClient proxy = new ServiceSoapClient();

        public static List<Employee> GetEmployees()
        {
            return proxy.GetEmployees();
        }

        public static List<EmployeeRelative> GetEmployeeRelatives()
        {
            return proxy.GetEmployeeRelatives();
        }
    }
}
