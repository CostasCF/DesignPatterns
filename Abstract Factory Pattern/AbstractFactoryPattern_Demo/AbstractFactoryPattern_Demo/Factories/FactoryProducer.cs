using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_Demo
{
    public class FactoryProducer
    {
        /// <summary>
        /// Creates a new factory, either a ShapeFactory or a RoundedShapeFactory, upon user request.
        /// </summary>
        /// <param name="rounded"></param>
        /// <returns>A new factory (ShapeFactory or RoundedShapeFactory)</returns>
        public static AbstractFactory getFactory(bool rounded)
        {
            if (rounded)
            {
                return new RoundedShapeFactory();
            }
            else
            {
                return new ShapeFactory();
            }
        }
    }
}
