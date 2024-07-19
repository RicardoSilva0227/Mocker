using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieTrackerAPI.Models.Rewatched
{
    public class Rewatched
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int rewatchedId { get; set; }
        [ForeignKey("Movies")]
        public int movieId { get; set; }
        [ForeignKey("Users")]
        public int UserId { get; set; }
        /// <summary>
        /// 1 is the  minimum
        /// </summary>
        [Required]
        public int timesRewatched { get; set; }
        public DateTime creationDate { get; set; }
        public DateTime? updatedDate { get; set; }

    }
}
