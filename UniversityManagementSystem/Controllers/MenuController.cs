using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagementSystem.Models.Entity;

namespace UniversityManagementSystem.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        UniversityDbEntities1 db=new UniversityDbEntities1();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string username,string password)
        {
            var student=db.Students.SingleOrDefault(s=>s.s_username == username && s.s_password==password);
            var admin=db.Admin.SingleOrDefault(a=>a.a_username==username && a.a_password==password);
            if(student!=null)
            {
                return RedirectToAction("Index", "Student", new
                {
                    name = student.s_name,
                    lastname = student.s_lastname,
                    username = student.s_username,
                    password = student.s_password,
                    email = student.s_email,
                    birthdate = student.s_birthdate.Date

                }) ;
                
            }
            else if(admin!=null)
            {
                return View("~/Views/Admin/Index.cshtml");
            }
            else
            {
                ViewBag.ErrorMessage = "Kullanıcı adı veya şifre hatalı.";
                return View("Index");
            }
           
           
        }

       


    }
}