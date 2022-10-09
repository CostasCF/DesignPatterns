using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Demo
{
    public class StudentTickets : ITickets
    {
        public TicketModel CreateTicket(IVisitorModel person)
        {
            TicketModel output = new TicketModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{ person.FirstName.Substring(0, 1) }{person.LastName}@gmail.com";
            
            output.hasStudentDiscount = true;
           
            return output;
        }
    }
}
