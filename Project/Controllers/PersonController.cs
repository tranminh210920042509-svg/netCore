using Microsoft.AspNetCore.Mvc;
using Project.Models.Person;


namespace Project.Controllers
{
    public class PersonController : Controller
    {

        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Index(Person ps)
        {


            ViewBag.Message = "xin chao" + "_" + ps.Fullname + "-" + ps.StudentID;
            return View();
        }
    }
}

        