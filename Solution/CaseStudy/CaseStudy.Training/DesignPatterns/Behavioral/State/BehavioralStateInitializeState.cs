namespace CaseStudy.Training.DesignPatterns.Behavioral.State
{
    class BehavioralStateInitializeState : BehavioralStateVendingMachineState
    {
        public override void HandleState(BehavioralStateVendingMachine context)
        {
            Console.WriteLine("InitializeState : Kebap Hazırlanıyor Malzemeler Alınıyor Ön Hazırlıklar Yapılıyor.");
            context.SetState(new BehavioralStateWaitingState());
        }
    }
}