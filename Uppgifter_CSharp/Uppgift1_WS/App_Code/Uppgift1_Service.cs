using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.ServiceModel;

[WebService(Namespace = "Grupp7", 
            Description = "This web service has one web method which takes a string filename/filepath as parameter " +
                          "and returns the file content to the caller as a string if successful. If an error occurs, " + 
                          "the web method throws a FaultException in .NET environments and a RemoteException in Java " + 
                          "environments. These exceptions must be handled by the client.")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]

public class Uppgift1_Service : System.Web.Services.WebService
{
    public Uppgift1_Service () 
    {

    }

    [WebMethod]
    public string OpenFile(string s)
    {
        string openFileResult;
        using (StreamReader streamReader = new StreamReader(s))
        {
            openFileResult = streamReader.ReadToEnd();
        }
        return openFileResult;
    }
}