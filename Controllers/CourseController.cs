using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;
using System.Web.Mvc;
using WebAppCourse.Models;

namespace WebAppCourse.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        static List<Course> courses = new List<Course>()
        {
            new Course{CId=1,CName="DotNet",CFee=100,Technology="LMS",CStartDate=new DateTime(day:1,month:11,year:2022),CEndDate=new DateTime(day:2,month:12,year:2022)},
            new Course{CId=2,CName="Testing",CFee=200,Technology="Canva",CStartDate=new DateTime(day:12,month:1,year:2023),CEndDate=new DateTime(day:22,month:05,year:2023) },
            new Course{CId=3,CName="Java",CFee=400,Technology="Microsoft Teams",CStartDate=new DateTime(day:11,month:07,year:2022),CEndDate=new DateTime(day:28,month:08,year:2022) },
            new Course{CId=4,CName="SQL",CFee=500,Technology="edx",CStartDate=new DateTime(day:17,month:02,year:2024),CEndDate=new DateTime(day:20,month:05,year:2024) },
            new Course{CId=5,CName="Cloud",CFee=700,Technology="Vimeo",CStartDate=new DateTime(day:20,month:04,year:2021),CEndDate=new DateTime(day:19,month:10,year:2021) },
            new Course{CId=6,CName="Mainframe",CFee=900,Technology="quizlet",CStartDate=new DateTime(day:21,month:11,year:2020),CEndDate=new DateTime(day:21,month:12,year:2020) }
        };
        public ActionResult Index()
        {
            return View(courses);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Course());
        }
        [HttpPost]
        public ActionResult Create(Course cu)
        {
            if (ModelState.IsValid)
            {
                courses.Add(cu);
                return RedirectToAction("Index");
            }
            return View(cu);
        }
    
    }
}