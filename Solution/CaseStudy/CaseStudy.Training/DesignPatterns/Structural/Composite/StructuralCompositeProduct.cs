namespace CaseStudy.Training.DesignPatterns.Structural.Composite
{
    class StructuralCompositeProduct : StructuralCompositeICatalogComponent
    {
        private string _name;

        public StructuralCompositeProduct(string name)
        {
            _name = name;
        }

        public void DrawHierarchy()
        {
            Console.WriteLine(_name);
        }
    }
}
