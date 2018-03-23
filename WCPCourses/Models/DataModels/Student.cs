using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCPCourses.Models.DataModels
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        internal static object SingleOrDefault(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}