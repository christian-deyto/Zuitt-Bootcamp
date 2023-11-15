using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity
{
    internal class Premium : User
    {
        public Premium() { }

        public Premium(string name, string joinDate, bool isAdmin)
        {
            Name = name;
            JoinDate = joinDate;
            IsAdmin = isAdmin;
        }

        public void Login()
        {
            Console.WriteLine("View Products online with free shipping!");
        }

        public void Checkout()
        {
            Console.WriteLine("Payment received. Thank you for your purchase!");
        }
    }
}
