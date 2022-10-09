using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_Demo
{
    public class RoundedShapeFactory : AbstractFactory
    {
        public override IShape GetShape(string shapeType)
        {
                if (shapeType.Equals("RECTANGLE"))
                {
                    return new RoundedRectangle();
                }
                else if (shapeType.Equals("SQUARE"))
                {
                    return new RoundedSquare();
                }
                return null;

        }
    }
}
