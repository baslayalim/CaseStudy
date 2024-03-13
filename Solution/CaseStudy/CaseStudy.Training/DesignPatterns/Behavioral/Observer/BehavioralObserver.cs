namespace CaseStudy.Training.DesignPatterns.Behavioral.Observer
{
    internal class BehavioralObserver
    {
        public static void Observer() 
        {
            BehavioralObserverIObserverUser recep = new BehavioralObserverObserverUser();
            BehavioralObserverIObserverUser saban = new BehavioralObserverObserverUser();
            BehavioralObserverIObserverUser ramazan = new BehavioralObserverObserverUser();
            BehavioralObserverIObserverUser bayram = new BehavioralObserverObserverUser();

            BehavioralObserverEtliekmek etliekmek = new BehavioralObserverEtliekmek();

            etliekmek.AddObserver(recep);
            etliekmek.AddObserver(saban);
            etliekmek.AddObserver(ramazan);
            etliekmek.AddObserver(bayram);

            etliekmek.ChangePrice();
        }
    }
}