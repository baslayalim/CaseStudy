namespace CaseStudy.Training.DesignPatterns.Behavioral.State
{
    class BehavioralStateDeliveryState : BehavioralStateVendingMachineState
    {
        public override void HandleState(BehavioralStateVendingMachine context)
        {
            Console.WriteLine("DeliveryState: Kebap Hazır Masaya Geldi");
            context.SetState(new BehavioralStateWaitingState());
        }
    }
}