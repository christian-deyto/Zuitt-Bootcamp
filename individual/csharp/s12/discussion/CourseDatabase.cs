using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace discussion
{
    internal class CourseDatabase
    {
        public static IEnumerable<Course> GetCoursesData()
        {
            return new List<Course>
            {
                new Course(102, "HTML & CSS", 10000, "Asami Sato"),
                new Course(117, "JavaScript with Express.js", 12000, "Asami Sato"),
                new Course(764, "Backend API with Node.js", 15000, "Mako Imawatsu"),
                new Course(789, "Data Analysis with Python", 17000, "Lin Beifong"),
                new Course(521, "PHP with Laravel Framework", 15000, "Mako Imawatsu"),
                new Course(309, "Ruby on Rails Development", 12000, "Iknik Varrick"),
                new Course(471, "Django with React.js", 20000, "Bolin Imawatsu"),
            };
        }
    }
}
