using CaseStudyBerkut.Models;
using CaseStudyBerkut.Models.AppDBContext;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseStudyBerkut.Controllers
{
    public class UserController : Controller
    {
        private readonly AppDBContext _db;
        
        public UserController(AppDBContext db)
        {
            _db = db;
        }
        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Insert(Users user)
        {
            _db.User.Add(user);
            _db.SaveChanges();
            return Json("kayit islemi basarili!");
        }

        public ActionResult Details(Guid id)
        {
            Users user = _db.User.Find(id);
           
            return View(user);
        }

        public ActionResult Update(Guid id)
        {
            Users user = _db.User.Find(id);
            return View(user);
        }

        [HttpPost]
        public JsonResult Update(Users user)
        {
            _db.User.Update(user);
   
            _db.SaveChanges();
            return Json("Güncelleme işlemi başarılı bir sekilde gerçekleşti");
        }


    }
}
