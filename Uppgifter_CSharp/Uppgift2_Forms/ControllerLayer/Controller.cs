﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift2_Forms.ControllerLayer
{
    public static class Controller
    {
        static Uppgift2_ServiceReference.Uppgift2_ServiceSoapClient proxy = new Uppgift2_ServiceReference.Uppgift2_ServiceSoapClient();
        public static List<object> GetAllUsers()
        {
            return proxy.GetAllUsers();
        }
        public static List<object> GetAllLocations()
        {
            return proxy.GetAllLocations(); 

        }
        public static List<object> GetAllUserLocationPurposes()
        {
            return proxy.GetAllUserLocationPurposes();
        }
        public static List<object> GetAllPurposes()
        {
            return proxy.GetAllPurposes();  
        }
        public static List<object> GetAllFieldOfProfessions()
        {
            return proxy.GetAllFieldOfProfessions();
        }
        public static List<object> GetAllMatches()
        {
            return proxy.GetAllMatches();
        }
        public static List<object> GetAllMessages()
        {
            return proxy.GetAllMessages();
        }
    }
}