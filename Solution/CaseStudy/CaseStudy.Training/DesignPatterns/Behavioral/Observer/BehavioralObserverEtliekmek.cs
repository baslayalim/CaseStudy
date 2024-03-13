namespace CaseStudy.Training.DesignPatterns.Behavioral.Observer
{
    class BehavioralObserverEtliekmek : BehavioralObserverObservableProduct
    {
        public void ChangePrice()
        {
            this.message.productName = "Etliekmek";
            this.message.message = "Konyada Etliekmek İndirime Girdi";
            this.NotifyObserver();
        }
    }
}