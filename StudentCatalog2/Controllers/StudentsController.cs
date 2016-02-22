using StudentCatalog2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentCatalog2.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        //action method
        public ActionResult Index()
        {
            return View();
        }

        public string WannaPlayDad()
        {
            return "No, I am coding..";
        }

        public ActionResult MadView()
        {
            //defining Cat property
            ViewBag.Cat = "Miauu, I am a cat";

            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            //if no broken rules, defined in student
            if (ModelState.IsValid)
            {
                ApplicationDbContext db = 
                    new ApplicationDbContext();
                db.Students.Add(student);
                db.SaveChanges();

                return View("Thanks");
            }
            return View();

        }
    }
}