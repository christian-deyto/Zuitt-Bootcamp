using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity
{
    internal class User
    {
        private string name;
        private string joinDate;
        private bool isAdmin;

        public User() { }

        public User(string name, string joinDate, bool isAdmin)
        {
            this.Name = name;
            this.JoinDate = joinDate;
            this.IsAdmin = isAdmin;
        }

        public string Name { get => name; set => name = value; }
        public string JoinDate { get => joinDate; set => joinDate = value; }
        public bool IsAdmin { get => isAdmin; set => isAdmin = value; }

        
    }
}
