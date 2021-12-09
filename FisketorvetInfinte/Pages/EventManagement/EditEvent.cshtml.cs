namespace FisketorvetInfinte.Pages.EventManagement
{
    public class EditEventModel : PageModel
    {
        public IEventService _eventService;

        public EditEventModel(IEventService service)
        {
            _eventService = service;
        }

        [BindProperty]
        public Event Event { get; set; } = new Event();

        public void OnGet(int id)
        {
            Event = _eventService.FindEvent(id);
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _eventService.UpdateEvent(Event);
                return RedirectToPage("AllEvents");
            }
            return Page();
        }
    }
}
