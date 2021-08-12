using System;
using System.ComponentModel.DataAnnotations;

namespace CRUDelicious.Models
{
    public class Dish
    {
        [Key] //Primary Key
        public int DishId { get; set; }
        
        [Required(ErrorMessage = "is required.")]
        [MinLength(2, ErrorMessage = "Must be more than 2 characters.")]
        [MaxLength(45, ErrorMessage = "Must be less than 45 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "is required.")]
        [MinLength(2, ErrorMessage = "Must be more than 2 characters.")]
        [MaxLength(45, ErrorMessage = "Must be less than 45 characters.")]
        public string Chef { get; set; }

        [Required(ErrorMessage = "is required.")]
        [Range(0,6, ErrorMessage = "Must be more than 0 or less than 6.")]
        public int Tastiness { get; set; }
        
        [Required(ErrorMessage = "is required.")]
        [Range(0,999999999, ErrorMessage = "Must be more than 0 Calories.")]
        public int Calories { get; set; }
        
        [Required(ErrorMessage = "is required.")]
        [MinLength(2, ErrorMessage = "Must be more than 2 characters.")]
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}