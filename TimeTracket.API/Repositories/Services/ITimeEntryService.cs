﻿namespace TimeTracket.API.Repositories.Services
{
    public interface ITimeEntryService
    {
        Task<TimeEntryResponse?> GetTimeEntryById(int id);
        Task<List<TimeEntryResponse>> GetAllTimeEntries();

        Task<List<TimeEntryResponse>> CreateTimeEntry(TimeEntryCreateRequest timeEntry);

        Task<List<TimeEntryResponse>?> UpdateTimeEntry(int id, TimeEntryUpdateRequest timeEntry);

        Task<List<TimeEntryResponse>?> DeleteTimeEntry(int id);

        Task<List<TimeEntryByProjectResponse>> GetTimeEntriesByProject(int projectId);

    }
}