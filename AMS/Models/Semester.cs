using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AMS.Models
{
    public class Semester : Entity
    {
        public int NumberOfSemesters { get; set; }
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}