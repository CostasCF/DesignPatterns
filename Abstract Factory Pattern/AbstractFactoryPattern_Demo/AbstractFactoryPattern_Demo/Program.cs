using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_Demo
{
    public class Program
    {
        public static void Main()
        {
            //get shape factory
            AbstractFactory shapeFactory = FactoryProducer.getFactory(false);
            //get an object of Shape Rectangle
            IShape shape1 = shapeFactory.GetShape("RECTANGLE");
            //call draw method of Shape Rectangle
            shape1.Draw();
            //get an object of Shape Square 
            IShape shape2 = shapeFactory.GetShape("SQUARE");
            //call draw method of Shape Square
            shape2.Draw();
            //get shape factory
            AbstractFactory shapeFactory1 = FactoryProducer.getFactory(true);
            //get an object of Shape Rectangle
            IShape shape3 = shapeFactory1.GetShape("RECTANGLE");
            //call draw method of Shape Rectangle
            shape3.Draw();
            //get an object of Shape Square 
            IShape shape4 = shapeFactory1.GetShape("SQUARE");
            //call draw method of Shape Square
            shape4.Draw();
            Console.ReadLine();
        }
    }
}
