using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp_core_Login.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public Guid id { get; set; }
        [StringLength(20)]
        public string? Name { get; set; }
        [Required]
        [StringLength(30)]
        public string Username { get; set; }
        [Required]
        [StringLength(100)]
        public string password { get; set; }
        public bool activate { get; set; }=false;
        public DateTime createdDate { get; set; }=DateTime.Now;
        [StringLength(255)]
        public string profileImageFile { get; set; }="user_1jpg";

        [Required]
        [StringLength(50)]
        public string role { get; set; } = "user";

    }
}
