using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WCPCourses.Models;
using WCPCourses.Models.DataModels;

namespace WCPCourses.Controllers
{
    public class HomeController : Controller
    {
        public static List<Course> WCPCourses = new List<Course>
            {
                    new Course {  Id = 1, Img = "~/class_fp.jpg", Title = "Family Planning" , Description = "Dolor sit amet, consectetur adipiscing elit. Nunc ante sem, molestie at elit eget, gravida mattis enim. Sed eu justo fermentum, elementum mi at, dignissim odio. Suspendisse at lorem vehicula, ultrices augue non, malesuada leo. Mauris eget elementum eros. Phasellus bibendum eleifend nisi non placerat. Nam consequat enim leo, non pulvinar urna faucibus sed. Sed eget lorem sed enim maximus aliquet nec vitae ipsum. Praesent mi nulla, hendrerit sed nibh id, vestibulum laoreet ligula. Suspendisse ex mi, malesuada et ex eget, feugiat feugiat massa. Maecenas vel lorem non nulla viverra gravida. Etiam non lacinia lacus."},
                    new Course {  Id = 2, Img = "~/class_se.jpg", Title = "Reproductive Health", Description = "Mauris lobortis tincidunt ex vitae venenatis. In venenatis rutrum ultrices. In tempus, dolor a hendrerit tempus, ante lectus faucibus metus, eu aliquam sapien libero ac nisi. Nullam ligula urna, interdum sed porta et, mollis eget augue. Aenean eu ultricies turpis. Sed mollis nisl libero. Ut a justo rutrum, aliquet lacus non, molestie ipsum. Phasellus non sem mi." },
                    new Course {  Id = 3, Img = "~/class_bf.jpg", Title = "My \"Breast\" Friend", Description = "Proin eget cursus risus. Sed tristique massa dolor, eget consectetur sem finibus ut. Donec at ante orci. Donec eget orci sed enim venenatis eleifend. Pellentesque vitae nunc nisl. Integer ullamcorper a quam sed lobortis. Donec vitae nibh ante. Vivamus semper arcu vitae est posuere tincidunt. Maecenas sit amet dictum velit. Cras enim dui, tempor porttitor nisi quis, condimentum aliquam velit. Maecenas nibh lorem, luctus eu cursus sit amet, efficitur at purus."},
            };


        public ActionResult Index()
        {
            return View(WCPCourses);
        }

        public ActionResult Course(int id)
        {
            var course = WCPCourses.SingleOrDefault(c => c.Id == id);
            if (course == null)
                return RedirectToAction("Index");

            return View(course);
        }
    }
}