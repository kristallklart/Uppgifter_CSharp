using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Message
/// </summary>
public class Message
{
    public int Id { get; set; }
    public string Sender { get; set; }
    public string Reciever { get; set; }
    public string Content { get; set; }
    public User User { get; set; }

	public Message()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}