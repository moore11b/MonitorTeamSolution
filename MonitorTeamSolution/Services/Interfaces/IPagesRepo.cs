using MonitorTeamSolution.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitorTeamSolution.Services.Interfaces
{
    public interface IPagesRepo
    {
        IQueryable<PageInfo> ReadAll();
    }
}
