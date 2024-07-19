using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieTrackerAPI.Models.User
{
    public class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int userId { get; set; }
        [Required]
        public string username { get; set; }
        public DateTime creationDate { get; set; }
        public DateTime? updatedDate { get; set; }
    }
}
