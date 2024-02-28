using CaseStudy.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string? Name { get; set; }
        [Required]
        public int Stock { get; set; }
        public long Price { get; set; }

        public ICollection<Order>? Orders { get; set; }
    }
}
