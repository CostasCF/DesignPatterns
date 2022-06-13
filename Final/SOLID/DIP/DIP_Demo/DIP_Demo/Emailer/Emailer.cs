using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Demo
{
    public class Emailer : IMessageSender
    {
        public void SendMessage(IUser user, string message)
        {
            Console.WriteLine($"Simulating sending an email to { user.EmailAddress }");
        }
    }
}
