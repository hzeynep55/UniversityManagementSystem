using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UniversityManagementSystem.Models.Entity;

namespace UniversityManagementSystem.Controllers

{
    public class AdminController : Controller
    {
        // GET: Admin
        UniversityDbEntities1 db = new UniversityDbEntities1();

        public ActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public ActionResult Courses()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddCourse()
        {
            return View();
;       
        } 

        [HttpPost]
        public ActionResult AddCourse(Courses courses)
        {
           db.Courses.Add(courses);
           db.SaveChanges();
           return View();
           
        }
        [HttpGet]
        public ActionResult ListCourse1()
        {
            var courses = db.Courses.Where(c=>c.dep_id==1).ToList();
            return View(courses);
        }

        [HttpGet]
        public ActionResult ListCourse2()
        {
            var courses = db.Courses.Where(c => c.dep_id == 2).ToList();
            return View(courses);
        }

        [HttpGet]
        public ActionResult ListCourse()
        {
            var courses = db.Courses.ToList();
            return View(courses);
        }


        [HttpGet]
        public ActionResult GetUpdate(int? c_id)
        {
            try
            {
                if (c_id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }

                Courses updatecourse = db.Courses.Find(c_id);

                if (updatecourse == null)
                {
                    return HttpNotFound();
                }

                return View("Update", updatecourse);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return View("Error");
            }
        }
        [HttpPost]
        public ActionResult Update(Courses courses)
        {
             try
             {
                 if (ModelState.IsValid)
                 {
                     var updatecourse = db.Courses.Find(courses.c_id);
                     if (updatecourse != null)
                     {
                         updatecourse.c_name = courses.c_name;
                         updatecourse.c_credit = courses.c_credit;
                         updatecourse.c_level = courses.c_level;
                         updatecourse.dep_id = courses.dep_id;
                         updatecourse.c_semester_season = courses.c_semester_season;
                         updatecourse.session = courses.session;
                         updatecourse.inst_id = courses.inst_id;

                         db.SaveChanges();

                        return RedirectToAction("ListCourse");
                    }
                     else
                     {

                         return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                     }
                 }
                 else
                 {

                     return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                 }
             }
             catch (Exception ex)
             {

                 return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
             }
            
        }

        public ActionResult Delete(int? c_id )
        {
            var course = db.Courses.Find(c_id);
            db.Courses.Remove(course); 
            db.SaveChanges();
            
            
          return RedirectToAction("ListCourse1");
            
          
           
            
        
            

        }
    }
}