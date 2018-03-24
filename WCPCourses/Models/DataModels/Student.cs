using System;

namespace WCPCourses.Models.DataModels
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public string FullName => FirstName + " " + LastName;

        internal static object SingleOrDefault(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}