namespace TimeTracket.API.Repositories
{
    public interface ITimeEntryRepository
    {
        Task<TimeEntry?> GetTimeEntryById(int id);
        Task<List<TimeEntry>> GetAllTimeEntries();
        
        Task<List<TimeEntry>> CreateTimeEntry(TimeEntry timeEntry);

        Task<List<TimeEntry>> UpdateTimeEntry(int Id, TimeEntry timeEntry);

        Task<List<TimeEntry>?> DeleteTimeEntry(int Id);

        Task<List<TimeEntry>> GetTimeEntriesByProject(int projectId);

    }
}
