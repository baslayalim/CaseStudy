namespace CaseStudy.Training.DesignPatterns.Structural.Composite
{
    public class StructuralComposite
    {
        public static void Composite()
        {
            StructuralCompositeProductCatalog humanSoft = new StructuralCompositeProductCatalog("  -> HumanSoft" + Environment.NewLine);
            StructuralCompositeProductCatalog project = new StructuralCompositeProductCatalog("    -> Projeler" + Environment.NewLine);
            StructuralCompositeProductCatalog isbank = new StructuralCompositeProductCatalog("     -> İşbank Crm" );
            StructuralCompositeProductCatalog akbank = new StructuralCompositeProductCatalog("     -> Akbank Crm");

            StructuralCompositeProduct isBankMobil = new StructuralCompositeProduct("         -> İşbank Mobil");
            StructuralCompositeProduct isBankWeb = new StructuralCompositeProduct("         -> İşbank Web" + Environment.NewLine);
            StructuralCompositeProduct akbankAdayPortal = new StructuralCompositeProduct("         -> Akbank Aday Portal");

            humanSoft.Add(project);

            project.Add(isbank);
            project.Add(akbank);

            isbank.Add(isBankMobil);
            isbank.Add(isBankWeb);

            akbank.Add(akbankAdayPortal); 


            humanSoft.DrawHierarchy();
        }
    }
}
