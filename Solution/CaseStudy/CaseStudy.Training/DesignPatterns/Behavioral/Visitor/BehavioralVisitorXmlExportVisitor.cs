namespace CaseStudy.Training.DesignPatterns.Behavioral.Visitor
{
    class BehavioralVisitorXmlExportVisitor : BehavioralVisitorIBookExportVisitor
    {
        public void ExportVisit(BehavioralVisitorMagazine magazine)
        {
            Console.WriteLine($"{magazine.name} Xml Aktarıldı");
        }

        public void ExportVisit(BehavioralVisitorEncyclopedia encyclopedia)
        {
            Console.WriteLine($"{encyclopedia.name} Xml Aktarıldı");
        }
    }
}
