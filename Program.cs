using RestSharp;
    public class ResponseDat
{
    public List<object>entries{get; set;}
}
public class Program{
    public static void Main(string[]args){
       /* SumOfTwoNumbers.CalculateSum();
        PrimeNumber.IsPrime();
        BasicArray.PrintArray();
        StringReverse.Reverse();
        PracticeArrayList.ImplementArrayList();
        PracticeHashTables.ImplementHashTables();
        PracticeList.ImplementList();
        PracticeDictionary.ImplementDictionary();
        DerivedClass dc = new DerivedClass();
        dc.DerivedClassMethod();
        dc.BaseClassMethod();
        Female fm = new Female();
        fm.Heart();
        fm.Brain();
        fm.Breath();
        Earth et = new Earth();
        Mars ms = new Mars();
        et.Atmosphere();
        et.Rotate();
        ms.Atmosphere();
        ms.Tempertaure();
        Interview it = new Interview();
        it.HrRound();
        it.TechRound();
        Cricket ck = new Cricket();
        Football ft = new Football();
        ck.Run();
        ft.Run();
        Employee e = new Employee();
        e.SetName("Srajen");
        e.setID(115);
        Console.WriteLine("Name:"+e.GetName());
        Console.WriteLine("ID:"+e.GetId());
        e.setID(-20);
        Sniper s = new Sniper(10,20);
        Console.WriteLine("The range of gun is:"+s.range());
        GetApiCall.GetApi();
        PostApiCall.PostApi();
        PutRequest.Put();
        DeleteRequest.DeleteApi();*/
                EmployeeProfile empp = new EmployeeProfile{
            employee = new Employee{
                Id=478,
                First_Name="Rahul Singh",
                email="rahul123@gmail.com",
                Details = new Details{
                    Street="ShivajiNagar",
                    City="Pune",
                    State="Maharastra"
                },
                Contact_Details =new Contact_Details[]{
                    new Contact_Details{Type="Telephone",Number="123456"},
                    new Contact_Details{Type="Mobile",Number="1223344"}
                },
                Roles=new string[]{"QA","Consultant"}
            }
        };
        var client = new RestClient("http://localhost:3000/employee");
        var request = new RestRequest("",Method.Post);
        string jsonBody = Newtonsoft.Json.JsonConvert.SerializeObject(empp);
        request.AddParameter("application/json",jsonBody,ParameterType.RequestBody);
        var response = client.Execute(request);
        Console.WriteLine((int)response.StatusCode);
        Console.WriteLine(response);
        Console.WriteLine(response.Content);
        
        
    }
}

