using RestSharp;
public static class GetApiCall{
    public static void GetApi(){
        var client = new RestClient("https://api.publicapis.org");
        var request = new RestRequest("/entries",Method.Get);
        RestResponse response = client.Execute(request);
        if(response.IsSuccessful){
            Console.WriteLine(response.Content);
        }
    }
} 