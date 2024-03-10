namespace CaseStudy.Training.DesignPatterns.Structural.Proxy
{
    internal class StructuralProxy
    {
        public static void Proxy()
        {
            StructuralProxyPerson fyza = new StructuralProxyPerson("11111111111", "Kayseri / Mimar Sinan Parkı");
            StructuralProxyIOrderableMask orderableMask = new StructuralProxyAuthenticatableMaskOrderProxy();
            orderableMask.CreateOrder(fyza);
        }
    }
}
