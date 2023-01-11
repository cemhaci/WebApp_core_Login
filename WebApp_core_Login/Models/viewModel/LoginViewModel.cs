using System.ComponentModel.DataAnnotations;

namespace WebApp_core_Login.Models.viewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Kullanıcı adı zorunludur")]
        [StringLength(30,ErrorMessage ="Kullanıcı adı max 30 karakter olmalıdır")]
        public string username { get; set; }
        [Required]
        [MinLength(6)]
        [MaxLength(16)]
        public string password { get; set; }
    }
}
