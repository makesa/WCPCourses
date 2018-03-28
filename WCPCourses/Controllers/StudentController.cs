using WCPCourses.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WCPCourses.Models.DataModels;
using WCPCourses.Models.ViewModels;
    

namespace WCPCourses.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Index()
        {
            using (var wCPCoursesContext = new WCPCoursesContext())
            {
                var studentList = new StudentListView
                {
                    //Convert each Student to a StudentViewModel
                    Students = wCPCoursesContext.Students.Select(s => new StudentView
                    {
                        StudentId = s.StudentId,
                        LastName = s.LastName,
                        FirstName = s.FirstName,
                        Email = s.Email
                    }).ToList()
                };

                studentList.TotalStudents = studentList.Students.Count;

                return View(studentList);
            }
        }

        public ActionResult StudentDetail(int id)
        {
            using (var wCPCoursesContext = new WCPCoursesContext())
            {
                var student = wCPCoursesContext.Students.SingleOrDefault(s => s.StudentId == id);
                if (student != null)
                {
                    var studentView = new StudentView
                    {
                        StudentId = student.StudentId,
                        LastName = student.LastName,
                        FirstName = student.FirstName,
                        Email = student.Email
                };

                    return View(studentView);
                }
            }

            return new HttpNotFoundResult();
        }


        // This section is just for the students to register (Add) only

        public ActionResult StudentRegister()
        {
            var studentView = new StudentView();

            return View("RegisterStudent", studentView);
        }

        [HttpPost]
        public ActionResult RegisterStudent(StudentView studentView)
        {
            using (var wCPCoursesContext = new WCPCoursesContext())
            {
                var student = new Student
                {
                    LastName = studentView.LastName,
                    FirstName = studentView.FirstName,
                    Email = studentView.Email
            };

                wCPCoursesContext.Students.Add(student);
                wCPCoursesContext.SaveChanges();
            }

            return View("Success");
        }


        // This is the Admin section where all CRUD permissions are granted
        /// 
        public ActionResult StudentAdd()
        {
            var studentView = new StudentView();

            return View("AddEditDelete", studentView);
        }

        [HttpPost]
        public ActionResult AddStudent(StudentView studentView)
        {
            using (var wCPCoursesContext = new WCPCoursesContext())
            {
                var student = new Student
                {
                    LastName = studentView.LastName,
                    FirstName = studentView.FirstName,
                    Email = studentView.Email
            };

                wCPCoursesContext.Students.Add(student);
                wCPCoursesContext.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult StudentEdit(int id)
        {
            using (var wCPCoursesContext = new WCPCoursesContext())
            {
                var student = wCPCoursesContext.Students.SingleOrDefault(s => s.StudentId == id);
                if (student != null)
                {
                    var studentView = new StudentView
                    {
                        StudentId = student.StudentId,
                        LastName = student.LastName,
                        FirstName = student.FirstName,
                        Email = student.Email
                    };

                    return View("AddEditDelete", studentView);
                }
            }

            return new HttpNotFoundResult();
        }

        [HttpPost]
        public ActionResult EditStudent(StudentView studentView)
        {
            using (var wCPCoursesContext = new WCPCoursesContext())
            {
                var student = wCPCoursesContext.Students.SingleOrDefault(p => p.StudentId == studentView.StudentId);

                if (student != null)
                {
                    student.LastName = studentView.LastName;
                    student.FirstName = studentView.FirstName;
                    student.Email = studentView.Email;
                    wCPCoursesContext.SaveChanges();

                    return RedirectToAction("Index");
                }
            }

            return new HttpNotFoundResult();
        }

        [HttpPost]
        public ActionResult DeleteStudent(StudentView studentView)
        {
            using (var wCPCoursesContext = new WCPCoursesContext())
            {
                var student = wCPCoursesContext.Students.SingleOrDefault(s => s.StudentId == studentView.StudentId);

                if (student != null)
                {
                    wCPCoursesContext.Students.Remove(student);
                    wCPCoursesContext.SaveChanges();

                    return RedirectToAction("Index");
                }
            }

            return new HttpNotFoundResult();
        }



    }
}



