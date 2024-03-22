using Newtonsoft.Json;
using RestSharp;

public static class PostApiCall{
    public static void PostApi(){
        var client = new RestClient("https://reqres.in/api/users");
        var request = new RestRequest("",Method.Post);
        request.AddParameter("name","Srajen");
        request.AddParameter("job","Leader");
        RestResponse response = client.Execute(request);
        if(response.IsSuccessful){
            Console.WriteLine("responseCode:"+(int)response.StatusCode);
            dynamic jsonResponse = JsonConvert.DeserializeObject(response.Content);
            Console.WriteLine(jsonResponse);
        }
    }
} 