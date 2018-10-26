using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Product
    {
        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public double Vat { get; set; }
    }
}
