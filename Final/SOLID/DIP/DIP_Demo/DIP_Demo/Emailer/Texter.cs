using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Demo
{
    public class Texter : IMessageSender
    {
        public void SendMessage(IUser user, string message)
        {
            Console.WriteLine($"I am texting { user.FirstName } to say { message }");
        }
    }
}
