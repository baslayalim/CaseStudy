namespace CaseStudy.Training.DesignPatterns.Behavioral.Strategy
{
    internal class BehavioralStrategy
    {
        public static void Strategy() 
        {
            BehavioralStrategyShoppingCart shoppingCart = new BehavioralStrategyShoppingCart();
            shoppingCart.AddItem(new BehavioralStrategyItem("4200420042001", 80));
            shoppingCart.AddItem(new BehavioralStrategyItem("3400340034001", 20));

            shoppingCart.SetPaymentMethod(new BehavioralStrategyPaypalPayment("casestudy@desingpatern.com", "Password4242"));
            shoppingCart.Pay();

            shoppingCart.SetPaymentMethod(new BehavioralStrategyCreditCartPayment("Şemsi Tebrîzî", "42845416541642", "422", "12/2042"));
            shoppingCart.Pay();
        }
    }
}