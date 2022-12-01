using HalcyonApparelsMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;

namespace HalcyonApparelsMVC.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> AccessoryView()
        {
            HttpClientHandler clienthandler = new HttpClientHandler();
            clienthandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslpolicyerrors) => { return true; };

            HttpClient client = new HttpClient(clienthandler);
            client.BaseAddress = new Uri("https://localhost:7169");
            List<AccessoryDetailsMVC>? emplist = new List<AccessoryDetailsMVC>();

            HttpResponseMessage res = client.GetAsync("api/Accessory/Get").Result;
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                emplist = JsonConvert.DeserializeObject<List<AccessoryDetailsMVC>>(result);
            }
            return View(emplist);

        }
        [HttpPost]
        public IActionResult Post(AccessoryDetailsMVC accsrydet)
        {

            HttpClientHandler clienthandler = new HttpClientHandler();
            clienthandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslpolicyerrors) => { return true; };


            HttpClient client = new HttpClient(clienthandler);
            client.BaseAddress = new Uri("https://localhost:7169");
            var postTask = client.PostAsJsonAsync<AccessoryDetailsMVC>("api/Accessory/Post/", accsrydet);
            postTask.Wait();
            var Result = postTask.Result;
            if (Result.IsSuccessStatusCode)
            {
                return RedirectToAction("AccessoryView");
            }
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}