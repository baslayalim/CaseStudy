using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Structural.Facade
{
    class StructuralFacadeCreditCardFacade
    {
        public void CreateCreditCart(StructuralFacadeCustomer customer)
        {
            StructuralFacadeCreditCardManager creditCardManager = new StructuralFacadeCreditCardManager();
            StructuralFacadeBlackListService blackListService = new StructuralFacadeBlackListService();
            if (!blackListService.CheckEmployeeIsTheBlackList(customer))
            {
                creditCardManager.CreateCreditCart(customer);
            }
        }
    }
}
