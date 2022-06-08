using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Demo
{
     class Program
    {
        public static void Main(String[] args)
        {
            List<IVisitorModel> visitors = new List<IVisitorModel>
            {
                new NormalVisitorModel { FirstName = "Kostas", LastName = "Kalogeropoulos" },
                new StudentVisitorModel { FirstName = "Tom", LastName = "Storm" },
                new UnderageVisitorModel { FirstName = "Nancy", LastName = "Roman" }
            };

            List<TicketModel> tickets = new List<TicketModel>();
           

            foreach (var person in visitors)
            {
                tickets.Add(person.TicketProcessor.CreateTicket(person));
            }

            foreach (var emp in tickets)
            {
                Console.WriteLine($"{ emp.FirstName } { emp.LastName }: { emp.EmailAddress } hasUnderageDiscount: { emp.hasUnderageDiscount } hasStudentDiscount: { emp.hasStudentDiscount     }");
            }

            Console.ReadLine();
        }
    }
}
