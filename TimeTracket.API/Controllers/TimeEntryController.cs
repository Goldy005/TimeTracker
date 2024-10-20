using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TimeTracker.Shared.Entities;
using TimeTracker.Shared.Entities.Models.TimeEntry;
using TimeTracket.API.Repositories;
using TimeTracket.API.Repositories.Services;

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
        public ActionResult<List<TimeEntryResponse>> GetAllTimeEntries()
        {
            return Ok(_timeEntryService.GetAllTimeEntries());
        }

        [HttpGet("{id}")]
        public ActionResult<List<TimeEntryResponse>> GetTimeEntryById(int id)
        {
            var result = _timeEntryService.GetTimeEntryById(id);

            if(result is null)
            {
                return NotFound("TimeEntry with the given ID was not found.");
            }

            return Ok(result);
        }

        [HttpPost]
        public ActionResult<List<TimeEntry>> CreateTimeEntry(TimeEntryCreateRequest timeEntry)
        { 
            return Ok(_timeEntryService.CreateTimeEntry(timeEntry));
        }

        [HttpPut("{id}")]
        public ActionResult<List<TimeEntry>> CreateTimeEntry(int id, TimeEntryUpdateRequest timeEntry)
        {
            var result = _timeEntryService.UpdateTimeEntry(id, timeEntry);
            if(result is null) 
            { 
                return NotFound("TimeEntry with the given ID was not found.");
            }
            return Ok(result);
        }

        [HttpDelete]
        public ActionResult<List<TimeEntry>> DeleteTimeEntry(int id)
        {
            var result = _timeEntryService.DeleteTimeEntry(id);
            if(result is null)
            {
                return NotFound("TimeEntry with the given Id was not found.");
            }

            return Ok(result);
        }

    }
}
