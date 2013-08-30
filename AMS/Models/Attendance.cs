using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AMS.Models
{
    public class Attendance : Entity
    {
        public int StudentId { get; set; }
        public bool IsPresent { get; set; }

        //Foregin Keys
        public virtual Student Student { get; set; }
    }
}