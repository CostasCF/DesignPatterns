using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Demo
{
     class Program
    {
        static void Main(string[] args)
        {

            IUser user = Factory.CreatePerson();
            user.FirstName = "Konstantinos";
            user.LastName = "Kalogeropoulos";
            user.EmailAddress = "KKalogeropoulos@gmail.com";
            user.PhoneNumber = "6973901735";

            IEmployeeTask task = Factory.CreateEmployeeTask();
            task.TaskName = "Take out the trash";
            task.User = user;

            task.PerformedWork(3);
            task.PerformedWork(1.5);
            task.CompleteTask();

            Console.ReadLine();
        }
    }
}
