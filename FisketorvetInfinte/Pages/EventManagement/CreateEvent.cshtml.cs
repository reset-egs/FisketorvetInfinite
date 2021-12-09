using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FisketorvetInfinte.Pages.EventManagement
{
    public class CreateEventModel : PageModel
    {
        public IEventService _eventService;

        public CreateEventModel(IEventService service)
        {
            _eventService = service;
        }

        [BindProperty]
        public Event Event { get; set; } = new Event();

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _eventService.AddEvent(Event);
                return RedirectToPage("AllEvents");
            }
            return Page();
        }
    }
}