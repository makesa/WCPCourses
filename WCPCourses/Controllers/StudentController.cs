using WCPCourses.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WCPCourses.Models.DataModels;


namespace WCPCourses.Controllers
{
    public class StudentController : Controller
    {
        public static List<Student> Student = new List<Student>
                {
                    new Student { StudentId = 1, LastName = "Halpert", FirstName = "Jim" },
                    new Student { StudentId = 2, LastName = "Beesly", FirstName = "Pam" },
                    new Student { StudentId = 3, LastName = "Scott", FirstName = "Michael"},
                    new Student { StudentId = 4, LastName = "Schrute", FirstName = "Dwight" },
                    new Student { StudentId = 5, LastName = "Martin", FirstName = "Angela" },
                    new Student { StudentId = 6, LastName = "Bernard", FirstName = "Andy" },
                    new Student { StudentId = 7, LastName = "Malone", FirstName = "Kevin" },
                    new Student { StudentId = 8, LastName = "Kapoor", FirstName = "Kelly" },
                    new Student { StudentId = 9, LastName = "Palmer", FirstName = "Meredith" },
                    new Student { StudentId = 10, LastName = "Flenderson", FirstName = "Toby" },
                    new Student { StudentId = 11, LastName = "Hudson", FirstName = "Stanley" },
                    new Student { StudentId = 12, LastName = "Bratton", FirstName = "Creed" },
                    new Student { StudentId = 13, LastName = "Vance", FirstName = "Phyllis" },
                    new Student { StudentId = 14, LastName = "Howard", FirstName = "Ryan" },
                    new Student { StudentId = 15, LastName = "Philbin", FirstName = "Darryl" }
                };

        public ActionResult Index()
        {
            var studentList = new StudentListView
            {
                Students = Student.Select(p => new StudentView
                {
                    StudentId = p.StudentId,
                    LastName = p.LastName,
                    FirstName = p.FirstName
                }).ToList()
            };

            studentList.TotalStudents = studentList.Students.Count;

            return View(studentList);
        }

        public ActionResult StudentDetail(int id)
        {
            var student = Student.SingleOrDefault(s => s.StudentId == id);
            if (student != null)
            {
                var studentView = new StudentView
                {
                    StudentId = student.StudentId,
                    LastName = student.LastName,
                    FirstName = student.FirstName
                };

                return View(studentView);
            }

            return new HttpNotFoundResult();
        }

        public ActionResult StudentAdd()
        {
            var studentView = new StudentView();

            return View("AddStudent", studentView);
        }

        [HttpPost]
        public ActionResult AddStudent(StudentView studentView)
        {
            var nextStudentId = Student.Max(s => s.StudentId) + 1;
                    
            var student = new Student
            {
                StudentId = nextStudentId,
                LastName = studentView.LastName,
                FirstName = studentView.FirstName
            };

            Student.Add(student);

            return RedirectToAction("Index");
        }

    }
}



