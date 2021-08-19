using System.ComponentModel.DataAnnotations;

namespace ProdAndCat.Models
{
    public class Association
    {
        [Key]
        public int AssociationId { get; set; }

        /* 
        Foreign Keys and Navigation Properties for Relationships
        
        Navigation properties are null unless you use .Include / .ThenInclude
        */
        public int ProductId { get; set; } // FK
        public Product Product { get; set; }
        public int CategoryId { get; set; } // Fk
        public Category Category { get; set; }
    }
}