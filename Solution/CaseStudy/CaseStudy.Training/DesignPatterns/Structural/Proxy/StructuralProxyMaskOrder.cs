namespace CaseStudy.Training.DesignPatterns.Structural.Proxy
{
    class StructuralProxyMaskOrder : StructuralProxyIOrderableMask
    {
        public void CreateOrder(StructuralProxyPerson person)
        {
            Console.WriteLine($"Siparişiniz Onaylandı {person.Address}.");
        }
    }
}
