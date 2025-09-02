using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace Project.Controllers
{
    public class Bai3Controller : Controller
    {
        [HttpGet]
       
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(bai3 b3)
        {
            if (b3.CanNang > 0 && b3.ChieuCao > 0)
            {
                b3.BMI = b3.CanNang / (b3.ChieuCao * b3.ChieuCao);


            return View();
        }
    }
}