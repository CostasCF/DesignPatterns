namespace DIP_Demo
{
    public interface IEmployeeTask
    {
        double HoursWorked { get; }
        bool IsComplete { get; }
        string TaskName { get; set; }
        IUser User { get; set; }

        void CompleteTask();
        void PerformedWork(double hours);
    }
}