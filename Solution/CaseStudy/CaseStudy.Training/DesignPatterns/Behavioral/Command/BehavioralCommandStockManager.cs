namespace CaseStudy.Training.DesignPatterns.Behavioral.Command
{
    class BehavioralCommandStockManager
    {
        private string _name;
        private int _quantity;

        public BehavioralCommandStockManager(string name, int quantity)
        {
            _name = name;
            _quantity = quantity;
        }

        public void Buy()
        {
            Console.WriteLine($"Ürün : {_name}, {_quantity} Satın Alındı !");
        }

        public void Sell()
        {
            Console.WriteLine($"Ürün : {_name}, {_quantity} Satılmış !");
        }
    }
}
