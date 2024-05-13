namespace CaseStudy.Training.DesignPatterns.Creational.Prototype
{
    public class CreationalPrototype
    {
        public static void PrototypeCreate()
        {
            CreationalPrototypeEmployee semy = new CreationalPrototypeEmployee("semy", "han");
            CreationalPrototypeEmployee semyCopy = semy.Clone();
            
            Console.WriteLine(semy == semyCopy);
        }
    }
}
