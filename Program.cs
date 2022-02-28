using System;
namespace CodeFirstDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IList<Student> newStudents = new List<Student>() {
                                    new Student() { Name = "Steve" },
                                    new Student() { Name = "Bill" },
                                    new Student() { Name = "James" }
                                };
             IList<Course> newcourses = new List<Course>() {
                                    new Course() { CourseName = "c" },
                                    new Course() { CourseName = "VB" },
                                     new Course() { CourseName = "C+" }
                                };
            using (var context = new SchoolContext())
            {
                context.Students.AddRange(newStudents);
                context.Courses.AddRange(newcourses);
                context.SaveChanges();
                
                

            }
            
        
        }
    }
}