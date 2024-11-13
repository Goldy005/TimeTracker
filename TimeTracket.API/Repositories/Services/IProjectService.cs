using TimeTracker.Shared.Entities.Models.Project;

namespace TimeTracket.API.Repositories.Services
{
    public interface IProjectService
    {
        Task<ProjectResponse?> GetProjectById(int id);
        Task<List<ProjectResponse>> GetAllProjects();

        Task<List<ProjectResponse>> CreateProject(ProjectCreateRequest timeEntry);

        Task<List<ProjectResponse>?> UpdateProject(int id, ProjectUpdateRequest timeEntry);

        Task<List<ProjectResponse>?> DeleteProject(int id);

    }
}