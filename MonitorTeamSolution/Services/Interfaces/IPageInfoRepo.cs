using MonitorTeamSolution.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitorTeamSolution.Services.Interfaces
{
    interface IPageInfoRepo
    {
        PageInfo CreatePageInfo(PageInfo pI);
        PageInfo ReadPageInfo(int id);
        IEnumerable<PageInfo> ReadAllPageInfo();
        void UpdatePageInfo(int id, PageInfo pI);
        void DeletePageInfo(int id);
    }
}
