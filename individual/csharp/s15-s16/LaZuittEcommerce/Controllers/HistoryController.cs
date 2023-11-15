using LaZuittEcommerce.Data;
using LaZuittEcommerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace LaZuittEcommerce.Controllers
{
    public class HistoryController : Controller
    {

        private readonly LaZuittContext _context;

        public HistoryController(LaZuittContext context)
        {
            _context = context;
        }



        public IActionResult Index()
        {
            List<OrderHistory> historyModel = new List<OrderHistory>();

            var orderHistory = (from ec in _context.EnrollCourses 
                                
                                join c in _context.Course on ec.CourseId equals c.Id
                                join s in _context.Student on ec.EnrollId equals s.Id
                                join e in _context.Enroll on ec.EnrollId equals e.Id

                                select new
                                {
                                    Id = ec.EnrollId,
                                    FullName = s.FirstName + " " + s.LastName,
                                    Billing = s.BillingAddress,
                                    DateEnrolled = e.EnrollDate,
                                    Title = c.Title,
                                    Description = c.Description,
                                    Price = c.Price,
                                    Quantity = c.Quantity,

                                }).ToList();

            foreach (var item in orderHistory)
            {
                historyModel.Add(new OrderHistory()
                {
                    Id = item.Id,
                    FullName = item.FullName,
                    Billing = item.Billing,
                    DateEnrolled = item.DateEnrolled,
                    Title = item.Title,
                    Description = item.Description,
                    Price = item.Price,
                    Quantity = item.Quantity
                });
            }
                

            return View(historyModel);
        }
    }
}
