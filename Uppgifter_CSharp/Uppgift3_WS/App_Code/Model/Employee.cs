using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Employee
{
    public Employee() { }

    public string EmployeeNumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Title { get; set; }
    public string City { get; set; }
    public string AbsenceCause { get; set; }
    public DateTime FromDate { get; set; }
    public int NumberOfSickDays { get; set; }

}