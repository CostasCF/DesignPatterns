using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //get an object of Circle and call its draw method.
            IShape circle = ShapeFactory.CreateCircle();

            //call draw method of Circle
            circle.Draw();

            //get an object of Rectangle and call its draw method.
            IShape rectangle = ShapeFactory.CreateRectangle();

            //call draw method of Rectangle
            rectangle.Draw();

            //get an object of Square and call its draw method.
            IShape square = ShapeFactory.CreateSquare();

            //call draw method of square
            square.Draw();

            Console.ReadLine();
        }
    }
}
