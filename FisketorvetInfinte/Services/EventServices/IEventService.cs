namespace FisketorvetInfinte.Services.EventServices
{
    public interface IEventService
    {
        List<Event> AllEvents { get; }

        Event FindEvent(int id);

        void AddEvent(Event e);

        void UpdateEvent(Event e);

        void RemoveEvent(Event e);
       
    }
}