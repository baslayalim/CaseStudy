using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Structural.Facade
{
    class StructuralFacadeCreditCardManager
    {
        public void CreateCreditCart(StructuralFacadeCustomer customer)
        {
            Console.WriteLine($" {customer.FirstName} {customer.LastName} Kişine Ait Kart Basıma Gönderildi ...");
        }
    }
}
