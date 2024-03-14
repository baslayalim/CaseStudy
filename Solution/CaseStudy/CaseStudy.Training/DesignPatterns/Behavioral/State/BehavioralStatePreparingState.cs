namespace CaseStudy.Training.DesignPatterns.Behavioral.State
{
    class BehavioralStatePreparingState : BehavioralStateVendingMachineState
    {
        public override void HandleState(BehavioralStateVendingMachine context)
        {
            Console.WriteLine("PreparingState: Kebap Fırında. Lütfen bekleyiniz");
            context.SetState(new BehavioralStateDeliveryState());
        }
    }
}
