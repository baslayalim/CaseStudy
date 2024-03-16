namespace CaseStudy.Training.DesignPatterns.Behavioral.Template
{
    internal class BehavioralTemplate
    {
        public static void Template() 
        {
            BehavioralTemplateDataAnalyzerBase dataAnalyzer;

            dataAnalyzer = new BehavioralTemplateXmlDataAnalyzer();
            dataAnalyzer.AnalyzeDataOfLastWeek();

            dataAnalyzer = new BehavioralTemplateHtmlDataAnalyzer();
            dataAnalyzer.AnalyzeDataOfLastWeek();
        }
    }
}