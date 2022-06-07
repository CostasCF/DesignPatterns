using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            User user = UserDataCapture.Capture();

            bool isUserValid = UserValidator.Validate(user);

            if (isUserValid == false)
            {
                StandardMessages.EndApplication();
                return;
            }

            RandomIDGenerator.CreateID(user);

            StandardMessages.EndApplication();
        }
    }
 
}
