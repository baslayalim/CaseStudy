namespace CaseStudy.Training.DesignPatterns.Behavioral.Template
{
    class BehavioralTemplateHtmlDataAnalyzer : BehavioralTemplateDataAnalyzerBase
    {
        public override void ExportResult(object result)
        {
            Console.WriteLine("Html Çıktı");
        }
    }
}
