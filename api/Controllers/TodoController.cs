using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Extensions;
using api.Models;
using api.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/todo")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        private readonly ITodoRepository _todoRepository;

        public TodoController(UserManager<AppUser> userManager, AppDbContext context, ITodoRepository todoRepository)
        {
            _userManager = userManager;
            _context = context;
            _todoRepository = todoRepository;

        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _todoRepository.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("getallbyuserid")]
        public async Task<IActionResult> GetAllByAppUserIdAsync()
        {
            var username = User.GetUsername();
            var appUser = await _userManager.FindByNameAsync(username);
            var result = await _todoRepository.GetAllByAppUserIdAsync(appUser.Id);
            return Ok(result);

        }

    }
}