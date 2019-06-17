using System;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;

public static async Task<IActionResult> Run(HttpRequest req, ILogger log)
{
    HttpClient client = new HttpClient();

    log.LogInformation("C# HTTP trigger function processed a request.");

    var request = new HttpRequestMessage
    {
        RequestUri = new Uri("https://httpsecreturl.azurewebsites.net/api/HttpSecretURLTrigger"),
        Method = HttpMethod.Get,
    };
    var result = client.SendAsync(request).Result;
    result.EnsureSuccessStatusCode();

    var secretUrl = await result.Content.ReadAsStringAsync().ConfigureAwait(false);

    var htmlPage = "<html><head><meta http-equiv='refresh' content='3;url=" + secretUrl + "'></head><body>Please wait...</body></html>";

    return new ContentResult { Content = htmlPage, ContentType = "text/html" };
}