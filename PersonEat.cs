using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartClass
{
    public partial class Person
    {
        public void Eat()
        {
            Console.WriteLine("I am eating");
        }
        partial void Read()
        {
            Console.WriteLine("I am reading a book");
        }
    }

}
