using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Structural.Adapter
{
    public class StructuralAdapter
    {
        public static void JsonAdapter()
        {
            StructuralAdapterCustomOperation customOperation = new StructuralAdapterCustomOperation(new StructuralAdapterCustomSerializerAdapter());
            string serializedObject = customOperation.SerializeObject(new object());

            Console.WriteLine(serializedObject);
        }
    }
}
