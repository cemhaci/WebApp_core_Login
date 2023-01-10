using System.ComponentModel.DataAnnotations;

namespace WebApp_core_Login.Models.viewModel
{
    public class registerViewModel:LoginViewModel
    {
        [Required]
        [MinLength(6)]
        [MaxLength(16)]
        [Compare(nameof(password))]
        public string password2 { get; set; }
    }
}
