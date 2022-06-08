using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Demo
{
    public class TicketModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public bool hasStudentDiscount { get; set; } = false;
        public bool hasUnderageDiscount { get; set; } = false;
    }
}
