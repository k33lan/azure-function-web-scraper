using System.Threading.Tasks;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace Scraper
{
    public static class ScrapeSite
    {
        [Function("ScrapeSite")]
        public static async Task<HttpResponseData> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequestData req, FunctionContext context)
        {
            var logger = context.GetLogger(nameof(ScrapeSite));
            var scrapedObject = await Scraper.GetScrapedObject("<your url>");

            // do something with your scraped object

		    var okResponse = req.CreateResponse(System.Net.HttpStatusCode.OK);
            return okResponse;
        }
    }
}
