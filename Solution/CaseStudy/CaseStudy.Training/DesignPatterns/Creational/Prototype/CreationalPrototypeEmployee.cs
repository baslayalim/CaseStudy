namespace CaseStudy.Training.DesignPatterns.Creational.Prototype
{
    class CreationalPrototypeEmployee : IClonablePrototype<CreationalPrototypeEmployee>
    {
        string firstName;
        string lastName;

        public CreationalPrototypeEmployee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public CreationalPrototypeEmployee Clone()
        {
            return base.MemberwiseClone() as CreationalPrototypeEmployee;
        }
    }
}
