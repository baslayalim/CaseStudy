namespace CaseStudy.Training.DesignPatterns.Behavioral.Visitor
{
    internal class BehavioralVisitor
    {
        public static void Visitor() 
        {
            BehavioralVisitorBook mesnevi = new BehavioralVisitorEncyclopedia();
            mesnevi.name = "Mesnevi";
            mesnevi.author = "Mevlana";
            mesnevi.categoryName = "Tasavvuf";

            BehavioralVisitorBook sems = new BehavioralVisitorMagazine();
            sems.name = "Aşkın Kırk Kuralı";
            sems.author = "Şems-i Tebrizi";
            sems.categoryName = "Tasavvuf";

            BehavioralVisitorIBookExportVisitor xmlExportVisitor = new BehavioralVisitorXmlExportVisitor();
            BehavioralVisitorIBookExportVisitor jsonExportVisitor = new BehavioralVisitorJsonExportVisitor();

            mesnevi.Accept(xmlExportVisitor);
            sems.Accept(jsonExportVisitor);
        }
    }
}