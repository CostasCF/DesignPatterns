using System;

namespace LSP_Demo
{
    public class Employee : BaseEmployee, IManagerAssigned
    {
        public IEmployee Manager { get; set; } = null;

        public void AssignManager(IEmployee manager)
        {
            // Simulate doing other tasks here - otherwise, this should be
            // a property set statement, not a method.
            Manager = manager;
        }
    }
}