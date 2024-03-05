using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Structural.Adapter
{
    class StructuralAdapterCustomSerializerAdapter : StructuralAdapterIJsonSerializer
    {
        public string SerializeObject(object obj)
        {
            StructuralAdapterCustomSerializer customSerializer = new StructuralAdapterCustomSerializer();
            return customSerializer.Serialize(obj);
        }
    }
}
