using HtmlAgilityPack;
using System.Threading.Tasks;
using Scraper.Models;

namespace Scraper{
    public static class Scraper
    {
        public static async Task<ScrapedObject> GetScrapedObject(string uri)
        {
            var newScrapedThing = new ScrapedObject();
            var web = new HtmlWeb();
            var html = await web.LoadFromWebAsync(uri);

            // do something with the html doc, see https://html-agility-pack.net/
            // e.g
            /*

            foreach (var cell in doc.DocumentNode.SelectNodes("//table[@id='someId']/tr/td"))
            {
                // do something with table cell
            }

            */
            
            return newScrapedThing;
        }
    }
}