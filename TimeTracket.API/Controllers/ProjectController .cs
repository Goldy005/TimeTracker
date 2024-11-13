﻿using Microsoft.AspNetCore.Mvc;
using TimeTracker.Shared.Entities.Models.Project;

namespace TimeTracket.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService) 
        {
            _projectService = projectService;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProjectResponse>>> GetAllProjects()
        {
            return Ok(await _projectService.GetAllProjects());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<ProjectResponse>>> GetProjectById(int id)
        {
            var result = await _projectService.GetProjectById(id);

            if(result is null)
            {
                return NotFound("Project with the given ID was not found.");
            }

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Project>>> CreateProject(ProjectCreateRequest project)
        { 
            return Ok(await _projectService.CreateProject(project));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Project>>> UpdateProject(int id, ProjectUpdateRequest project)
        {
            var result = await _projectService.UpdateProject(id, project);
            if(result is null) 
            { 
                return NotFound("Project with the given ID was not found.");
            }
            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult<List<Project>>> DeleteProject(int id)
        {
            var result = await _projectService.DeleteProject(id);
            if(result is null)
            {
                return NotFound("Project with the given Id was not found.");
            }

            return Ok(result);
        }

    }
}
