using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discussion
{
    internal class Where
    {
        public void WhereOperator()
        {
            var courses = CourseDatabase.GetCoursesData();

            //method based
            //var data = courses.Where(c => c.Price < 15000);

            //query based
            var data = from c in courses where c.Price < 18000 select c;

            foreach(var item in data)
            {
                Console.WriteLine($"{item.Name} - P{item.Price}");
            }

        }
    }
}
