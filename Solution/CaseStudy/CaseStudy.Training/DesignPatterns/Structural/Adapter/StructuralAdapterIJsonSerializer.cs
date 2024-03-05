using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Structural.Adapter
{
    interface StructuralAdapterIJsonSerializer
    {
        public string SerializeObject(object obj);
    }
}
