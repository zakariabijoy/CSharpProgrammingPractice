using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace RequestBinExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
           await MakeRequest();
        }

        private static async Task MakeRequest()
        {
            using var httpClient = new HttpClient();
            //var response = await httpClient.GetAsync(new Uri("http://requestbin.net/r/6dlnkjk7"));
            //var response = await httpClient.GetAsync(new Uri("https://9c02c039fa635d5ad72091cc73b8a193.m.pipedream.net"));
            var content = new StringContent("{\"locationName\":\"ctg\",\"lat\":1.2684655,\"lon\":103.7045311,\"timestamp\":\"2021-11-04\"}");
            for (int i = 0; i < 11; i++)
            {
                
                var response = await httpClient.PostAsync(new Uri("https://enh3k1yv723cp3d.m.pipedream.net"), content);

                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
            }
            
        }
    }

    
}
