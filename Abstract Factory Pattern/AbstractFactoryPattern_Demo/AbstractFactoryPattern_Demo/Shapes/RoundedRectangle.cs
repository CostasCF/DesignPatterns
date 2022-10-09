using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_Demo
{
    public class RoundedRectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside RoundedRectangle::draw() method.");
        }
    }
}
