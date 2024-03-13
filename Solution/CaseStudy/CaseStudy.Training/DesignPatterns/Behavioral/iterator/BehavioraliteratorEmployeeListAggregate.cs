namespace CaseStudy.Training.DesignPatterns.Behavioral.iterator
{ 
    class BehavioraliteratorEmployeeListAggregate : BehavioraliteratorIEmployeeAggregate
    {
        private List<BehavioraliteratorEmployee> _employees;

        public BehavioraliteratorEmployeeListAggregate()
        {
            _employees = new List<BehavioraliteratorEmployee>();
        }

        public void Add(BehavioraliteratorEmployee employee)
        {
            _employees.Add(employee);
        }

        public int Count()
        {
            return _employees.Count;
        }

        public BehavioraliteratorEmployee Get(int index)
        {
            return _employees[index];
        }

        public BehavioraliteratorIIterator<BehavioraliteratorEmployee> CreateIterator()
        {
            return new BehavioraliteratorEmployeeIterator(this);
        }
    }
}
