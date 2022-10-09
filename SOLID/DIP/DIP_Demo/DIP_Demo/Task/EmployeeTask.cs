using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Demo
{
    public class EmployeeTask : IEmployeeTask
    { 
        public ILogger _logger { get; set; }
        public IMessageSender _messageSender { get; set; }

        public string TaskName { get; set; }
        public IUser User { get; set; }
        public double HoursWorked { get; private set; }
        public bool IsComplete { get; private set; }
        public EmployeeTask(ILogger logger, IMessageSender messageSender)
        {
            this._logger = logger;
            this._messageSender = messageSender;
        }

        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            _logger.Log($"Performed work on { TaskName }");
        }

        public void CompleteTask()
        {
            IsComplete = true;
      
            _logger.Log($"Completed { TaskName }");
      
            _messageSender.SendMessage(User, $"The task { TaskName } is complete.");
        }
    }
}
