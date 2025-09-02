namespace Project.Controllers
{

    using Microsoft.AspNetCore.Mvc;

    using Project.Models;    




    public class bai1Controller : Controller
    {

        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Index(bai1 ps)
        {


            ViewBag.Message = "xin chao" + "_" + ps.hoten + "_" + ps.namsinh + "_" + ps.sotuoi;

            return View();
        }
    }
}

