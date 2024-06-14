using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Domain.Entities
{
    public class ServiceIntegration
    {
        public int id { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string description { get; set; }
        public string status { get; set; }
    }
}
