using Microsoft.AspNetCore.Mvc;
using Mossad_MVC.Models;
using Newtonsoft.Json;
using System.Text;

namespace Mossad_MVC.Controllers
{
    public class MissionsController : Controller
    {
        private readonly HttpClient _httpClient;

        public MissionsController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public IActionResult Index()
        {
            return View();
        }

        // פונקציה לקבלת רשימת המשימות
        public async Task<IActionResult> GetSuggestionMissions()
        {

            var response = await _httpClient.GetAsync("http://localhost:5216/Missions/GetSuggestionMissions");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                ListMissionsViewModel missionsModel = JsonConvert.DeserializeObject<ListMissionsViewModel>(result);
                return View("Index", missionsModel.missions);
            }
            else
            {
                return View("Error");
            }
        }
        // פונקציה לעגכון סטטוס המשימה
        public async Task<IActionResult> UpdateMissionStatus(int id)
        {
            UpdateMissionStatus updateMissionStatus= new UpdateMissionStatus();

            updateMissionStatus.status = Enums.MissionStatus.Assigned.ToString();

            var jsonContent = JsonConvert.SerializeObject(updateMissionStatus);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync("http://localhost:5216/Missions/UpdateMissionStatus/" + id, content );
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("GetSuggestionMissions");
            }
            else
            {
                return View("Error");
            }
        }

        // פונקציה לקבלת משימה 
        public async Task<IActionResult> GetMissionDetails(int id)
        {
            var response = await _httpClient.GetAsync($"http://localhost:5216/Missions/GetMissionDetails/{id}");
           
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                GetMissionResponse missionsModel = JsonConvert.DeserializeObject<GetMissionResponse>(result);

                return View("Details", missionsModel.missionViewModel) ;

            }
            else
            {
                return View("Error");
            }
        }
    }
}


