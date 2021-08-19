using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProdAndCat.Models
{
    public class Category
    {
        [Key] // Primary Key
        public int CategoryId { get; set; }
        
        [Required]
        [MinLength(2, ErrorMessage = "Must be more than 2 characters.")]
        public string Name { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        /* 
        Foreign Keys and Navigation Properties for Relationships
        
        Navigation properties are null unless you use .Include / .ThenInclude
        */
        public List<Association> Associations { get; set; }
    }
}