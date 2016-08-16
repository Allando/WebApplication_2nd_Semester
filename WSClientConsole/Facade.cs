//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http;
//using System.Net.Http.Headers;
//using System.Text;
//using System.Threading.Tasks;
//using WebApplication_2nd_Semester;

//namespace WSClientConsole
//{
//    class Facade
//    {
//        const string serverUrl = "http://localhost:6015";
//        HttpClientHandler handler = new HttpClientHandler();
//        handler.UseDefaultCredentials = true;

//            //HTTP GET All
//            using (var client = new HttpClient(handler))
//            {
//                client.BaseAddress = new Uri(serverUrl);
//        client.DefaultRequestHeaders.Clear();
//                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

//                try
//                {
//                    var responce = client.GetAsync("api/hotels").Result;
//                    if (responce.IsSuccessStatusCode)
//                    {
//                        var hotels = responce.Content.ReadAsAsync<IEnumerable<Hotel>>().Result;

//        var hotelQuery =
//            from h in hotels
//            select h;

//                        foreach (var h in hotelQuery)
//                        {
//                            Console.WriteLine(h);
//                        }
//}
//                }
//                catch(ArgumentException e)
//                {
//                    Console.WriteLine("pao0jdk" + e);
//                }
//            }

//            using (var client = new HttpClient(handler))
//            {
//                client.BaseAddress = new Uri(serverUrl);
//client.DefaultRequestHeaders.Clear();
//                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

//                try
//                {
//                    var response = client.GetAsync("api/hotel/" + Hotel.Hotel_No).Result;

//                    if (response.IsSuccessStatusCode)
//                    {
//                        var hotels = response.Content.ReadAsAsync<IEnumerable<Hotel>>().Result;

//var hotelQuery =
//    from h in hotels
//    where h.Name == Console.ReadLine()
//    select h;

//                        foreach (var h in hotelQuery)
//                        {
//                            Console.WriteLine(h);
//                        }
//                    }
//                }
//                catch (Exception)
//                {
                    
//                    throw;
//                }
//            }
//    }
//}
