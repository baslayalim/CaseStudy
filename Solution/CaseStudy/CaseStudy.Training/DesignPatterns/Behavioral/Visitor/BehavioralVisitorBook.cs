namespace CaseStudy.Training.DesignPatterns.Behavioral.Visitor
{
    abstract class BehavioralVisitorBook
    {
        public string name;
        public string author;
        public string categoryName;

        public abstract void Accept(BehavioralVisitorIBookExportVisitor visitor);
    }
}