using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Location
/// </summary>
namespace Model
{
    public class Location
    {
        public string City { get; set; }
        public List<UserLocationPurpose> UserLocationPurposes { get; set; }
    }
}