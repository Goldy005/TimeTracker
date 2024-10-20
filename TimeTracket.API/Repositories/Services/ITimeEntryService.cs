using TimeTracker.Shared.Entities;
using TimeTracker.Shared.Entities.Models.TimeEntry;

namespace TimeTracket.API.Repositories.Services
{
    public interface ITimeEntryService
    {
        TimeEntryResponse? GetTimeEntryById(int id);
        List<TimeEntryResponse> GetAllTimeEntries();

        List<TimeEntryResponse> CreateTimeEntry(TimeEntryCreateRequest timeEntry);

        List<TimeEntryResponse>? UpdateTimeEntry(int id, TimeEntryUpdateRequest timeEntry);

        List<TimeEntryResponse>? DeleteTimeEntry(int id);

    }
}
