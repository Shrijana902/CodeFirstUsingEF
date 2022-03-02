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
                int data = context.Database.ExecuteSqlRaw("Insert into Students(Name) values('Hary')");
                Console.WriteLine(data);






            }



        }


    }
}

