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
        Task<Todo?> GetByIdAsync(int id);

        Task<List<Todo>> GetAllByTeamIdAsync(int teamId);
        Task<Todo> CreateAsync(Todo todo);

        Task<Todo?> ToggleCompleted(int id, Todo todo);
        Task<List<Todo>> GetAllByAppUserIdAsync(string appUserId);
    }
}