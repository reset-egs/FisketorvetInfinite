namespace FisketorvetInfinte.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Display(Name = "Event Name")]
        [Required(ErrorMessage = "Name of the Event is required"), MaxLength(30)]
        public string? Name { get; set; }

        public string? Description { get; set; }

        [Required(ErrorMessage = "Date required")]
        [Range(typeof(DateTime), "10/1/2020", "10/1/2021",
        ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public DateTime DateTime { get; set; }
    }
}