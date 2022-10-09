using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Demo
{
    public class UnderageVisitorModel : IVisitorModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ITickets TicketProcessor { get; set; } = new UnderageTickets();

    }
}
