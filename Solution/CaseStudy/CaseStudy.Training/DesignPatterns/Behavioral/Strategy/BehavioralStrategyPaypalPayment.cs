namespace CaseStudy.Training.DesignPatterns.Behavioral.Strategy
{
    class BehavioralStrategyPaypalPayment : BehavioralStrategyIPayment
    {
        private string _email;
        private string _password;

        public BehavioralStrategyPaypalPayment(string email, string password)
        {
            _email = email;
            _password = password;
        }

        public void Pay(int amount)
        {
            Console.WriteLine($" {_email} CaseStudy Projesinde Paypal İle Ödeme Gerçekleştirildi");
        }
    }
}