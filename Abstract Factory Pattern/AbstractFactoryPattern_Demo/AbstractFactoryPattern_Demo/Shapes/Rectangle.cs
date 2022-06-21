﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_Demo
{
    internal class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }
}
