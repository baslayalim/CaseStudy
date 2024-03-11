namespace CaseStudy.Training.DesignPatterns.Behavioral.ChainOfResponsibility
{
    class BehavioralChainOfResponsibilityJpegHandler : BehavioralChainOfResponsibilityBaseHandler
    {
        public override void HandleRequest(BehavioralChainOfResponsibilityImage image)
        {
            if (image.extension == "JPEG")
            {
                Console.WriteLine("jpeg Formattan Png Formata Dönüştürüldü");
            }
            else
            {
                _nextHandler.HandleRequest(image);
            }
        }
    }
}
