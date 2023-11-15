using capstone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace capstone
{
    internal class User : Program
    {
        private string username;
        private string email;
        private string password;
        private string address;
        private string contact;
        private bool isAdmin;

        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Address { get => address; set => address = value; }
        public string Contact { get => contact; set => contact = value; }
        public bool IsAdmin { get => isAdmin; set => isAdmin = value; }

        public User() {}

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public User(string username, string email, string password, string address, string contact, bool isAdmin)
        {
            Username = username;
            Email = email;
            Password = password;
            Address = address;
            Contact = contact;
            IsAdmin = isAdmin;
        }

        public override string ToString()
        {
            return $"{{Username: {username}, Email: {email}, Password: {password}, Address: {address}, Contact Number: {contact}, Is Admin: {isAdmin}}}";
        }
    }
}
