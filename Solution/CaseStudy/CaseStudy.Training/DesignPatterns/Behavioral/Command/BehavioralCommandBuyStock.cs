namespace CaseStudy.Training.DesignPatterns.Behavioral.Command
{ 
    class BehavioralCommandBuyStock : BehavioralCommandIOrderCommand
    {
        private BehavioralCommandStockManager _stockManager;

        public BehavioralCommandBuyStock(BehavioralCommandStockManager stockManager)
        {
            _stockManager = stockManager;
        }

        public void Execute()
        {
            _stockManager.Buy();
        }
    }
}
