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
            ////POST Hotel
            //using (var client = new HttpClient(handler))
            //{
            //    client.BaseAddress = new Uri(serverUrl);
            //    client.DefaultRequestHeaders.Clear();
            //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


            //    try
            //    {
            //    var response = client.PostAsJsonAsync("api/hotels", testHotel).Result;
            //        if (response.IsSuccessStatusCode)
            //        {
            //            Console.WriteLine("SUCCES!!! Hotellet er oprettet");
            //            Console.WriteLine("Statuskode: " + response.StatusCode);
            //            Console.WriteLine("Reason phrase: " + response.ReasonPhrase);
            //            Console.WriteLine("Is Success status code: " + response.IsSuccessStatusCode);
            //            Console.WriteLine("Content: " + response.Content);
            //            Console.WriteLine("Version: " + response.Version);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Fejl, hotellet blev ikke oprettet");
            //            Console.WriteLine("Statuskode: " + response.StatusCode);
            //            Console.WriteLine("Reason phrase: " + response.ReasonPhrase);
            //            Console.WriteLine("Is Success status code: " + response.IsSuccessStatusCode);
            //            Console.WriteLine("Content: " + response.Content);
            //            Console.WriteLine("Version: " + response.Version);
            //        }
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine("It's fucked: " + e);
            //    }
            //}



            ////Put Hotel

            ////The change
            //shitHotel.Name = "Not Gansta hotel";

            //using (var client = new HttpClient(handler))
            //{
            //    client.BaseAddress = new Uri(serverUrl);
            //    client.DefaultRequestHeaders.Clear();
            //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


            //    {
            //        try
            //        {
            //    var response = client.PutAsJsonAsync<Hotel>("api/hotels/10", shitHotel).Result;
            //            if (response.IsSuccessStatusCode)
            //            {
            //                Console.WriteLine("SUCCES!!! Hotellet er opdateret");
            //                Console.WriteLine("Statuskode: " + response.StatusCode);
            //                Console.WriteLine("Reason phrase: " + response.ReasonPhrase);
            //                Console.WriteLine("Is Success status code: " + response.IsSuccessStatusCode);
            //                Console.WriteLine("Content: " + response.Content);
            //                Console.WriteLine("Version: " + response.Version);
            //            }
            //            else
            //            {
            //                Console.WriteLine("Fejl, hotellet blev ikke opdateret");
            //                Console.WriteLine("Statuskode: " + response.StatusCode);
            //                Console.WriteLine("Reason phrase: " + response.ReasonPhrase);
            //                Console.WriteLine("Is Success status code: " + response.IsSuccessStatusCode);
            //                Console.WriteLine("Content: " + response.Content);
            //                Console.WriteLine("Version: " + response.Version);
            //            }
            //        }
            //        catch (Exception e)
            //        {
            //            Console.WriteLine("It's fucked: " + e);
            //        }
            //    }
            //}

            ////DELETE Hotel
            //using (var client = new HttpClient(handler))
            //{
            //    client.BaseAddress = new Uri(serverUrl);
            //    client.DefaultRequestHeaders.Clear();
            //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //    string urlString = "api/hotels/11";


            //    try
            //    {
            //        if (response.IsSuccessStatusCode)
            //        {
            //    var response = client.DeleteAsync(urlString).Result;
            //            Console.WriteLine("SUCCES!!! Hotellet er Slettet");
            //            Console.WriteLine("Statuskode: " + response.StatusCode);
            //            Console.WriteLine("Reason phrase: " + response.ReasonPhrase);
            //            Console.WriteLine("Is Success status code: " + response.IsSuccessStatusCode);
            //            Console.WriteLine("Content: " + response.Content);
            //            Console.WriteLine("Version: " + response.Version);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Fejl, hotellet blev ikke Slettet");
            //            Console.WriteLine("Statuskode: " + response.StatusCode);
            //            Console.WriteLine("Reason phrase: " + response.ReasonPhrase);
            //            Console.WriteLine("Is Success status code: " + response.IsSuccessStatusCode);
            //            Console.WriteLine("Content: " + response.Content);
            //            Console.WriteLine("Version: " + response.Version);
            //        }
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine("It's fucked: " + e);
            //    }
            //}

            //Insert new room in hotel 4

            Room newRoom = new Room()
            {
                Hotel_No = 4,
                Room_No = 4,
                Price = 564,
                Types = "D"
            };

            //using (var client = new HttpClient(handler))
            //{
            //    client.BaseAddress = new Uri(serverUrl);
            //    client.DefaultRequestHeaders.Clear();
            //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


            //    try
            //    {
            //        var response = client.PostAsJsonAsync("api/rooms", newRoom).Result;

            //        if (response.IsSuccessStatusCode)
            //        {
            //            Console.WriteLine("The room is on fire");
            //            Console.WriteLine("Statuskode: " + response.StatusCode);
            //            Console.WriteLine("Reason phrase: " + response.ReasonPhrase);
            //            Console.WriteLine("Is Success status code: " + response.IsSuccessStatusCode);
            //            Console.WriteLine("Content: " + response.Content);
            //            Console.WriteLine("Version: " + response.Version);
            //        }
            //        else
            //        {
            //            Console.WriteLine("No room");
            //            Console.WriteLine("Statuskode: " + response.StatusCode);
            //            Console.WriteLine("Reason phrase: " + response.ReasonPhrase);
            //            Console.WriteLine("Is Success status code: " + response.IsSuccessStatusCode);
            //            Console.WriteLine("Content: " + response.Content);
            //            Console.WriteLine("Version: " + response.Version);
            //        }
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine("Fuck up" + e);  
            //    }
            //}

            //Opg 8
            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri(serverUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                try
                {
                    var getHotelResponse = client.GetAsync("api/hotels").Result;
                    if (getHotelResponse.IsSuccessStatusCode)
                    {
                        Console.WriteLine("HOTEL Status Code: " + getHotelResponse.IsSuccessStatusCode);

                        var hotelList = getHotelResponse.Content.ReadAsAsync<List<Hotel>>().Result;

                        var hotelQuery =
                            from h in hotelList
                            where h.Address.ToString().Contains("Roskilde")
                            select h;

                        foreach (var h in hotelQuery)
                        {
                            Console.WriteLine(h);
                        }

                        Console.WriteLine();
                        var getRoomResponse = client.GetAsync("api/rooms").Result;
                        if (getRoomResponse.IsSuccessStatusCode)
                        {
                            Console.WriteLine("ROOMS Status Code: " + getRoomResponse.IsSuccessStatusCode);

                            var roomList = getRoomResponse.Content.ReadAsAsync<List<Room>>().Result;

                            //TEST
                            //var roomQ =
                            //    from r in roomList
                            //    select r;

                            //foreach (var q in roomQ)
                            //{
                            //    Console.WriteLine(q.ToString());
                            //}

                            var roomQuery =
                                from r in roomList
                                join h in hotelList
                                    on r.Hotel_No
                                    equals h.Hotel_No
                                where r.Types == "S"
                                select new Room()
                                {
                                 Hotel_No = r.Hotel_No,
                                 Price = r.Price,
                                 Room_No = r.Room_No,
                                 Types = r.Types
                                };

                            foreach (var hr in roomQuery)
                            {
                                try
                                {                         
                                    Console.WriteLine("Hotel Name: {0}\nRoom price before: {1}\n",hr.Hotel, hr.Price);

                                    hr.Price *= 1.2;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e);
                                } 
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("No hotels");
                    }

                    Console.WriteLine();

                    

                }
                catch (Exception e)
                {
                    Console.WriteLine("fuck up" + e);
                }
                
            }


        }
    }
}

