using System.ComponentModel.DataAnnotations;

namespace Mission6_Kemp.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieID { get; set; }
        public required string Category { get; set; }
        public required string Title { get; set; }
        public int Year { get; set; }
        public required string Director { get; set; }
        public required string Rating { get; set; }
        public bool Edited { get; set; }
        public required string LentTo { get; set; }
        public required string Notes {  get; set; }

    }
}
