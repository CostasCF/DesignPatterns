using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {

            IManager accountingVP = new Manager();

            accountingVP.FirstName = "Emma";
            accountingVP.LastName = "Stone";
            accountingVP.CalculatePerHourRate(4);

            IManager ceo = new CEO();

            ceo.FirstName = "Kostas";
            ceo.LastName = "Kalogeropoulos";
            // emp.AssignManager(accountingVP);
            ceo.CalculatePerHourRate(2);

            IManagerAssigned emp = new Employee();
            emp.FirstName = "Nikos";
            emp.LastName = "Nikopoulos";
            emp.CalculatePerHourRate(1);

            Console.WriteLine($"{ ceo.FirstName }'s salary is ${ ceo.Salary }/hour.");
            Console.WriteLine($"{ emp.FirstName }'s salary is ${ emp.Salary }/hour.");

            Console.ReadLine();

        }
    }
}
