using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discussion
{
    internal class AccessSpecifiers
    {
        //[Section] Access specifiers
        // Encapsulation is also implemented through the use of access specifiers.
        // An access specifier defines the scope and visibility of a class member.

        // Public access specifier
        // Allows a class to expose its member variables and member functions to other functions and objects.
        // Any public member can be accessed from outside the class.
        public string publicAccess = "public";

        // Private access specifier
        // Allows a class to hide its member variables and member functions from other functions and objects.
        // Only functions of the same class can access its private members.
        // Even an instance of a class cannot access its private members.
        private string privateAccess = "private";

        // Protected access specifier
        // Allows a child class to access the member variables and member functions of its base/parent class.
        // This way it helps in implementing inheritance.
        // Inheritance is one of the four pillars of OOP
        protected string protectedAccess = "protected";

        // Internal access specifier
        // Allows a class to expose its member variables and member functions to other functions and objects in the current assembly.
        // Any member with internal access specifier can be accessed from any class or method defined within the application in which the member is defined.
        internal string internalAccess = "internal";

        // Protected Internal access specificer
        // Allows a class to hide its member variables and member functions from other class objects and functions, except a child class within the same application.
        protected internal string protectedInternalAccess = "protected and internal";



    }
}
