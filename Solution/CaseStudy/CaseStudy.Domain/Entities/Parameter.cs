using CaseStudy.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Domain.Entities
{
    public class Parameter : BaseEntity 
    {
        public string? Description { get; set; } 
        public int State { get; set; }
    }
}
