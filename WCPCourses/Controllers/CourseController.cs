using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCPCourses.Models;
using WCPCourses.Models.ViewModels;

namespace WCPCourses.Controllers
{
    public class CourseController : Controller
    {
        public static List<CourseViewModel> CourseRegistration = new List<CourseViewModel>
        {
            new CourseViewModel {Id = 1, Title = "Family Planning", Description = "jjf ifji gji fiifj iij "},
            new CourseViewModel {Id = 2, Title = "Reproductive Health", Description = "hfjgijrf rgjr jgirjg  "},
            new CourseViewModel {Id = 3, Title = "My Breast Friend", Description = "uur eiemi eorirmc j frjf afoeei i "}
        };

        public ActionResult Index()
        {
            return View(CourseRegistration);
        }

       
        public ActionResult Course(int id)
        {
            var courseDescriptionPage = CourseRegistration.SingleOrDefault(c => c.Id == id);
            if (courseDescriptionPage == null)
                return RedirectToAction("Index", "Home");

            return View(courseDescriptionPage);
        }
    }
}