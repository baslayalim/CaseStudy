using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Structural.Adapter
{
    class StructuralAdapterCustomOperation
    {
        private StructuralAdapterIJsonSerializer _jsonSerializer;

        public StructuralAdapterCustomOperation(StructuralAdapterIJsonSerializer jsonSerializer)
        {
            _jsonSerializer = jsonSerializer;
        }

        public string SerializeObject(object obj)
        {
            return _jsonSerializer.SerializeObject(obj);
        }
    }
}
