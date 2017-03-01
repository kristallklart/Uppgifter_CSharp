using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for User
/// </summary>

public class User
{
    public string UserName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public byte[] Picture { get; set; }
    public string Profession { get; set; }
    public string Password { get; set; }
    public string About { get; set; }
    public string Industry { get; set; }

    public FieldOfProfession FieldOfProfession { get; set; }
    public List<UserLocationPurpose> UserLocationPurposes { get; set; }
    public List<Match> Matches { get; set; }
    public List<Message> Messages { get; set; }

	public User()
	{
	}
}