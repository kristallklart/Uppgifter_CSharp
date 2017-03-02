using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Match
/// </summary>
namespace Model
{
    public class Match
    {
        public string MatchUsername { get; set; }
        public string Username { get; set; }
        public User User { get; set; }
    }
}