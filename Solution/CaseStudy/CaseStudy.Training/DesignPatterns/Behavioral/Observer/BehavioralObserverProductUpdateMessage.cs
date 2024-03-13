namespace CaseStudy.Training.DesignPatterns.Behavioral.Observer
{
    class BehavioralObserverProductUpdateMessage
    {
        public string productName;
        public string message;

        public override string ToString()
        {
            return $"{productName} Fiyatı Güncellendi. {Environment.NewLine} Gönderilek Mesaj : {message}";
        }
    }
}