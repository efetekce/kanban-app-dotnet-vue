using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace api.Repositories
{
    public interface ITodoRepository
    {
        Task<List<Todo>> GetAllAsync();
        Task<List<Todo>> GetAllByTeamIdAsync(int teamId);
        Task<List<Todo>> GetAllByAppUserIdAsync(string appUserId);
    }
}