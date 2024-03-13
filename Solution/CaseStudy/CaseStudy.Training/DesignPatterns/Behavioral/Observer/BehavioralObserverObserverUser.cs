namespace CaseStudy.Training.DesignPatterns.Behavioral.Observer
{
    class BehavioralObserverObserverUser : BehavioralObserverIObserverUser
    {
        public void SendNotification(BehavioralObserverProductUpdateMessage message)
        {
            Console.WriteLine(message.ToString());
        }
    }
}