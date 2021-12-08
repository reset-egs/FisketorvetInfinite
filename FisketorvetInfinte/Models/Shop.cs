namespace FisketorvetInfinte.Models
{
    public class Shop
    {
        [Required]
        public int ShopId { get; set; }
        public string ImageName { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string WorkHour { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }

       
    }
}
