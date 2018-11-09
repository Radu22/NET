using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    public class Poi
    {
        [Required]
        public Guid Id { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

        [Required]
        [Range(0, 99.99999999)]
        public double Lat { get; set; }
            
        [Required]
        [Range(0, 99.99999999)]
        public double Long { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
