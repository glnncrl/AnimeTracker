using System.ComponentModel.DataAnnotations;

namespace AnimeTracker.Models
{
    public class Anime
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        [Display(Name = "Title")]
        public string Title { get; set; } = string.Empty;

        [StringLength(100)]
        public string? Genre { get; set; }

        [Range(1, 3000)]
        [Display(Name = "Episodes")]
        public int? Episodes { get; set; }

        [Display(Name = "Watch Status")]
        public string Status { get; set; } = "Plan to Watch";

        [Range(1, 10)]
        [Display(Name = "Your Rating (1-10)")]
        public int? Rating { get; set; }

        [StringLength(500)]
        public string? Notes { get; set; }

        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; } = DateTime.Now;
    }
}