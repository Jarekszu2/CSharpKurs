using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construktors
{
    class Person
    {
        int id;
        string firstName;
        string lastName;
        string address;
        int age;
        string gender;

        public Person()
        {
            id = 1;
            firstName = "Jarek";
            age = 36;
        }

        public Person(int id, string firstName, string lastName, string address, int age, string gender)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.age = age;
            this.gender = gender;
        }

        public Person(int id, string firstName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = "Elbląg";
            this.age = 32;
        }

        public Person(int id, string firstName)
        {
            this.id = id;
            this.firstName = firstName;
        }
    }
}
