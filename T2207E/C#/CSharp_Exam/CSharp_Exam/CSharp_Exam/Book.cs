﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Exam
{
    public class Book : Product
    {
        public Book(string id, string name, double price) : base(id, name, price) { }

        public override double computeTax()
        {
            return Price * 5 / 100;
        }
    }
}
