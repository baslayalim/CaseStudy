namespace CaseStudy.Training.DesignPatterns.Behavioral.ChainOfResponsibility
{
    internal class BehavioralChainOfResponsibility
    {
        public static void ChainOfResponsibility()
        {
            BehavioralChainOfResponsibilityImage image = new BehavioralChainOfResponsibilityImage("hs_custumer_4242", "OtherExtension");

            BehavioralChainOfResponsibilityJpegHandler jpegHandler = new BehavioralChainOfResponsibilityJpegHandler();
            BehavioralChainOfResponsibilityJpgHandler jpgHandler = new BehavioralChainOfResponsibilityJpgHandler();
            BehavioralChainOfResponsibilityCustomHandler customHandler = new BehavioralChainOfResponsibilityCustomHandler();

            jpegHandler.SetNextHandler(jpgHandler);
            jpgHandler.SetNextHandler(customHandler);

            jpegHandler.HandleRequest(image);
        }
    }
}
