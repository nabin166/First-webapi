using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UIlayer.Helper;
using UIlayer.Models;

namespace UIlayer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        UserApi api = new UserApi();

        public async Task<IActionResult>  Index()
        {
           
            HttpClient client = api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/User");
            List<UserApi> users = new List<UserApi>();

            if (res.IsSuccessStatusCode)
            {
                var result =  res.Content.ReadAsStringAsync().Result;
                
                

            }
            return View(User);

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
    }
}