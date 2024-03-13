namespace CaseStudy.Training.DesignPatterns.Behavioral.Mediator
{
    abstract class User
    {
        public int id;
        public string name;

        private IChatRoomMediator _chatRoomMediator;

        public User(IChatRoomMediator chatRoomMediator)
        {
            _chatRoomMediator = chatRoomMediator;
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"{name} Yeni Mesaj Aldı. İleti: {message}");
        }

        public void SendMessage(string message, int userId)
        {
            Console.WriteLine($"{name} Yeni Mesaj Gönderdi : Kullanıcı {userId}");
            _chatRoomMediator.SendMessage(message, userId);
        }
    }
}