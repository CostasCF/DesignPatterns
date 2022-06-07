using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Demo
{
    public class RandomIDGenerator
    {
        public static void createID(User user)
        {

            //create an random ID for a user
            string ID = Guid.NewGuid().ToString();
            Console.WriteLine("Random ID for " + user.FirstName +" " + user.LastName + " is " + ID);

        }
    }
}
