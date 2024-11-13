﻿using Microsoft.AspNetCore.Mvc;

namespace TimeTracket.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeEntryController : ControllerBase
    {
        private readonly ITimeEntryService _timeEntryService;

        public TimeEntryController(ITimeEntryService timeEntryService) 
        {
            _timeEntryService = timeEntryService;
        }

        [HttpGet]
        public async Task<ActionResult<List<TimeEntryResponse>>> GetAllTimeEntries()
        {
            return Ok(await _timeEntryService.GetAllTimeEntries());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<TimeEntryResponse>>> GetTimeEntryById(int id)
        {
            var result = await _timeEntryService.GetTimeEntryById(id);

            if(result is null)
            {
                return NotFound("TimeEntry with the given ID was not found.");
            }

            return Ok(result);
        }

        [HttpGet("project/{projectId}")]
        public async Task<ActionResult<List<TimeEntryByProjectResponse>>> GetTimeEntriesByProject(int projectId)
        {
            return Ok(await _timeEntryService.GetTimeEntriesByProject(projectId));
        }

        [HttpPost]
        public async Task<ActionResult<List<TimeEntry>>> CreateTimeEntry(TimeEntryCreateRequest timeEntry)
        { 
            return Ok(await _timeEntryService.CreateTimeEntry(timeEntry));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<TimeEntry>>> UpdateTimeEntry(int id, TimeEntryUpdateRequest timeEntry)
        {
            var result = await _timeEntryService.UpdateTimeEntry(id, timeEntry);
            if(result is null) 
            { 
                return NotFound("TimeEntry with the given ID was not found.");
            }
            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult<List<TimeEntry>>> DeleteTimeEntry(int id)
        {
            var result = await _timeEntryService.DeleteTimeEntry(id);
            if(result is null)
            {
                return NotFound("TimeEntry with the given Id was not found.");
            }

            return Ok(result);
        }

    }
}
