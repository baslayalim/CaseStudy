namespace CaseStudy.Training.DesignPatterns.Behavioral.iterator
{
    interface BehavioraliteratorIIterator<T>
    {
        bool HasNext();
        T GetCurrentItem();
    }
}