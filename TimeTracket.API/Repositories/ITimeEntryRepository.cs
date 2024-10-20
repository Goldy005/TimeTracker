using TimeTracker.Shared.Entities;

namespace TimeTracket.API.Repositories
{
    public interface ITimeEntryRepository
    {
        TimeEntry? GetTimeEntryById(int id);
        List<TimeEntry> GetAllTimeEntries();
        
        List<TimeEntry> CreateTimeEntry(TimeEntry timeEntry);

        List<TimeEntry>? UpdateTimeEntry(int Id, TimeEntry timeEntry);

        List<TimeEntry>? DeleteTimeEntry(int Id);

    }
}
