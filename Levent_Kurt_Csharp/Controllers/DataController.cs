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
            return View(data);
        }
    }
}
