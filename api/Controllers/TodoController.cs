using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/todo")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly AppDbContext _context;

        private readonly ITodoRepository _todoRepository;

        public TodoController(AppDbContext context, ITodoRepository todoRepository)
        {
            _context = context;
            _todoRepository = todoRepository;

        }

        [HttpGet("{appUserId:string}")]
        public async Task<IActionResult> GetAllByAppUserIdAsync([FromRoute] string appUserId)
        {
            var result = await _todoRepository.GetAllByAppUserIdAsync(appUserId);
            return Ok(result);

        }

    }
}