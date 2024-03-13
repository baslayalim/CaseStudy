namespace CaseStudy.Training.DesignPatterns.Behavioral.Mediator
{
    class ChatRoomMediator : IChatRoomMediator
    {
        private Dictionary<int, User> _userDictionary;

        public ChatRoomMediator()
        {
            _userDictionary = new Dictionary<int, User>();
        }

        public void AddUserInRoom(User user)
        {
            _userDictionary.Add(user.id, user);
        }

        public void SendMessage(string message, int userId)
        {
            User user = _userDictionary[userId];
            user.ReceiveMessage(message);
        }
    }
}
