namespace FisketorvetInfinte.Models
{
    public class User
    {
        [Required(ErrorMessage = "The username is required")]
        public string ? Username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string ? Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The passwords do not match.")]
        public string ? ConfirmPassword { get; set; }

        [Required(ErrorMessage = "The name is required")]
        public string ? Name { get; set; }

        public string ? Address { get; set; }

        public string ? PhoneNumber { get; set; }

        [Required(ErrorMessage = "The email is required")]
        [DataType(DataType.EmailAddress)]
        public string ? Email { get; set; }
        
        public string ? Role { get; set; }
    }
}
