using Microsoft.AspNetCore.Mvc;
using FutureOfWork.Api.Data;
using FutureOfWork.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace FutureOfWork.Api.Controllers.V2
{
    [ApiController]
    [Route("api/v2/[controller]")]
    public class WorkersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public WorkersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET com filtro opcional
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Worker>>> GetWorkers(
            [FromQuery] string? mode,
            [FromQuery] string? skill)
        {
            var query = _context.Workers.AsQueryable();

            if (!string.IsNullOrEmpty(mode))
                query = query.Where(w => w.PreferredWorkMode.Contains(mode));

            if (!string.IsNullOrEmpty(skill))
                query = query.Where(w => w.MainSkill.Contains(skill));

            return await query.ToListAsync();
        }
    }
}
