using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Structural.Facade
{
    public class StructuralFacade
    {
        public static void Facade() 
        {
            StructuralFacadeCustomer pamir = new StructuralFacadeCustomer("Pamir", "HumanSoft");
            StructuralFacadeCreditCardFacade creditCardFacade = new StructuralFacadeCreditCardFacade();
            creditCardFacade.CreateCreditCart(pamir);
        }
    }
}
