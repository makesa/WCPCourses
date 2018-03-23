using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCPCourses.Models.DataModels
{
    public class Course
    {
        public enum SessionDate
        {
            April,
            May,
            June
        }


        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public SessionDate Session { get; set; }
        public string Url { get; set; }
        public string Img { get; set; }


        
    }
}