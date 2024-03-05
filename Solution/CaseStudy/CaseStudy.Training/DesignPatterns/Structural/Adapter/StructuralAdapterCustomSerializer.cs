using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Structural.Adapter
{
    class StructuralAdapterCustomSerializer
    {
        public string Serialize(object obj)
        {
            return "CustomSerializer ile Serilestirildi : { Name : 'Han' }";
        }
    }
}
