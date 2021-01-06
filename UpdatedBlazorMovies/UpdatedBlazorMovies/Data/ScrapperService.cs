using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;
using HtmlAgilityPack;
namespace UpdatedBlazorMovies.Data
{
    public class ScrapperService
    {
        public async Task<List<string>> TopRatedMoviesScraper()
        {
            List<string> Datalist = new List<string>();

            HttpClient hc = new HttpClient();
            HttpResponseMessage result = await hc.GetAsync($"https://www.imdb.com/chart/top/");
            Stream stream = await result.Content.ReadAsStreamAsync();
            HtmlDocument doc = new HtmlDocument();
            doc.Load(stream);
            var HeaderNames = doc.DocumentNode.SelectNodes("//td[@class='titleColumn']");

            foreach (var item in HeaderNames)
            {
                Datalist.Add(item.InnerText);
            }
            return Datalist;
        }
    }
}
