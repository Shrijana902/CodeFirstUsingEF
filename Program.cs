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
                var data = from s in context.Students
                                where s .StudentId==6
                                select new {
                                    name=s.Name
                                };
                    
                foreach (var item in data)
                {
                    Console.WriteLine(item.name);
                }

            }



        }


    }
}

