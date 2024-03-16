namespace CaseStudy.Training.DesignPatterns.Behavioral.Visitor
{
    interface BehavioralVisitorIBookExportVisitor
    {
        void ExportVisit(BehavioralVisitorMagazine magazine);
        void ExportVisit(BehavioralVisitorEncyclopedia encyclopedia);
    }
}