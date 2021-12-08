namespace FisketorvetInfinte.Services.EventServices
{
    public class EventService : IEventService
    {
        public List<Event> AllEvents { get; } = JsonFileEventService.ReadJson("./Data/Events.json");

        public Event FindEvent(int id)
        {
            foreach (var e in AllEvents)
            {
                if (e.Id == id)
                {
                    return e;
                }
            }
            return null;
        }

        public void AddEvent(Event e)
        {
            List<int> eventIds = new List<int>();
            foreach (var evt in AllEvents)
            {
                eventIds.Add(evt.Id);
            }
            if (eventIds.Count != 0)
            {
                int start = eventIds.Max();
                e.Id = start + 1;
            }
            else
            {
                e.Id = 1;
            }
            AllEvents.Add(e);
            JsonFileEventService.WriteToJson(AllEvents, "./Data/Events.json");
        }

        public void UpdateEvent(Event ev)
        {
            if (ev != null)
            {
                foreach (var e in AllEvents)
                {
                    if (e.Id == ev.Id)
                    {
                        e.Name = ev.Name;
                        e.Description = ev.Description;
                        e.DateTime = ev.DateTime;
                    }
                }
            }
            JsonFileEventService.WriteToJson(AllEvents, "./Data/Events.json");
        }

        public void RemoveEvent(Event e)
        {
            if (e != null)
            {
                foreach (var ev in AllEvents)
                {
                    if (e.Id == ev.Id)
                    {
                        AllEvents.Remove(e);
                        break;
                    }
                }
            }
            JsonFileEventService.WriteToJson(AllEvents, "./Data/Events.json");
        }
    }
}
