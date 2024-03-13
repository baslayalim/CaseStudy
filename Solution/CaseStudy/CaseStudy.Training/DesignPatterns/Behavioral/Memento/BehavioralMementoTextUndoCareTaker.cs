namespace CaseStudy.Training.DesignPatterns.Behavioral.Memento
{
    class BehavioralMementoTextUndoCareTaker
    {
        private Stack<BehavioralMementoTextMemento> _mementos;

        public BehavioralMementoTextUndoCareTaker()
        {
            _mementos = new Stack<BehavioralMementoTextMemento>();
        }

        public BehavioralMementoTextMemento TextMemento
        {
            get
            {
                return _mementos.Pop();
            }
            set
            {
                _mementos.Push(value);
            }
        }
    }
}