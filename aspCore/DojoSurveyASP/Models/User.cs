using System.ComponentModel.DataAnnotations;

namespace DojoSurveyASP.Models
{
    public class User
    {
        [Required(ErrorMessage = "is required.")]
        [MinLength(2, ErrorMessage = "Name must be at LEAST 2 characters.")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "is required.")]
        public string Location { get; set; }
        
        [Required(ErrorMessage = "is required.")]
        public string Language { get; set; }

        [MinLength(20, ErrorMessage = "Not required, but must be MORE than 20 characters.")]
        public string Comment { get; set; }
    }
}