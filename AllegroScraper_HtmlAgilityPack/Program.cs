using System;
using System.Linq;
using HtmlAgilityPack;

namespace AllegroScraper_HtmlAgilityPack
{
    class Program
    {
        static void Main(string[] args)
        {
            //string url = "https://allegro.pl/kategoria/sony-playstation-2-ps2-eye-toy-122277?bmatch=baseline-cl-dict42-ele-1-5-1024";
            string url = "https://allegro.pl/listing?string=ps2&bmatch=baseline-cl-dict42-ele-1-5-1024";
            HtmlWeb web = new HtmlWeb();
            HtmlDocument htmlDoc = web.Load(url);


            var nodes = htmlDoc.DocumentNode.Descendants().Where(n => n.HasClass("ebc9be2") || n.HasClass("fe6e937") || n.HasClass("_3eac29b"));

            foreach (var item in nodes)
            {
                Console.WriteLine(item.InnerText);
            }
        }
    }
}