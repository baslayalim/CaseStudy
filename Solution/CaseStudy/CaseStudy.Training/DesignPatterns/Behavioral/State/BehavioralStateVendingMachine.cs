namespace CaseStudy.Training.DesignPatterns.Behavioral.State
{
    public class BehavioralStateVendingMachine
    {
        private BehavioralStateVendingMachineState _state;

        public BehavioralStateVendingMachine()
        {
            SetState(new BehavioralStateInitializeState());
        }

        public void SetState(BehavioralStateVendingMachineState state)
        {
            _state = state;
            _state.HandleState(this);
        }

        public void RequestProduct(string productName, double price)
        {
            SetState(new BehavioralStatePreparingState());
        }
    }
}