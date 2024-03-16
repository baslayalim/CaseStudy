namespace CaseStudy.Training.DesignPatterns.Behavioral.Strategy
{
    class BehavioralStrategyItem
    {
        private string _upcCode;
        private int _price;

        public BehavioralStrategyItem(string upcCode, int price)
        {
            _upcCode = upcCode;
            _price = price;
        }

        public int GetPrice()
        {
            return _price;
        }
    }
}