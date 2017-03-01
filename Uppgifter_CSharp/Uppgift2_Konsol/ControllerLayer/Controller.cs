using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift2_Konsol.Uppgift2_ServiceReference;

namespace Uppgift2_Konsol.ControllerLayer
{
    public static class Controller
    {
        private static Uppgift2_ServiceSoapClient proxy = new Uppgift2_ServiceSoapClient();

        public static List<User> GetAllUsers()
        {
            return proxy.GetAllUsers();
        }
        public static List<Location> GetAllLocations()
        {
            return proxy.GetAllLocations();
        }
        public static List<UserLocationPurpose> GetAllUserLocationPurposes()
        {
            return proxy.GetAllUserLocationPurposes();
        }
        public static List<Purpose> GetAllPurposes()
        {
            return proxy.GetAllPurposes();
        }
        public static List<FieldOfProfession> GetAllFieldOfProfessions()
        {
            return proxy.GetAllFieldOfProfessions();
        }
        public static List<Match> GetAllMatches()
        {
            return proxy.GetAllMatches();
        }
        public static List<Message> GetAllMessages()
        {
            return proxy.GetAllMessages();
        }
    }
}
