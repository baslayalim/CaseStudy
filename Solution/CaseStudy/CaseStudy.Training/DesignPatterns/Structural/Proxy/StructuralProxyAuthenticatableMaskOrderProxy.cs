namespace CaseStudy.Training.DesignPatterns.Structural.Proxy
{
    class StructuralProxyAuthenticatableMaskOrderProxy : StructuralProxyIOrderableMask
    {
        private StructuralProxyIOrderableMask _orderMask;

        public StructuralProxyAuthenticatableMaskOrderProxy()
        {
            _orderMask = new StructuralProxyMaskOrder();
        }

        public void CreateOrder(StructuralProxyPerson person)
        {
            bool isValid = CheckPersonIsValid(person);

            if (isValid)
            {
                _orderMask.CreateOrder(person);
            }
        }

        private bool CheckPersonIsValid(StructuralProxyPerson person)
        {
            return person.TC.Length == 11 && person.Address != "";
        }
    }
}
