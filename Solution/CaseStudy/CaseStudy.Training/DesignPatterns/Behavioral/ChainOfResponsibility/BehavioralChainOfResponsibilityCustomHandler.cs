namespace CaseStudy.Training.DesignPatterns.Behavioral.ChainOfResponsibility
{
    class BehavioralChainOfResponsibilityCustomHandler : BehavioralChainOfResponsibilityBaseHandler
    {
        public override void HandleRequest(BehavioralChainOfResponsibilityImage image)
        {
            if (image.extension == "OtherExtension")
            {
                Console.WriteLine("Bilinmeyen Formattan Png Dönüştürüldü");
            }
        }
    }
}
