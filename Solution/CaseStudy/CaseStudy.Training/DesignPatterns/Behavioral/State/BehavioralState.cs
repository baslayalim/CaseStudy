namespace CaseStudy.Training.DesignPatterns.Behavioral.State
{
    internal class BehavioralState
    {
        public static void State() 
        {
            BehavioralStateVendingMachine vendingMachine = new BehavioralStateVendingMachine();
            vendingMachine.RequestProduct("Konya Fırın Kebabı", 580);
        }
    }
}