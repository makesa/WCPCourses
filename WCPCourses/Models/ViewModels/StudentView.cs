using System.ComponentModel;

namespace WCPCourses.Models
{
    public class StudentView
    {
        public int? StudentId { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Name")]
        public string FullName => FirstName + " " + LastName;
    }
}