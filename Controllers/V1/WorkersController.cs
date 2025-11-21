using Microsoft.AspNetCore.Mvc;
using FutureOfWork.Api.Data;
using FutureOfWork.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace FutureOfWork.Api.Controllers.V1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class WorkersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public WorkersController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Worker>>> GetWorkers()
        {
            return await _context.Workers.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Worker>> GetWorker(int id)
        {
            var worker = await _context.Workers.FindAsync(id);

            if (worker == null)
                return NotFound();

            return worker;
        }

        [HttpPost]
        public async Task<ActionResult<Worker>> CreateWorker(Worker worker)
        {
            _context.Workers.Add(worker);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetWorker), new { id = worker.Id }, worker);
        }

        [HttpPut("{id}")]
public async Task<IActionResult> UpdateWorker(int id, Worker worker)
{
    if (id != worker.Id)
        return BadRequest();

    var existingWorker = await _context.Workers.FindAsync(id);

    if (existingWorker == null)
        return NotFound();  // <-- CORREÇÃO IMPORTANTE

    existingWorker.Name = worker.Name;
    existingWorker.Email = worker.Email;
    existingWorker.MainSkill = worker.MainSkill;
    existingWorker.PreferredWorkMode = worker.PreferredWorkMode;
    existingWorker.YearsOfExperience = worker.YearsOfExperience;

    await _context.SaveChangesAsync();

    return NoContent();
}


    [HttpDelete("{id}")]
public async Task<IActionResult> DeleteWorker(int id)
{
    var worker = await _context.Workers.FindAsync(id);

    if (worker == null)
        return NotFound();  // <-- evita erro 500

    _context.Workers.Remove(worker);
    await _context.SaveChangesAsync();

    return NoContent();
}

    }
}
