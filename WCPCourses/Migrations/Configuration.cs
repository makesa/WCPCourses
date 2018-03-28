using WCPCourses.Models.ViewModels;
using WCPCourses.Models.DataModels;
using System.Data.Entity.Migrations;

namespace WCPCourses.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<WCPCoursesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WCPCoursesContext context)
        {
            context.Students.AddOrUpdate(
                p => p.StudentId,
                new Student { StudentId = 1, LastName = "Halpert", FirstName = "Jim", Email = "JHalpert@TheOffice.com" },
                new Student { StudentId = 2, LastName = "Beesly", FirstName = "Pam", Email = "PBeesley@TheOffice.com" },
                new Student { StudentId = 3, LastName = "Scott", FirstName = "Michael", Email = "@TheOffice.com" },
                new Student { StudentId = 4, LastName = "Schrute", FirstName = "Dwight", Email= "DSchrute@TheOffice.com" },
                new Student { StudentId = 5, LastName = "Martin", FirstName = "Angela", Email = "AMartin@TheOffice.com" },
                new Student { StudentId = 6, LastName = "Bernard", FirstName = "Andy", Email = "ABernard@TheOffice.com" },
                new Student { StudentId = 7, LastName = "Malone", FirstName = "Kevin", Email = "KMalone@TheOffice.com" },
                new Student { StudentId = 8, LastName = "Kapoor", FirstName = "Kelly", Email = "KKapoor@TheOffice.com" },
                new Student { StudentId = 9, LastName = "Palmer", FirstName = "Meredith", Email = "MPalmer@TheOffice.com" },
                new Student { StudentId = 10, LastName = "Flenderson", FirstName = "Toby", Email = "TFlenderson@TheOffice.com" },
                new Student { StudentId = 11, LastName = "Hudson", FirstName = "Stanley", Email = "SHudson@TheOffice.com" },
                new Student { StudentId = 12, LastName = "Bratton", FirstName = "Creed", Email = "CBratton@TheOffice.com" },
                new Student { StudentId = 13, LastName = "Vance", FirstName = "Phyllis", Email = "PVance@TheOffice.com" },
                new Student { StudentId = 14, LastName = "Howard", FirstName = "Ryan", Email = "RHoward@TheOffice.com" },
                new Student { StudentId = 15, LastName = "Philbin", FirstName = "Darryl", Email = "DPhilbin@TheOffice.com" }
            );
        }
    }
}
