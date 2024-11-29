using MiniProject5.Application.DTOs;
using MiniProject5.Persistence.Models;
using MiniProject6.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject6.Application.Interfaces.IServices
{
    public interface IWorksOnService
    {
        Task<object> GetAllWorksOnAsync(paginationDto pagination);
        Task<IEnumerable<Workson>> GetAllWorksOnNoPagesAsync();
        Task<Workson> GetWorksOnByIdAsync(int empId, int projId);
        Task<Workson> AddWorksOnAsync(Workson worksOn);
        Task UpdateWorksOnAsync(int empId, int projId, Workson worksOn);
        Task DeleteWorksOnAsync(int empId, int projId);
        Task<Workson> GetOwnWorksonAsync();
    }

}
