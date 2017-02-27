using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for OpenFileResult
/// </summary>
public class OpenFileResult
{
    public string errorMessage { get; set; }
    public string fileContent { get; set; }

	public OpenFileResult()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    //public OpenFileResult(string errorMessage)
    //{
    //    this.errorMessage = errorMessage;
    //    //this.fileContent = fileContent;
    //}
    //public OpenFileResult(string fileContent)
    //{
    //    this.fileContent = fileContent;
    //}
    //public OpenFileResult(string errorMessage, string fileContent)
    //{
    //    this.errorMessage = errorMessage;
    //    this.fileContent = fileContent;
    //}
}