namespace DIP_Demo
{
    public interface IMessageSender
    {
        void SendMessage(IUser user, string message);
    }
}