using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discussion
{
    internal class OrderByThenBy
    {
        public void OrderByOperator()
        {
            var courses = CourseDatabase.GetCoursesData();

            //method based
            //var data = courses.OrderBy(c => c.Price);

            //query based
            var data = from c in courses orderby c.Price select c;

            foreach (var item in data) 
            {
                Console.WriteLine($"{item.Name} - P{item.Price} - {item.Author}");
            }

        }

        public void ThenByOperator()
        {
            var courses = CourseDatabase.GetCoursesData();

            //method based
            //var data = courses.OrderBy(c => c.Price).ThenByDescending(a => a.Author);

            //query based
            var data = from c in courses orderby c.Price, c.Author descending select c;

            foreach (var item in data)
            {
                Console.WriteLine($"{item.Name} - P{item.Price} - {item.Author}");
            }
        }
        

    }
}
