using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Demo
{
    public static class Factory
    {
        public static IUser CreatePerson()
        {
            return new User();
        }

        public static IEmployeeTask CreateEmployeeTask()
        {
            return new EmployeeTask(CreateLogger(), CreateMessageSender());
        }

        public static ILogger CreateLogger()
        {
            return new Logger();
        }

        public static IMessageSender CreateMessageSender()
        {
            return new Texter();
        }
    }
}
