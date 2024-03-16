namespace CaseStudy.Training.DesignPatterns.Behavioral.Strategy
{ 
    class BehavioralStrategyCreditCartPayment : BehavioralStrategyIPayment
    {
        private string _name;
        private string _cardNumber;
        private string _cvv;
        private string _dateOfExpiry;

        public BehavioralStrategyCreditCartPayment(string name, string ccNum, string cvv, string expiryDate)
        {
            _name = name;
            _cardNumber = ccNum;
            _cvv = cvv;
            _dateOfExpiry = expiryDate;
        }

        public void Pay(int amount)
        {
            Console.WriteLine($" {_name} CaseStudy Projesinde Kredi Kartı İle Ödeme Gerçekleştirildi ");
        }
    }
}