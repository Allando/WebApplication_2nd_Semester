using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
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

            ////HTTP GET All
            //using (var client = new HttpClient(handler))
            //{
            //    client.BaseAddress = new Uri(serverUrl);
            //    client.DefaultRequestHeaders.Clear();
            //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //    try
            //    {
            //        var response = client.GetAsync("api/hotels").Result;
            //        if (response.IsSuccessStatusCode)
            //        {
            //            var hotels = response.Content.ReadAsAsync<IEnumerable<Hotel>>().Result;

            //            var hotelQuery =
            //                from h in hotels
            //                select h;

            //            foreach (var h in hotelQuery)
            //            {
            //                Console.WriteLine("HELLO" + h);
            //            }
            //        }
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine("GET ALL ERROR!!" + e);
            //        Console.ReadLine();
            //    }
            //}

            ////GET ONE HOTEL
            //using (var client = new HttpClient(handler))
            //{
            //    client.BaseAddress = new Uri(serverUrl);
            //    client.DefaultRequestHeaders.Clear();
            //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //    string urlString = "api/hotels/5";
            //    try
            //    {
            //        var response = client.GetAsync(urlString).Result;
            //        if (response.IsSuccessStatusCode)
            //        {
            //            var hotels = response.Content.ReadAsAsync<Hotel>().Result;
            //            Console.WriteLine(hotels);
            //        }
            //    }
            //    catch (ArgumentException e)
            //    {
            //        Console.WriteLine("GET 1 ERROR!!" + e);
            //    }
            //}

            //Hotel til db
            var shitHotel = new Hotel()
            {
                Hotel_No = 10,
                Address = "4000 Roskilde",
                Name = "Hotel Motel"
            };

            var testHotel = new Hotel()
            {
                Hotel_No = 11,
                Address = "654654 TEst",
                Name = "Test"

            };
            //POST Hotel
            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri(serverUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = client.PostAsJsonAsync("api/hotels", testHotel).Result;
                try
                {
                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("SUCCES!!! Hotellet er oprettet");
                        Console.WriteLine("Statuskode: " + response.StatusCode);
                        Console.WriteLine("Reason phrase: " + response.ReasonPhrase);
                        Console.WriteLine("Is Success status code: " + response.IsSuccessStatusCode);
                        Console.WriteLine("Content: " + response.Content);
                        Console.WriteLine("Version: " + response.Version);
                    }
                    else
                    {
                        Console.WriteLine("Fejl, hotellet blev ikke oprettet");
                        Console.WriteLine("Statuskode: " + response.StatusCode);
                        Console.WriteLine("Reason phrase: " + response.ReasonPhrase);
                        Console.WriteLine("Is Success status code: " + response.IsSuccessStatusCode);
                        Console.WriteLine("Content: " + response.Content);
                        Console.WriteLine("Version: " + response.Version);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("It's fucked: " + e);
                }




            }


        }
    }
}
