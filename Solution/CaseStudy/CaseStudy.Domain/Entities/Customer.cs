using CaseStudy.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Domain.Entities
{
    [Comment("Müşteri Tablosu - Müşteri Bİlgileri Tutulur")] 
    public class Customer : BaseEntity
    {
        [Required]
        [MaxLength(200)]
        [Column(Order = 0)]
        [Comment("Müşteri İsmi Tutulur")]
        public string? Name { get; set; }
         

        [Column(TypeName = "varchar(300)", Order = 1)]
        [Comment("Müşteri Soyismi Tutulur")]
        public string? SurName { get; set; }
        public short? State { get; set; }


        [MaxLength(20)]
        [Column(Order = 2)]
        public string? Phone { get; set; }

        [MaxLength(20)]
        public string? Hobi { get; set; }

        [Column("local_storage_table")]
        [Comment("Sayfaya Ait Js Kodunun Tutulduğu Alan")]

        public int JsCode { get; set; }


        [NotMapped]
        public double Calculated { get; set; }
         

        [Comment("Siparis Bilgilerinin Tutuldugu Alan")]
        ICollection<Order>? Orders { get; set; }
    }
}
