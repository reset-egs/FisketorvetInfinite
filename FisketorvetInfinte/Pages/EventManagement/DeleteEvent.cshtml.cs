namespace FisketorvetInfinte.Pages.EventManagement
{
    public class DeleteEventModel : PageModel
    {
        public IEventService _eventService { get; set; }

        public DeleteEventModel(IEventService service)
        {
            _eventService = service;
        }

        public string? Role { get; set; }

        public Event? Event { get; set; }

        public void OnGet(int id)
        {
            Role = HttpContext.Session.GetString("role");
            Event = _eventService.FindEvent(id);
        }

        public IActionResult OnPost(int id)
        {
            Event = _eventService.FindEvent(id);
            _eventService.RemoveEvent(Event);
            return RedirectToPage("AllEvents");
        }
    }
}