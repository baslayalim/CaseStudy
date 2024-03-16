namespace CaseStudy.Training.DesignPatterns.Behavioral.Template
{
    abstract class BehavioralTemplateDataAnalyzerBase 
    {
        public void AnalyzeDataOfLastWeek()
        {
            object data = GetDataOfLastWeek();
            object result = AnalyzeData(data);
            ExportResult(result);
        }

        private object GetDataOfLastWeek()
        {
            Console.WriteLine("Çalışan Method : Haftalık Verileri Al");
            return new object();
        }

        private object AnalyzeData(object data)
        {
            Console.WriteLine("Çalışan Method : Veriler Analiz Ediliyor");
            return new object();
        }

        public abstract void ExportResult(object result);
    }
}