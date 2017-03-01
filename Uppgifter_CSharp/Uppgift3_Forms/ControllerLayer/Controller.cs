﻿using System;
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

        public static List<Employee> GetSickleave()
        {
            return proxy.GetSickleave();
        }

        public static List<Employee> GetMostSick()
        {
            return proxy.GetMostSick();
        }

        public static List<string> GetKeys()
        {
            return proxy.GetKeys();
        }

        public static List<Index> GetIndices()
        {
            return proxy.GetIndices();
        }

        public static List<Constraint> GetConstraints()
        {
            return proxy.GetConstraints();
        }

        public static List<string> GetTablesOne()
        {
            return proxy.GetTablesOne();
        }
        public static List<string> GetTablesTwo()
        {
            return proxy.GetTablesTwo();
        }

        public static List<string> GetColumnsOne()
        {
            return proxy.GetColumnsOne();
        }
        public static List<string> GetColumnsTwo()
        {
            return proxy.GetColumnsTwo();
        }
    }
}
