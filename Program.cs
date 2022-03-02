using System;
using Microsoft.EntityFrameworkCore;


namespace CodeFirstDemo
{
    public class Program
    {
        static void Main(string[] args)
        {

            using (var context = new SchoolContext())
            {
                var data = context.Students.FromSqlRaw("SELECT * FROM Students").ToList<Student>();
                foreach (var obj in data)
                {
                    Console.WriteLine(obj.Name);
                }






            }



        }


    }
}

