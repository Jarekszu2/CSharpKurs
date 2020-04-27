using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construktors
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person(2, "Monika");
            Person person3 = new Person(3, "Nika", "Ika");
            Person person4 = new Person(4, "Jan", "Janek", "Gdańsk", 21, "M");
        }
    }
}
