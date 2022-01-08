using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;

namespace ValyutaViewJsonExcample
{
    class Program
    {
        static List<>
        static void Main(string[] args)
        {
            string path = "https://nbu.uz/uz/exchange-rates/json/";
            



        }
        static string GetDataAsJson(string url)
        {
            HttpClient client = new HttpClient();

            string response = client.GetStringAsync(url).Result;

            return response;
        }
    }
}
