using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PersitentUniversity.Models;
using System.Data.Entity;
    

namespace PersitentUniversity.DAL
{
    public class SchoolInitializers : DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            AddStudents(context);
            AddCourses(context);
            AddEnrollments(context);
        }

        private void AddStudents(SchoolContext context)
        {
            var students = new List<Student>
            {
                new Student {FirstName="test1",LastName="lastname1",EnrollmentDate=DateTime.Parse("2001-01-01") },
                new Student {FirstName="test2",LastName="lastname2",EnrollmentDate=DateTime.Parse("2002-01-01") },
                new Student {FirstName="test3",LastName="lastname3",EnrollmentDate=DateTime.Parse("2003-01-01") },
                new Student {FirstName="test4",LastName="lastname4",EnrollmentDate=DateTime.Parse("2004-01-01") },
                new Student {FirstName="test5",LastName="lastname5",EnrollmentDate=DateTime.Parse("2005-01-01") },
                new Student {FirstName="test6",LastName="lastname6",EnrollmentDate=DateTime.Parse("2006-01-01") }
            };
            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
        }

        private void AddCourses(SchoolContext context)
        {
            var courses = new List<Course>
            {
                new Course {CourseId=1001,Title="Math",Credits=3 },
                new Course {CourseId=1002,Title="Physics",Credits=3 },
                new Course {CourseId=1003,Title="Language",Credits=3 },
                new Course {CourseId=1004,Title="Programming",Credits=3 },
                new Course {CourseId=1005,Title="Civics",Credits=3 },
                new Course {CourseId=1006,Title="English",Credits=3 },
                new Course {CourseId=1007,Title="Filipino",Credits=3 }
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
        }

        private void AddEnrollments(SchoolContext context)
        {
            var enrollments = new List<Enrollment>
            {
                new Enrollment {StudentId=1,CourseId=1001,Grade=Grade.A },
                new Enrollment {StudentId=2,CourseId=1002,Grade=Grade.B },
                new Enrollment {StudentId=3,CourseId=1003,Grade=Grade.B },
                new Enrollment {StudentId=4,CourseId=1004,Grade=Grade.C },
                new Enrollment {StudentId=5,CourseId=1005,Grade=Grade.D },
                new Enrollment {StudentId=6,CourseId=1006,Grade=Grade.E },
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}