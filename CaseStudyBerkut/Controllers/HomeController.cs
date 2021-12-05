using CaseStudyBerkut.Models;
using CaseStudyBerkut.Models.AppDBContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CaseStudyBerkut.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDBContext _db;

        public HomeController(AppDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Users> usersList = _db.User.ToList();

            return View(usersList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}
