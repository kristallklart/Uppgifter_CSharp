using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for FieldOfProfession
/// </summary>
namespace Model
{
    public class FieldOfProfession
    {
        public string Industry { get; set; }
        public List<User> Users { get; set; }
    }
}