namespace CaseStudy.Training.DesignPatterns.Structural.Composite
{
    public class StructuralCompositeProductCatalog : StructuralCompositeICatalogComponent
    {
        private string _name;

        private List<StructuralCompositeICatalogComponent> _components;

        public StructuralCompositeProductCatalog(string name)
        {
            _name = name;
            _components = new List<StructuralCompositeICatalogComponent>();
        }
        
        public void Add(StructuralCompositeICatalogComponent catalogComponent)
        {
            _components.Add(catalogComponent);
        }

        public void Remove(StructuralCompositeICatalogComponent catalogComponent)
        {
            _components.Remove(catalogComponent);
        }

        public void DrawHierarchy()
        {
            Console.WriteLine(_name);
            foreach (StructuralCompositeICatalogComponent component in _components)
            {
                component.DrawHierarchy();
            }
        }
    }
}
