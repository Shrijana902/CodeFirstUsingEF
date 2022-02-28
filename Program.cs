using System;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstDemo
{
    public class Program:DbContext
    {
         static void Main(string[] args)
        {
            // IList<Student> newStudents = new List<Student>() {
            //                         new Student() { Name = "Steve" },
            //                         new Student() { Name = "Bill" },
            //                         new Student() { Name = "James" }
            //                     };
            //  IList<Course> newcourses = new List<Course>() {
            //                         new Course() { CourseName = "c" },
            //                         new Course() { CourseName = "VB" },
            //                          new Course() { CourseName = "C+" }
            //                     };
             using(var context = new SchoolContext())
             {
             
            //     context.Students.AddRange(newStudents);
            //     context.Courses.AddRange(newcourses);
            //     context.SaveChanges();
                var student=from s in context.Students
                            orderby s.Name descending
                            select s;
                foreach(var groupItem in student)
                {
                    Console.WriteLine(groupItem.Name);
                    
                
                    
                }
                
                

            }
            
        
        }
    }
}
