using Microsoft.AspNetCore.Mvc;
using SqlBaglantiliJqueryAjax.Models;
using System.Diagnostics;

namespace SqlBaglantiliJqueryAjax.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult GetAllStudents()
        {
            List<Student> students = new List<Student>();
            UserContext context = new UserContext();
            students=context.Set<Student>().ToList();
            context.Dispose();
            return PartialView("GetAllStudents",students);
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
    }
}