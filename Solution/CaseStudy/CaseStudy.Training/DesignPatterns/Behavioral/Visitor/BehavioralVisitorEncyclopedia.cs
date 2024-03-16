namespace CaseStudy.Training.DesignPatterns.Behavioral.Visitor
{
    class BehavioralVisitorEncyclopedia : BehavioralVisitorBook
    {
        public override void Accept(BehavioralVisitorIBookExportVisitor visitor)
        {
            visitor.ExportVisit(this);
        }
    }
}