using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/team")]
    [ApiController]

    public class TeamController : ControllerBase
    {
        // private readonly AppDbContext _context;

        private readonly ITeamRepository _teamRepository;

        public TeamController(AppDbContext context, ITeamRepository teamRepository)
        {
            // _context = context;
            _teamRepository = teamRepository;

        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _teamRepository.GetAllAsync();

            return Ok(result);
        }



    }
}