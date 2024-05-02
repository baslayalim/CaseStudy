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
        [Required]
        public string? Name { get; set; }
        [Required]
        public int Stock { get; set; }
        public long Price { get; set; }
         

        [Required(ErrorMessage = "Please enter name"), MaxLength(30)] 
        [StringLength(50, MinimumLength = 13, ErrorMessage = "Big Description Text")] 
        public string? Product_Description { get; set; }

        public ICollection<Order>? Orders { get; set; }
    }
}
