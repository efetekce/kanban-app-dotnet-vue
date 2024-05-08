using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repositories
{
    public class TodoRepository : ITodoRepository
    {

        private readonly AppDbContext _context;
        public TodoRepository(AppDbContext context)
        {
            _context = context;
        }

        public  Task<List<Todo>> GetAllAsync()
        {
            return  _context.Todos.ToListAsync();
        }

        public Task<List<Todo>> GetAllByAppUserIdAsync(string appUserId)
        {
            return _context.Todos.Where(t => t.AppUserId == appUserId).ToListAsync();
        }

        public Task<List<Todo>> GetAllByTeamIdAsync(int teamId)
        {
            return _context.Todos.Where(t => t.TeamId == teamId).ToListAsync();
        }
    }
}