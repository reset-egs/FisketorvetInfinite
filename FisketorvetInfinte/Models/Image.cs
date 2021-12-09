namespace FisketorvetInfinte.Models
{
    //Not used in code currently
    public class Image
    {
        public string? Path { get; set; }

        public int Id { get; set; }

        public string? Description { get; set; }

        [NotMapped]
        public IFormFile? File { get; set; }
    }
}