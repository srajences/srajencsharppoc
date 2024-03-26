using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

public class EmployeeProfile{
    public Employee employee{
        get;
        set;
    }
}
public class Employee
{
    public int Id{
        get;
        set;
    }
    public string First_Name{
        get;
        set;
    }
    public string email{
        get;
        set;
    }
    public Details Details{
        get;
        set;
    }
    public Contact_Details[]Contact_Details{
        get;
        set;
    }
    public string[]Roles{
        get;
        set;
    }
}
public class Details{
    public string Street {
        get;
        set;
    }
    public string City{
        get;
        set;
    }
    public string State{
        get;
        set;
    }
}
public class Contact_Details{
    public string Type{
        get;
        set;
    }
    public string Number{
        get;
        set;
    }
}


