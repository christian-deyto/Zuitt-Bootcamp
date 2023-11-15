using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace discussion
{
    internal class User
    {
        private string username;
        private readonly string email;
        private string password;
        private string address;
        private string contact;



        public string Username { get => username; set => username = value; }

        public string Email => email;

        public string Password { get => password; set => password = value; }
        public string Address { get => address; set => address = value; }
        public string Contact { get => contact; set => contact = value; }

        public User()
        {

        }

        public User(string username, string email, string password, string address, string contact)
        {
            this.username = username;
            this.email = email;
            this.password = password;
            this.address = address;
            this.contact = contact;
        }

        public override string ToString()
        {
            return $"{{Username: {username}, Email: {email}, Password: {password}, Address: {address}, Contact Number: {contact}}}";
        }

    }
}
