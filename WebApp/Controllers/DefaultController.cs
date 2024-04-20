using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using WebApp.ViewModels;

namespace WebApp.Controllers;

public class DefaultController(HttpClient httpClient) : Controller
{
    private readonly HttpClient _httpClient = httpClient;

    public IActionResult Home()
    {
        return View();
    }


    [HttpPost]
    public async Task<IActionResult> Subscribe(SubscribeViewModel model)
    {
        if (ModelState.IsValid)
        {
            var content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            var reponse = await _httpClient.PostAsync("https://localhost:7176/api/subscribe", content);
            if (reponse.IsSuccessStatusCode)
            {
                TempData["StatusMessage"] = "You have subscribed";
            }
            else if (reponse.StatusCode == System.Net.HttpStatusCode.Conflict)
            {
                TempData["StatusMessage"] = "You are already a subscriber";
            }
            
        }
        else
        {
            TempData["StatusMessage"] = "Invalid email address";
        }
        return RedirectToAction("Home", "Default", "subsribe");
    }
}
