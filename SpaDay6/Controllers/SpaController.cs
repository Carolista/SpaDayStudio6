using Microsoft.AspNetCore.Mvc;
using SpaDay6.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay6.Controllers
{
    public class SpaController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/spa")]
        public IActionResult Menu(string skintype, string manipedi)
        {
            Client newClient = new Client(skintype, manipedi);
            newClient.SetFacials(newClient.SkinType);
            ViewBag.client = newClient;
            return View();
        }
    }
}

