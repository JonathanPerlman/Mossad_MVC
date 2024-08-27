using Microsoft.AspNetCore.Mvc;
using Mossad_MVC.Models;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Http;

namespace Mossad_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HttpClient _httpClient;

        public HomeController(ILogger<HomeController> logger, HttpClient httpClient)
        {
            _logger = logger;
            _httpClient = httpClient;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        // ??????? ????? ?? ???????
        public async Task<IActionResult> GetAllData()
        {

            var response = await _httpClient.GetAsync("http://localhost:5216/MVC/GetAllData");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                GeneralViewModel generalModel = JsonConvert.DeserializeObject<GeneralViewModel>(result);
                return View("General", generalModel);
            }
            else
            {
                return View("Error");
            }
        }




        // ??????? ????? ????? ????? 
        public async Task<IActionResult> GetAgentsData()
        {
            var response = await _httpClient.GetAsync("http://localhost:5216/MVC/GetAgentsData");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                List<AgentViewModel> generalModel = JsonConvert.DeserializeObject<List<AgentViewModel>>(result);
                return View("Agents", generalModel);
            }
            else
            {
                return View("Error");
            }
        }



        // ??????? ????? ????? ?????
        public async Task<IActionResult> GetTargetsData()
        {
            var response = await _httpClient.GetAsync("http://localhost:5216/MVC/GetTargetsData");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                List<TargetViewModel> generalModel = JsonConvert.DeserializeObject<List<TargetViewModel>>(result);
                return View("Targets", generalModel);
            }
            else
            {
                return View("Error");
            }
        }



    }
}
