namespace OCP_Demo
{
    public interface IVisitorModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        ITickets TicketProcessor { get; set; }

    }
} 