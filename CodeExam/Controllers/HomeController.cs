using CodeExam.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CodeExam.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

       
    }
}
