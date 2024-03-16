namespace CaseStudy.Training.DesignPatterns.Behavioral.Visitor
{
    class BehavioralVisitorJsonExportVisitor : BehavioralVisitorIBookExportVisitor
    {
        public void ExportVisit(BehavioralVisitorMagazine magazine)
        {
            Console.WriteLine($"{magazine.name} Json Aktarıldı");
        }

        public void ExportVisit(BehavioralVisitorEncyclopedia encyclopedia)
        {
            Console.WriteLine($"{encyclopedia.name} Json Aktarıldı");
        }
    }
}