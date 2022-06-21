using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_Demo
{
    public abstract class AbstractFactory
    {
         public abstract IShape GetShape(String shapeType);

    }
}
