using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discussion
{
    internal class Select
    {
        public void SelectOperator()
        {
            var courses = CourseDatabase.GetCoursesData();


            //[SECTION] Method Based Syntax
                // The Select operator is used for selecting a particular property out of an object.
            //var data = courses.Select(c => c.Author);


            //[SECTION] Query Based Syntax
            var data = from c in courses select c.Author;

            foreach(var item in data)
            {
                Console.WriteLine(item);
            }

        }

        public void SelectNameAndPrice() 
        {
            var courses = CourseDatabase.GetCoursesData();

            //method based
            /* var data = courses.Select(c => new
              { 
                 CourseName = c.Name,
                 CoursePrice = c.Price
              });*/

            //query based

            /*var data = from c in courses select new
            {
                CourseName = c.Name,
                CoursePrice = c.Price,
            };*/

            //Using Tuples
                //Tuples provide a concise syntax to group multiple data elements in a lightweight data structure.
                //We can work with the return tuple instance directly or deconstruct it in separate variables.

            var data = courses.Select(c => (CourseName: c.Name, CoursePrice: c.Price)).ToList();

            foreach(var item in data) 
            {
                Console.WriteLine($"{item.CourseName} - P{item.CoursePrice}");
            }
        }



    }
}
