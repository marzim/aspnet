﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersitentUniversity.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string EmailAddress { get; set; }
        public string ContactNumber { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }


}