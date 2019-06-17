using System;
using System.IO;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Microsoft.Devpmms
{
    public static class Dotnet2019ChallengeTrigger
    {

        static HttpClient client = new HttpClient();

        [FunctionName("Dotnet2019ChallengeTrigger")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
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
//            return  (ActionResult)new OkObjectResult(htmlPage);
//            return  new BadRequestObjectResult("Please pass a name on the query string or in the request body");
        }
    }
}
