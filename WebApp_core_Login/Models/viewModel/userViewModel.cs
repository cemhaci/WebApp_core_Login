using System.ComponentModel.DataAnnotations;

namespace WebApp_core_Login.Models.viewModel
{
    public class userViewModel
    {
        [Key]
        public Guid id { get; set; }
        [StringLength(20)]
        public string? Name { get; set; }
        [Required]
        [StringLength(30)]
        public string Username { get; set; }
        public bool activate { get; set; } = false;
        public DateTime createdDate { get; set; } = DateTime.Now;

        [Required]
        [StringLength(50)]
        public string role { get; set; } = "user";
    }
}
