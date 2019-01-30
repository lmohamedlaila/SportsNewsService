using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http;

namespace SportsNewsService.Controllers
{
    public class NewsController : ApiController
    {
        [HttpGet]
        public async Task<List<MatchModel>> GetSportsMatchesSchedualAsync()
        {
            string str = "http://10.3.4.29:30/api/SportsMatch";
            using (HttpClient httpClient = new HttpClient())
            {
                return JsonConvert.DeserializeObject<List<MatchModel>>(
                await httpClient.GetStringAsync(str)
            );
            }
            //using (var client = new HttpClient())
            //{
            //    client.BaseAddress = new Uri("http://10.3.4.29:30/api/SportsMatch");
            //    client.DefaultRequestHeaders.Accept.Clear();
            //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //    var response = client.GetAsync("http://10.3.4.29:30/api/SportsMatch").Result;
            //    if (response.IsSuccessStatusCode)
            //    {
            //        // string responseString = response.Content.ReadAsStringAsync().Result;
            //        // var list = response.Content.ReadAsAsync<MatchModel>().Result;
            //        //return list;
            //        //var response = client.GetAsync("umbraco/api/Member/Get?username=test");
            //        response.Wait();
            //    }
            //}

        }
    }
}
