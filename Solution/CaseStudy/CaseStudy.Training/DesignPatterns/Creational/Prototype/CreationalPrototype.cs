namespace CaseStudy.Training.DesignPatterns.Creational.Prototype
{
    public class CreationalPrototype
    {
        public static void PrototypeCreate()
        {
            Employee semy = new Employee("semy", "han");
            Employee semyGulizar = semy.Clone();

            // Aynı nesne örneklerini farklı referanslarda tutuyor.
            // Birbirinin aynısı ve farklı referanslarda olan nesneler elde ettik.
            Console.WriteLine(semy == semyGulizar);
        }
    }
}
