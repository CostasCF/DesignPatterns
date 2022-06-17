﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_Demo
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Circle::draw() method.");
        }
    }
}
