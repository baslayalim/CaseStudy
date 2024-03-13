namespace CaseStudy.Training.DesignPatterns.Behavioral.Memento
{
    class BehavioralMementoTextOriginator
    {
        public string Text { get; set; }
        public int CursorPosition { get; set; }

        private BehavioralMementoTextUndoCareTaker _textCareTaker;

        public BehavioralMementoTextOriginator()
        {
            _textCareTaker = new BehavioralMementoTextUndoCareTaker();
        }

        public void Save()
        {
            _textCareTaker.TextMemento = new BehavioralMementoTextMemento
            {
                CursorPosition = this.CursorPosition,
                Text = this.Text
            };
        }

        public void Undo()
        {
            BehavioralMementoTextMemento previousTextMemento = _textCareTaker.TextMemento;

            CursorPosition = previousTextMemento.CursorPosition;
            Text = previousTextMemento.Text;
        }

        public override string ToString()
        {
            return $"Text : {Text}, Pozisyon : {CursorPosition}";
        }
    }
}