using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Creational.Singleton
{
    public class CreationalSingleton
    {
        public static void CreateDatabase()
        {
            CreationalSingletonDatabase firstInstanceRequest = CreationalSingletonDatabase.GetInstance();
            CreationalSingletonDatabase secondInstanceRequest = CreationalSingletonDatabase.GetInstance();

            bool isEquals = firstInstanceRequest == secondInstanceRequest;
            Console.WriteLine($"Database referance is equals: {isEquals}");
        }
    }
}
