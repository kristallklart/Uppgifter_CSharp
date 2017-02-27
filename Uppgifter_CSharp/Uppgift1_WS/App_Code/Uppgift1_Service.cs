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
                          "the web method throws a FaultException which must be handled by the client.")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]

public class Uppgift1_Service : System.Web.Services.WebService
{
    public Uppgift1_Service () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string OpenFile(string s)
    {
        string openFileResult;
        //DotNetRevanths exempel på felhantering skapar en egen klass: https://www.youtube.com/watch?v=T4ndBlCpzdk
        using (StreamReader streamReader = new StreamReader(s))
        {
            openFileResult = streamReader.ReadToEnd();
            //returnContent = streamReader.ReadToEnd();
        }
        return openFileResult;
    }
}