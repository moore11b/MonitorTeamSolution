using MonitorTeamSolution.Models.Entities;
using MonitorTeamSolution.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitorTeamSolution.Services.Interfaces
{
    public interface IPagesRepo
    {
        IQueryable<PageInfo> ReadAll();
        PageInfo Create(PageCreateVM page);
        PageInfo Read(int id);
        void Update(int id, PageEditVM page);

        void Delete(int id);
    }
}
