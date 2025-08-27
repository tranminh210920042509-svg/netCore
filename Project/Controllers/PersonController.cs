namespace Project.Controllers
{

    using Microsoft.AspNetCore.Mvc;

    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string Fullname, string StudentID)
        {
            ViewData["CurrentFilter"] = Fullname;
            ViewData["CurrentFilter"] = StudentID;
            string stroutput = "Ni hão : " + Fullname + " Ma sinh vien : " + StudentID;
            ViewBag.Message = stroutput;
            return View();
        }
    }
} 