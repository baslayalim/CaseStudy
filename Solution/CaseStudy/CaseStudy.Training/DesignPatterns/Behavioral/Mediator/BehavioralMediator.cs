namespace CaseStudy.Training.DesignPatterns.Behavioral.Mediator
{
    internal class BehavioralMediator
    {
        public static void Mediator() 
        { 
            IChatRoomMediator chatRoom = new ChatRoomMediator();
            User ramazan = new ChatUser(chatRoom);
            ramazan.id = 1;
            ramazan.name = "Ramazan";

            User saban = new ChatUser(chatRoom);
            saban.id = 2;
            saban.name = "Saban";

            User recep = new ChatUser(chatRoom);
            recep.id = 3;
            recep.name = "Recep";

            User bayram = new ChatUser(chatRoom);
            bayram.id = 4;
            bayram.name = "Bayram";

            chatRoom.AddUserInRoom(recep);
            chatRoom.AddUserInRoom(saban);
            chatRoom.AddUserInRoom(ramazan);
            chatRoom.AddUserInRoom(bayram);

            recep.SendMessage("Merhaba !", saban.id);
            ramazan.SendMessage("Nasılsın !", bayram.id);
        }
    }
}