namespace CaseStudy.Training.DesignPatterns.Behavioral.Command
{ 
    class BehavioralCommandSellStock : BehavioralCommandIOrderCommand
    {
        private BehavioralCommandStockManager _stockManager;

        public BehavioralCommandSellStock(BehavioralCommandStockManager stockManager)
        {
            _stockManager = stockManager;
        }

        public void Execute()
        {
            _stockManager.Sell();
        }
    }
}
