namespace CaseStudy.Training.DesignPatterns.Behavioral.Command
{
    internal class BehavioralCommand
    {
        public static void Command() 
        {
            BehavioralCommandStockManager stockManager = new BehavioralCommandStockManager("Bebek Doğum Paketi", 33000);

            BehavioralCommandBuyStock buyStock = new BehavioralCommandBuyStock(stockManager);
            BehavioralCommandSellStock sellStock = new BehavioralCommandSellStock(stockManager);

            BehavioralCommandStockController stockController = new BehavioralCommandStockController();

            stockController.TakeOrder(buyStock);
            stockController.TakeOrder(sellStock);
            stockController.TakeOrder(sellStock);

            stockController.PlaceOrders();
        }
    }
}
