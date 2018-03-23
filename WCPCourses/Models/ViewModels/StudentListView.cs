using System.Collections.Generic;
using WCPCourses.Models.DataModels;

namespace WCPCourses.Models
{
    public class StudentListView
    {
        public List<StudentView> Students { get; set; }
        public int TotalStudents { get; set; }
    }
}
