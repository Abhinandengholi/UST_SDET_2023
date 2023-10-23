using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Person
    {
        private string? firstname;
        private string? lastname;
        private int? age;

        public Person(string? firstname, string? lastname, int? age)
        {
           Firstname = firstname;
            Lastname = lastname;
           Age = age;
        }

        public string? Firstname { get => firstname; set => firstname = value; }
        public string? Lastname { get => lastname; set => lastname = value; }
        public int? Age { get => age; 
            set {
                if (value <= 100 && 18<=value)age=value;
                else Console.WriteLine("Age limit is not in the range");

            } }
    }
}
