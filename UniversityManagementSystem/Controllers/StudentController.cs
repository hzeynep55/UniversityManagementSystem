using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using UniversityManagementSystem.Models.Entity;

namespace UniversityManagementSystem.Controllers
{
    
    public class StudentController : Controller
    {
        UniversityDbEntities1 db = new UniversityDbEntities1();
        // GET: Student

        public ActionResult Index(string name, string lastname, string username, string email, DateTime? birthdate)
        {
            ViewBag.name = name;
            ViewBag.lastname = lastname;
            ViewBag.username = username;
            ViewBag.email = email;
            ViewBag.birthdate = birthdate.HasValue ? birthdate.Value.Date : DateTime.Now.Date;
            return View();
        }

        public ActionResult Account(string name, string lastname, string username,string email,DateTime? birthdate=null)
        {
            ViewBag.name = name;
            ViewBag.lastname = lastname;
            ViewBag.username = username;
            ViewBag.email = email;
            ViewBag.birthdate = birthdate.HasValue ? birthdate.Value.Date : DateTime.Now.Date;

            return View();
        }
    }
}