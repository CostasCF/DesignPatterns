using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_Demo
{
    public class ShapeFactory
    {
        public static IShape CreateSquare()
        {
            return new Square();
        }

        public static IShape CreateCircle()
        {
            return new Circle();
        }
        public static IShape CreateRectangle()
        {
            return new Rectangle();
        }

    }
}
