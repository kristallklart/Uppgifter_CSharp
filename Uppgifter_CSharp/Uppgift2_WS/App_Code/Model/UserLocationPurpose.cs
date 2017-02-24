﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UserLocationPurpose
/// </summary>
public class UserLocationPurpose
{
    public User User { get; set; }
    public Location Location { get; set; }
    public Purpose Purpose { get; set; }

    public string City { get; set; }
    public string Username { get; set; }
    public string Purposetype { get; set; }

    public Nullable<System.DateTime> FromDate { get; set; }
    public Nullable<System.DateTime> ToDate { get; set; }

	public UserLocationPurpose()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}