namespace CaseStudy.Training.DesignPatterns.Behavioral.Visitor
{
    class BehavioralVisitorMagazine : BehavioralVisitorBook
    {
        public override void Accept(BehavioralVisitorIBookExportVisitor visitor)
        {
            visitor.ExportVisit(this);
        }
    }
}