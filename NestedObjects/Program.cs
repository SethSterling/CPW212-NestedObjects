using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor ci = new Instructor()
            {
                FullName = "Homer Simp",
                Email = "You@Mail.com"
            };

            Student s1 = new Student
            {
                FirstName = "Seth",
                LastName = "Bud"
            };

            Student s2 = new Student
            {
                FirstName = "Hi",
                LastName = "There"
            };

            Student s3 = new Student
            {
                FirstName = "What",
                LastName = "Up"
            };

            Course testCourse = new Course();
            testCourse.Title = "Cpw 212";
            testCourse.Description = "Hi";
            testCourse.credits = 5;
            testCourse.CourseInstructor = ci;
            testCourse.Roster = new List<Student>();

            testCourse.Roster.Add(s1);
            testCourse.Roster.Add(s2);
            testCourse.Roster.Add(s3);

        }
    }
}
