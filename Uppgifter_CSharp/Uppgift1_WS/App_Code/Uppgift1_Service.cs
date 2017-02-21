﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

[WebService(Namespace = "Grupp7", 
            Description = "This web service has one web method which takes a string filename/filepath as parameter " +
                          "and returns the file content to the caller as a string if successful. If an error occurs, " + 
                          "the web method returns an error message as a string")]
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
        string returnContent;
        //DotNetRevanths exempel på felhantering skapar en egen klass: https://www.youtube.com/watch?v=T4ndBlCpzdk
        try
        {
            using (StreamReader streamReader = new StreamReader(s))
            {
                returnContent = streamReader.ReadToEnd();
            }
        }
        catch (FileNotFoundException)
        {
            returnContent = "ERROR: File not found!";
        }
        catch (OutOfMemoryException)
        {
            returnContent = "ERROR: Out of memory!";
        }
        catch (Exception)
        {
            //Exception ex = exp.InnerException;
            returnContent = "ERROR: Unknown error, the file could not be read!";
        }
        return returnContent;
    }
}