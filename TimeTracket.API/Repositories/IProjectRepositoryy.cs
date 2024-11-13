namespace TimeTracket.API.Repositories
{
    public interface IProjectRepository
    {
        Task<Project?> GetProjectById(int id);
        Task<List<Project>> GetAllProjects();
        
        Task<List<Project>> CreateProject(Project project);

        Task<List<Project>> UpdateProject(int Id, Project project);

        Task<List<Project>?> DeleteProject(int Id);

    }
}
