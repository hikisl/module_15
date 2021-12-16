using System;
using System.Collections.Generic;
using System.Linq;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
      {
       new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
       new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
       new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
     };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }

        static string[] GetAllStudents(Classroom[] classes)
        {    //Решение синтаксисом запросов
            //return (from mass in classes
            //        from name in mass.Students
            //        select name).ToArray();
            
            // Решение синтаксисом методов 
            return classes.SelectMany(s => s.Students.Select(p => p)).ToArray();

        }
    }
    
}
