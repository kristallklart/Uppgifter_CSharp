using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UserLocationPurpose
/// </summary>
namespace Model
{
    public class UserLocationPurpose
    {
        public User User { get; set; }
        public Location Location { get; set; }
        public Purpose Purpose { get; set; }

        public string City { get; set; }
        public string Username { get; set; }
        public string Purposetype { get; set; }

        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}