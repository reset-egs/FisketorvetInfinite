namespace FisketorvetInfinte.Models
{
    public class Shop
    {
        public int ShopId { get; set; }

        public string? ImageName { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? Category { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        //[RegularExpression("^([0 - 1]?[0 - 9] | 2[0 - 3]):[0-5] [0-9]$[-]?^([0 - 1]?[0 - 9]|2[0-3]):[0-5] [0-9]$", ErrorMessage="Opening hours should be in format hh:mm - hh:mm")]
        public string? WorkHour { get; set; }
      
        public string? PhoneNumber { get; set; }

        public string? Description { get; set; }

        public string? Image1 { get; set; }

        public string? Image2 { get; set; }

        public string? Image3 { get; set; }
    }
}
