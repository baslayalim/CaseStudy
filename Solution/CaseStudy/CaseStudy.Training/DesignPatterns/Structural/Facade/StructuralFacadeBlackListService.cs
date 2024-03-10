using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Structural.Facade
{ 
    class StructuralFacadeBlackListService
    {
        public bool CheckEmployeeIsTheBlackList(StructuralFacadeCustomer customer)
        {
            Console.WriteLine($" {customer.FirstName} İsimli Müşteriniz Kara Listede Değildir .");
            return false;
        }
    }
}
