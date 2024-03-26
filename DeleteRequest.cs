using Newtonsoft.Json;
using RestSharp;
public static class DeleteRequest{
    public static void DeleteApi(){
        var client = new RestClient("https://reqres.in/api/users/2");
        var request = new RestRequest("",Method.Delete);
        RestResponse response = client.Execute(request);
        Console.WriteLine("StatusCode is:"+(int)response.StatusCode);

    }
}