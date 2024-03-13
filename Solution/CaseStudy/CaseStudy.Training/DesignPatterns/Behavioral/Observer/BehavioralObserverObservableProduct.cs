namespace CaseStudy.Training.DesignPatterns.Behavioral.Observer
{
    abstract class BehavioralObserverObservableProduct
    {
        private List<BehavioralObserverIObserverUser> _users;
        protected BehavioralObserverProductUpdateMessage message;

        public BehavioralObserverObservableProduct()
        {
            _users = new List<BehavioralObserverIObserverUser>();
            message = new BehavioralObserverProductUpdateMessage();
        }

        public void AddObserver(BehavioralObserverIObserverUser observerUser)
        {
            _users.Add(observerUser);
        }

        public void RemoveObserver(BehavioralObserverIObserverUser observerUser)
        {
            _users.Remove(observerUser);
        }

        public void NotifyObserver()
        {
            foreach (BehavioralObserverIObserverUser user in _users)
            {
                user.SendNotification(message);
            }
        }
    }
}