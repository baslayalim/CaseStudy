namespace CaseStudy.Training.DesignPatterns.Behavioral.State
{
    class BehavioralStateWaitingState : BehavioralStateVendingMachineState
    {
        public override void HandleState(BehavioralStateVendingMachine context)
        {
            Console.WriteLine("WaitingState: Personeller Çalışıyor .");
        }
    }
}
