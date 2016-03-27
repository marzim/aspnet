using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PersitentUniversity.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PersitentUniversity.DAL
{
    public class SchoolContext : DbContext
    {
        public SchoolContext()
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        
    }
}