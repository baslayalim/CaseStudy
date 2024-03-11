namespace CaseStudy.Training.DesignPatterns.Behavioral.ChainOfResponsibility
{ 
    abstract class BehavioralChainOfResponsibilityBaseHandler
    {
        protected BehavioralChainOfResponsibilityBaseHandler? _nextHandler;
        public void SetNextHandler(BehavioralChainOfResponsibilityBaseHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public abstract void HandleRequest(BehavioralChainOfResponsibilityImage image);
    }
}
