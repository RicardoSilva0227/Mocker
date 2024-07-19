using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieTrackerAPI.Models.Movies
{
    public class Movies
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int movieId { get; set; }
        [Required]
        public string movieName { get; set; }
        /// <summary>
        /// 1 - not watched, 2 - watched, 3 - rewatched
        /// </summary>
        [Required]
        public int movieStatus { get; set; }
        public string? genre { get; set; }
        public int? timesRewatched { get; set; }
        public string? imageUrl { get; set; }
        public DateTime creationDate { get; set; }
        public DateTime? updatedDate { get; set; }
    }
}
