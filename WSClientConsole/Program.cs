using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WebApplication_2nd_Semester;

namespace WSClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            const string serverUrl = "http://localhost:6015";
            HttpClientHandler handler = new HttpClientHandler();
            handler.UseDefaultCredentials = true;

            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri(serverUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    var responce = client.GetAsync("api/hotels").Result;
                    if (responce.IsSuccessStatusCode)
                    {
                        var hotels = responce.Content.ReadAsAsync<IEnumerable<Hotel>>().Result;
                        foreach (var h in hotels)
                        {
                            Console.WriteLine(h);
                        }
                    }
                }
                catch
                {
                    
                }
            }
        }
    }
}
