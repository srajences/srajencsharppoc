using Newtonsoft.Json;
using RestSharp;

public static class PutRequest{
    public static void Put(){
        var client = new RestClient("https://reqres.in/api/users/2");
        var request = new RestRequest("",Method.Put);
        request.AddParameter("name","Sjjj");
        request.AddParameter("job","Plumber");
        RestResponse response = client.Execute(request);
        if(response.IsSuccessful){
            Console.WriteLine("responseCode:"+(int)response.StatusCode);
            dynamic jsonResponse = JsonConvert.DeserializeObject(response.Content);
            Console.WriteLine(jsonResponse);
        }
    }
}