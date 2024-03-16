namespace CaseStudy.Training.DesignPatterns.Behavioral.Strategy
{
    class BehavioralStrategyShoppingCart
    {
        private List<BehavioralStrategyItem> _items;
        private BehavioralStrategyIPayment _payment;

        public BehavioralStrategyShoppingCart()
        {
            _items = new List<BehavioralStrategyItem>();
        }

        public void SetPaymentMethod(BehavioralStrategyIPayment payment)
        {
            _payment = payment;
        }

        public void AddItem(BehavioralStrategyItem item)
        {
            _items.Add(item);
        }

        public int CalculateTotal()
        {
            int sum = 0;
            foreach (BehavioralStrategyItem item in _items)
            {
                sum += item.GetPrice();
            }
            return sum;
        }

        public void Pay()
        {
            int amount = CalculateTotal();
            _payment.Pay(amount);
        }
    }
}