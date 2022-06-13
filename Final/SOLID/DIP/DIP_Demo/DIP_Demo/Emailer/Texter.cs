using System;

namespace DIP_Demo
{
    public class Texter : IMessageSender
    {
        public void SendMessage(IUser user, string message)
        {
            Console.WriteLine($"Sending {message} from {user}");
        }
    }
}