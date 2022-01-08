using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

namespace ValyutaViewJsonExcample
{
    class Program
    {
        static List<Valyuta> valyutas;
        static void Main(string[] args)
        {
            string path = "https://nbu.uz/uz/exchange-rates/json/";

            string json = GetDataAsJson(path);

            valyutas = JsonConvert.DeserializeObject<List<Valyuta>>(json);




        }
        static double UzsToUsd(double uzs)
        {
            Valyuta usd = valyutas.Where(o => o.Code == "USD").FirstOrDefault();

            return uzs / usd.Cb_price;
        }
        static string GetDataAsJson(string url)
        {
            HttpClient client = new HttpClient();

            string response = client.GetStringAsync(url).Result;

            return response;
        }
    }
}
