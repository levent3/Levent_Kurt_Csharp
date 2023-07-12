using AutoMapper;
using Levent_Kurt_Csharp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace Levent_Kurt_Csharp.Controllers
{
    public class DataController : Controller
    {
        private readonly HttpClient _httpClient;
		

		public DataController()
        {
            _httpClient = new HttpClient();
			
		}
        public async Task <IActionResult> Index()
        {
           
            var apiResponse = await _httpClient.GetStringAsync("https://api.tmgrup.com.tr/v1/link/352");
           
            var data = JsonConvert.DeserializeObject<DataModel>(apiResponse);


            return View(data.Data.articles.Response);
        }





        public async Task<IActionResult> Video()
        {

            var apiResponse2 = await _httpClient.GetStringAsync("https://api.tmgrup.com.tr/v1/link/424");

            var data2 = JsonConvert.DeserializeObject<VideosModel>(apiResponse2);


            return View(data2.data.videos.Response);
        }


    }
}
