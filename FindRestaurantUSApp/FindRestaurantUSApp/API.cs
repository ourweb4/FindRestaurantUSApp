using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using FindRestaurantUSApp.Models;
using System.Threading.Tasks;
using System.Linq;


namespace FindRestaurantUSApp
{
    class API
    {
        private string surl;
        public HttpClient client;
        public const string ApiKeyHeader = "X-API-Key";
        public const string ENDPOINTZIPCODE = "api/ZIPCodes";
        public const string ENDPOINTPLACE = "api/Place/";
        public const string ENDPOINTUSER = "api/User/";
        public const string ENDPOINTREVEIW = "api/Reveiw/";

        public API(string purl= "http://findrestaurantus.com/", string apikey = "")
        {
            surl = purl;
            client = new HttpClient();
            client.BaseAddress = new Uri(surl);
            client.DefaultRequestHeaders.Accept.Clear();
        //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            SetAPIKey(apikey);
        }
        
        public void SetAPIKey(string apikey)
        {
            if (apikey != "")
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(ApiKeyHeader, apikey);

        }
        public async Task<ZIPCode> GetZIPCode(string zip)
        {
            ZIPCode rec = new ZIPCode();

            string response = await client.GetStringAsync(ENDPOINTZIPCODE + "/" + zip);          
            rec = JsonConvert.DeserializeObject<ZIPCode>(response);
            
            return rec;
        }

        public async Task< List<Place>> GetPlaces(string city, string state)
        {
            List<Place> places = null;

            string response = await client.GetStringAsync(ENDPOINTPLACE + "?city=" + city + "&state=" + state + "&country=US");
            places = JsonConvert.DeserializeObject<List<Place>>(response);
            return places;

        }

        // User section

        public async Task<Account> CreateUser(string username, string password, string email, string question, string answer)
        {
            Account account = new Account();
            string turl = ENDPOINTUSER + "?username=" + username + "&password=" + password
                + "&email=" + email + "&question=" + question + "&answer=" + answer;

            StringContent queryString = new StringContent("");


           // HttpContent content;
            HttpResponseMessage response = await client.PostAsync(turl, queryString);

            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            account = JsonConvert.DeserializeObject<Account>(responseBody); 
            
            return account;
        }


        public async Task<Account> Login(string username, string password)
        {
            Account account = new Account();
            string turl = ENDPOINTUSER + "?Username=" + username + "&password=" + password;
            string response = await client.GetStringAsync(turl);
            account = JsonConvert.DeserializeObject<Account>(response);
            return account;
        }

        // Reveiw section
        public async Task<Reveiw> Addreveiw(Reveiw reveiw)
        {
            Reveiw rec = reveiw;
            string body = JsonConvert.SerializeObject(rec);

            StringContent queryString = new StringContent(body);


            // HttpContent content;
            HttpResponseMessage response = await client.PostAsync(ENDPOINTREVEIW, queryString);

            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            response.EnsureSuccessStatusCode();

            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                rec.Reveiw_Id = -1;
            }
            else
            {


                string responseBody = await response.Content.ReadAsStringAsync();
                rec = JsonConvert.DeserializeObject<Reveiw>(responseBody);
            }      
            return rec;
        }
    }
    }
