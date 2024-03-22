using Newtonsoft.Json;
using RestSharp;

public static class GetApiCall{
    public static void GetApi(){
        var client = new RestClient("https://api.publicapis.org/entries");
        var request = new RestRequest("",Method.Get);
        RestResponse response = client.Execute(request);
        if(response.IsSuccessful){
           ResponseDat responseData = JsonConvert.DeserializeObject<ResponseDat>(response.Content);
             int numberOfObjects = responseData.entries.Count;
            dynamic jsonResponse = JsonConvert.DeserializeObject(response.Content);
            Console.WriteLine(jsonResponse);
            Console.WriteLine("Number of Objects:"+numberOfObjects);
        }
    }
} 