using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Xml.Serialization;
using WebApplication_2nd_Semester;

namespace WSClientConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            const string serverUrl = "http://localhost:6015";
            HttpClientHandler handler = new HttpClientHandler();
            handler.UseDefaultCredentials = true;

            //HTTP GET All
            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri(serverUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                try
                {
                    var response = client.GetAsync("api/hotels").Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var hotels = response.Content.ReadAsAsync<IEnumerable<Hotel>>().Result;

                        var hotelQuery =
                            from h in hotels
                            select h;

                        foreach (var h in hotelQuery)
                        {
                            Console.WriteLine("HELLO" + h);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("GET ALL ERROR!!" + e);
                    Console.ReadLine();
                }
            }  



            //using (var client = new HttpClient(handler))
            //{
            //    client.BaseAddress = new Uri(serverUrl);
            //    client.DefaultRequestHeaders.Clear();
            //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //    try
            //    {
            //        var response = client.GetAsync("api/hotels/5").Result;

            //        if (response.IsSuccessStatusCode)
            //        {

            //            var hotels = response.Content.ReadAsAsync<Hotel>().Result;

            //            //var hotelQuery =
            //            //    from h in hotels
            //            //    where h.Hotel_No == 5
            //            //    select h;

            //            foreach (var h in hotels)
            //            {
            //                Console.WriteLine(h);
            //            }
            //        }
            //    }
            //    catch (ArgumentException e)
            //    {

            //        Console.WriteLine("GET 1 ERROR!!" + e);
            //    }
            //}

            Console.ReadLine();
        }
    }
}