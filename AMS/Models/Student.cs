using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AMS.Models
{
    public class Student : Person
    {
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
