using System;
using System.Collections.Generic;
using System.Linq;
 
namespace SF.Module23
{
    class Program
    {
        static void Main()
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };

            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(", ", allStudents));
            Console.ReadKey();
        }

        static string[] GetAllStudents(Classroom[] classes) 
            => classes.Aggregate((c1, c2) => new Classroom { Students = c1.Students.Union(c2.Students).ToList() }).Students.ToArray();

        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}