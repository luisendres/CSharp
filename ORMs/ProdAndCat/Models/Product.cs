using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProdAndCat.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "is required.")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "is required.")]
        [MinLength(2, ErrorMessage = "Must be more than 2 characters.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "is required.")]
        [RegularExpression(@"^\d+.?\d{0,2}$", ErrorMessage = "Invalid Target Price; Maximum Two Decimal Points.")]
        [Range(0.01,100000000000.0, ErrorMessage = "Must be more than $0 for less than $100000000000.")]
        public decimal Price { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        /* 
        Foreign Keys and Navigation Properties for Relationships
        
        Navigation properties are null unless you use .Include / .ThenInclude
        */
        public List<Association> Associations { get; set; }
    }
}