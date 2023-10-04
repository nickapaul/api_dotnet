namespace api_dotnet;
using RestSharp;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task Test1()
    {
        var options = new RestClientOptions("https://petstore.swagger.io"){MaxTimeout = -1,};
        var client = new RestClient(options);
        var request = new RestRequest("/v2/pet", Method.Post);
        request.AddHeader("Content-Type", "application/json");
        var body = @"{" + "\n" +
        @"  ""id"": 0," + "\n" +
        @"  ""category"": {" + "\n" +
        @"    ""id"": 0," + "\n" +
        @"    ""name"": ""string""" + "\n" +
        @"  }," + "\n" +
        @"  ""name"": ""doggie""," + "\n" +
        @"  ""photoUrls"": [" + "\n" +
        @"    ""string""" + "\n" +
        @"  ]," + "\n" +
        @"  ""tags"": [" + "\n" +
        @"    {" + "\n" +
        @"      ""id"": 0," + "\n" +
        @"      ""name"": ""string""" + "\n" +
        @"    }" + "\n" +
        @"  ]," + "\n" +
        @"  ""status"": ""available""" + "\n" +
        @"}";
        request.AddStringBody(body, DataFormat.Json);
        RestResponse response = await client.ExecuteAsync(request);
        Console.WriteLine(response.Content);
        
    }
}