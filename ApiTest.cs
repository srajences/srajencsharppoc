using Xunit;
using RestSharp;
using Newtonsoft.Json.Linq;
public  class ApiTests{
    [Fact]
    public void ApiAssertion(){
         var client = new RestClient("https://api.publicapis.org/entries");
        var request = new RestRequest("",Method.Get);
        RestResponse response = client.Execute(request);
        JObject responseObject = JObject.Parse(response.Content);
        JArray entriesArray = (JArray)responseObject["entries"];
        Assert.True(entriesArray.All(entry=>(bool)entry["HTTPS"]),"All Http field don't have values as true");
    }
    [Fact]
    public void StatusCodeAssertion(){
         var client = new RestClient("https://api.publicapis.org/entries");
        var request = new RestRequest("",Method.Get);
        RestResponse response = client.Execute(request);
        Assert.Equal(200,(int)response.StatusCode);
    }
}