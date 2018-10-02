using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUni.Models;

namespace ContosoUni.Data
{
    public class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();
            //look for any student
            if (context.Students.Any())
            {
                return;
            }

            var students = new Student[]
            {
                new Student{FirstMidName="Samuel", LastName="Aronu", EnrollmentDate=DateTime.Parse("2018-10-01")}, 
                new Student{FirstMidName="Deborah", LastName="Aronu", EnrollmentDate=DateTime.Parse("2018-10-01")}, 
                new Student{FirstMidName="Ebuka", LastName="Onyekwere", EnrollmentDate=DateTime.Parse("2018-10-01")}, 
                new Student{FirstMidName="Tanya", LastName="Eneye", EnrollmentDate=DateTime.Parse("2018-10-01")}, 
            };

            foreach (Student s in students)
            {
                context.Students.Add(s);
            }

            context.SaveChanges();

            var courses = new Course[]
            {
                new Course() {CourseID = 1050, Title = "Chemistry", Credits = 3},
                new Course() {CourseID = 1051, Title = "Physics", Credits = 3},
                new Course() {CourseID = 1052, Title = "Biology", Credits = 3},
                new Course() {CourseID = 1053, Title = "Technical drawing", Credits = 3},
                new Course() {CourseID = 1054, Title = "Computer Sciences", Credits = 3},
            };

            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment {StudentID = 1, CourseID = 1050, Grade = Grade.A},
                new Enrollment {StudentID = 2, CourseID = 1051, Grade = Grade.A},
                new Enrollment {StudentID = 2, CourseID = 1052, Grade = Grade.B},
                new Enrollment {StudentID = 4, CourseID = 1052, Grade = Grade.C},
                new Enrollment {StudentID = 3, CourseID = 1053, Grade = Grade.F},
            };

            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }

            context.SaveChanges();

        }
    }
}
