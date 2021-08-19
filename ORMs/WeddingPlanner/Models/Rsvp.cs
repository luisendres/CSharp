using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
    public class Rsvp
    {
        [Key]
        public int RsvpId { get; set; }

        /* 
        Foreign Keys and Navigation Properties for Relationships
        
        Navigation properties are null unless you use .Include / .ThenInclude
        */
        public int UserId { get; set; } // FK
        public User User { get; set; }

        public int WeddingId { get; set; } // Fk
        public Wedding Wedding { get; set; }
    }
}