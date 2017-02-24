using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Location
/// </summary>
public class Location
{
    public string City { get; set; }
    public List<UserLocationPurpose> UserLocationPurposes { get; set; }

	public Location()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}