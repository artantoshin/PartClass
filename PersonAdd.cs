﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartClass
{
    public partial class Person
    {
        public void Move()
        {
            Console.WriteLine("I am moving Привет");
        }
        partial void Read();
        public void DoSomething()
        {
            Read();
        }
    }
}
