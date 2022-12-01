using EmployeeMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace EmployeeMVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult EmployeeView()
        {
            //var client = new HttpClient();
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            // Pass the handler to httpclient(from you are calling api)
            HttpClient client = new HttpClient(clientHandler);
            client.BaseAddress = new Uri("https://localhost:44315");
            List<EmployeeModelMVC>? emplist = new List<EmployeeModelMVC>();

            HttpResponseMessage res = client.GetAsync("api/Employee/Get").Result;
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                emplist = JsonConvert.DeserializeObject<List<EmployeeModelMVC>>(result);
            }
            return View(emplist);
        }

        public ActionResult Post()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Post(EmployeeModelMVC empreg, HttpClient client)
        {
            //var client = new HttpClient();
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            // Pass the handler to httpclient(from you are calling api)
            HttpClient client = new HttpClient(clientHandler);
            //var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44315");
            var postTask = client.PostAsJsonAsync<EmployeeModelMVC>("api/Employee/Post",empreg);
            postTask.Wait();
            var Result = postTask.Result;
            if (Result.IsSuccessStatusCode)
            {
                return RedirectToAction("ViewEmployee");
            }
            return View();
        }
    }

}