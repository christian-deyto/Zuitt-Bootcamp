using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity
{
    internal class Regular : User
    {

        public Regular(string name, string joinDate, bool isAdmin)
        {
            Name = name;
            JoinDate = joinDate;
            IsAdmin = isAdmin;
        }

        public Regular() {}
        public void Login() 
        { 
        Console.WriteLine("Purchase today and get a 25% discount on your shipping fee!");
        }

        public void Checkout()
        {
            Console.WriteLine("Please login before you can process your payment.");
        }
    }
}
