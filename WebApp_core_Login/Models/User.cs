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
        [StringLength(10)]
        public string password { get; set; }
        public bool activate { get; set; }=false;
        public DateTime createdDate { get; set; }=DateTime.Now;

        [Required][StringLength(50)]
        public string role { get; set; }
    }
}
