namespace CaseStudy.Training.DesignPatterns.Behavioral.ChainOfResponsibility
{ 
    class BehavioralChainOfResponsibilityJpgHandler : BehavioralChainOfResponsibilityBaseHandler
    {
        public override void HandleRequest(BehavioralChainOfResponsibilityImage image)
        {
            if (image.extension == "JPG")
            {
                Console.WriteLine("Jpg formattan Png Formata Dönüştürüldü");
            }
            else
            {
                _nextHandler.HandleRequest(image);
            }
        }
    }
}
