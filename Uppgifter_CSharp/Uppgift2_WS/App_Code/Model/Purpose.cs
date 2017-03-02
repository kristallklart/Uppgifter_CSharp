using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Purpose
/// </summary>
namespace Model
{
    public class Purpose
    {
        public string PurposeType { get; set; }
        public List<UserLocationPurpose> UserLocationPurposes { get; set; }
    }
}