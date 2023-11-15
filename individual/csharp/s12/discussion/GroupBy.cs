using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discussion
{
    internal class GroupBy
    {
        public void GroupByOperator()
        {
            var courses = CourseDatabase.GetCoursesData();

            var data = courses.GroupBy(c => c.Author);

            foreach ( var item in data)
            {
                Console.WriteLine(item.Key);
            }
        }

        public void NewListGroupByOperator()
        {
            var courses = CourseDatabase.GetCoursesData();

            //method based
            /*var data = courses.GroupBy(c => c.Author).Select(g => new
            {
                Author = g.Key,
                CourseCount = g.Count()
            });*/

            var data = from c in courses group c by c.Author into g select new
            {
                Author = g.Key,
                CourseCount = g.Count()
            };

            foreach ( var item in data)
            {
                Console.WriteLine($"{item.Author} - {item.CourseCount}");
            }
        }

        public void MoreGroupyBySample()
        {
            var courses = CourseDatabase.GetCoursesData();

            var data = courses.Where(c => c.Price >= 15000).GroupBy(c => c.Author).Select(g => new
            {
                Author = g.Key,
                Prices = g.Select(price => price.Price),
                Courses = g.Select(course => course.Name)
            }).OrderByDescending(a => a.Author);

            foreach (var item in data)
            {
                Console.WriteLine(item.Author);

                foreach(var course in item.Courses)
                {
                    foreach(var price in item.Prices)
                    {
                        Console.WriteLine($"{course} - P{price}");
                    }
                }
            }
        }


    }
}
