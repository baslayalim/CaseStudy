namespace CaseStudy.Training.DesignPatterns.Behavioral.iterator
{ 
    class BehavioraliteratorEmployeeIterator : BehavioraliteratorIIterator<BehavioraliteratorEmployee>
    {
        private BehavioraliteratorEmployeeListAggregate _employeeListAggregate;
        private int _currentIndex;

        public BehavioraliteratorEmployeeIterator(BehavioraliteratorEmployeeListAggregate employeeListAggregate)
        {
            _employeeListAggregate = employeeListAggregate;
            _currentIndex = 0;
        }

        public BehavioraliteratorEmployee GetCurrentItem()
        {
            return _employeeListAggregate.Get(_currentIndex++);
        }

        public bool HasNext()
        {
            if (_employeeListAggregate.Count() > _currentIndex)
            {
                return true;
            }
            return false;
        }
    }
}
