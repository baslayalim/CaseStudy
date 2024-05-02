using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Application.ViewModels.Products
{
    public class VM_Create_Product
    {
        [Required(ErrorMessage = "Please enter Description - Lütfen Giriş Yapınız")]
        public string Name { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }
        [Required(ErrorMessage = "Please enter Description - Lütfen Giriş Yapınız")]
        [StringLength(8, ErrorMessage = "{0} length must be between {2} and {1}. - Kriterlere Uymuyor", MinimumLength = 6)]
        public string Description { get; set; }
    }
}
