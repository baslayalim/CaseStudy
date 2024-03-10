namespace CaseStudy.Training.DesignPatterns.Structural.Proxy
{
    class StructuralProxyPerson
    {
        public string TC { get; set; }
        public string Address { get; set; }

        public StructuralProxyPerson(string tc, string address)
        {
            TC = tc;
            Address = address;
        }
    }
}
