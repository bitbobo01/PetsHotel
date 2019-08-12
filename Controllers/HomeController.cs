using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using PetsHotel.Models;
using Microsoft.AspNetCore.Mvc;

namespace PetsHotel.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Dashboard");
        }
        [Route("trang-chu")]
        public IActionResult Dashboard()
        {
            return View();
        }
        [Route("lien-he")]
        public IActionResult Contact()
        {
            return View();
        }
        [Route("thong-tin")]
        public IActionResult About()
        {
            return View();
        }
        /*[Route("error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/
    }
}
