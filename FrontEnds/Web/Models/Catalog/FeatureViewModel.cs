using System.ComponentModel.DataAnnotations;

namespace Web.Models.Catalog
{
    public class FeatureViewModel
    {
        [Display(Name = "Kurs süre")]
        [Required]
        public int Duration { get; set; }
    }
}
