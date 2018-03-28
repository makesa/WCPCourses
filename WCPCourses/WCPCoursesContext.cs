using WCPCourses.Models.DataModels;
using System.Data.Entity;

namespace WCPCourses
{
    public class WCPCoursesContext : DbContext
    {
        public WCPCoursesContext() : base("name=WCPCoursesContext") { }

        public virtual DbSet<Student> Students { get; set; }
    }
}