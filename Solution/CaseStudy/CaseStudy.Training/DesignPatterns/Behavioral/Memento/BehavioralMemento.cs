namespace CaseStudy.Training.DesignPatterns.Behavioral.Memento
{
    internal class BehavioralMemento
    {
        public static void Memento() 
        {
            BehavioralMementoTextOriginator textOriginator = new BehavioralMementoTextOriginator();

            textOriginator.Text = "HumanSoft";
            textOriginator.CursorPosition = 9;
            textOriginator.Save();

            textOriginator.Text = "Human";
            textOriginator.CursorPosition = 5;
            textOriginator.Save();

            textOriginator.Text = "Hum";
            textOriginator.CursorPosition = 3;
            textOriginator.Save();

            textOriginator.Undo();
            Console.WriteLine(textOriginator.ToString());

            textOriginator.Undo();
            Console.WriteLine(textOriginator.ToString());

            textOriginator.Undo();
            Console.WriteLine(textOriginator.ToString());
        }
    }
}