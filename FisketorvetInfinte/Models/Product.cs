namespace FisketorvetInfinte.Models
{
    public class Product
    {
        public Product()
        {

        }

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string ? ImageName { get; set; }

        public float Price { get; set; }

        public SizeEnum Size { get; set; }
        public enum SizeEnum
        {
            XS,
            S,
            M,
            L,
            XL,
            XXL
        }

        public ColourEnum Colour { get; set; }
        public enum ColourEnum
        {
            Red,
            Green,
            Blue,
            Yellow,
            Black,
            White,
            Orange,
            Purple,
        }
    }
}
