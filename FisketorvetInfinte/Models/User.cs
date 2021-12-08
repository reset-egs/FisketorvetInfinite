namespace FisketorvetInfinte.Models
{
    public class User
    {
        public string? Username { get; set; }

        [Required(ErrorMessage = "Valid password is required.")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        /*We shouldn't store the confirmed password. Consider changing later*/
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The passwords do not match.")]
        public string? ConfirmPassword { get; set; }

        [Required(ErrorMessage = "The name is required")]
        public string? Name { get; set; }

        public string? Address { get; set; }

        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = "The email is required")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        /*Null state is allowed here because the variable assignment happens after the validity check. Otherwise the register form doesn't work*/
        public string? Role { get; set; }
    }
}