using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Shared.Entities.Models.Project;

namespace TimeTracker.Shared.Entities.Models.TimeEntry
{
    public record struct TimeEntryByProjectResponse(
            int Id,
            DateTime Start,
            DateTime? End
        );

}
