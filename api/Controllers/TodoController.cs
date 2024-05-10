using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Extensions;
using api.Models;
using api.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/todo")]
    [ApiController]
    // [Authorize]
    public class TodoController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly ITeamRepository _teamRepository;

        private readonly ITodoRepository _todoRepository;

        public TodoController(UserManager<AppUser> userManager, AppDbContext context, ITodoRepository todoRepository, ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
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

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var todo = await _todoRepository.GetByIdAsync(id);
            if (todo == null)
            {
                return NotFound();
            }
            return Ok(todo);
        }

        [HttpGet("getallbyuserid")]
        public async Task<IActionResult> GetAllByAppUserIdAsync()
        {
            var username = User.GetUsername();
            var appUser = await _userManager.FindByNameAsync(username);
            var result = await _todoRepository.GetAllByAppUserIdAsync(appUser.Id);
            return Ok(result);

        }
        [HttpGet("getallbyteamid")]
        public async Task<IActionResult> GetAllByTeamIdAsync()
        {
            var username = User.GetUsername();
            var appUser = await _userManager.FindByNameAsync(username);
            var result = await _todoRepository.GetAllByTeamIdAsync(appUser.TeamId ?? 1);

            var team = await _teamRepository.GetByIdAsync(appUser.TeamId ?? 1);

            result = result.Select(t =>
            {
                t.Team = team;
                return t;
            }).ToList();
            return Ok(result);

        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Todo todo)
        {
            // var username = User.GetUsername();
            // var appUser = await _userManager.FindByNameAsync(username);
            if (!ModelState.IsValid) return BadRequest(ModelState);
            // var stockModel = stockDto.ToStockFromCreateDTO();
            var result = await _todoRepository.CreateAsync(todo);

            return Ok(result);
        }


        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> ToggleCompleted([FromRoute] int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _todoRepository.ToggleCompleted(id);




            return Ok(result);
        }

    }
}