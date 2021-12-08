namespace FisketorvetInfinte.Pages.EventManagement
{
    public class AllEventsModel : PageModel
    {
        public IEventService _eventService;

        public AllEventsModel(IEventService service)
        {
            _eventService = service;
        }

        public string? FilterCriteria { get; set; }

        public List<Event>? Events { get; set; }

        public string? Role { get; set; }

        public void OnGet()
        {
            Role = HttpContext.Session.GetString("role");
            Events = JsonFileEventService.ReadJson("./Data/Events.json");
        }
    }
}