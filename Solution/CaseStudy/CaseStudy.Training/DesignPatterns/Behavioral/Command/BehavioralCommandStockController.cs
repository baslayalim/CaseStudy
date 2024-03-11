namespace CaseStudy.Training.DesignPatterns.Behavioral.Command
{
    class BehavioralCommandStockController
    {
        private List<BehavioralCommandIOrderCommand> _orderCommands;

        public BehavioralCommandStockController()
        {
            _orderCommands = new List<BehavioralCommandIOrderCommand>();
        }

        public void TakeOrder(BehavioralCommandIOrderCommand command)
        {
            _orderCommands.Add(command);
        }

        public void PlaceOrders()
        {
            foreach (BehavioralCommandIOrderCommand command in _orderCommands)
            {
                command.Execute();
            }

            _orderCommands.Clear();
        }
    }
}
