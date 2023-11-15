using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity
{
    internal class Admin : User
    {
        public Admin() { }

        public Admin(string name, string joinDate, bool isAdmin)
        {
            Name = name;
            JoinDate = joinDate;
            IsAdmin = isAdmin;
        }

        public void addProduct()
        {
            Console.WriteLine($"{Name} just added another product");
        }
    }
}
