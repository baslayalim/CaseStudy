namespace CaseStudy.Training.DesignPatterns.Structural.Composite
{
    public class StructuralComposite
    {
        public static void Composite()
        {
            StructuralCompositeProductCatalog items = new StructuralCompositeProductCatalog("Ürünler");
            StructuralCompositeProductCatalog phones = new StructuralCompositeProductCatalog("Telefonlar");
            StructuralCompositeProductCatalog iPhone = new StructuralCompositeProductCatalog("iPhone Telefonlar");
            StructuralCompositeProductCatalog samsung = new StructuralCompositeProductCatalog("Samsung Telefonlar");

            StructuralCompositeProduct iphone5Item = new StructuralCompositeProduct("iPhone 5 Telefon");
            StructuralCompositeProduct samsungGalaxyItem = new StructuralCompositeProduct("Samsung Galaxy Telefon");

            items.Add(phones);

            phones.Add(iPhone);
            phones.Add(samsung);

            iPhone.Add(iphone5Item);

            samsung.Add(samsungGalaxyItem);

            items.DrawHierarchy();
        }
    }
}
