using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AMS.Models
{
    public class Teacher : Person
    {
        public int CourseId { get; set; }
        public virtual Course Courses { get; set; }
    }
}
