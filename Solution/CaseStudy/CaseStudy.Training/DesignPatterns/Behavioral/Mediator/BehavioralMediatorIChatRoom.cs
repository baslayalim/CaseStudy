namespace CaseStudy.Training.DesignPatterns.Behavioral.Mediator
{
    interface IChatRoomMediator
    {
        void SendMessage(string message, int userId);
        void AddUserInRoom(User user);
    }
}