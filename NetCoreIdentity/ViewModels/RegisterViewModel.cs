using System.ComponentModel.DataAnnotations;

namespace NetCoreIdentity.ViewModels
{
    public class RegisterViewModel
    {
        
        public string Email { get; set; }

        
        public int Year { get; set; }

        
        public string Password { get; set; }

       
        public string PasswordConfirm { get; set; }
    }
}
