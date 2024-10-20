using Agendify.Data;
using Agendify.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Agendify.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServicoController : ControllerBase
    {
        private readonly AgendifyDbContext _context;

        public ServicoController(AgendifyDbContext context, ILogger<ServicoController> logger)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Servico>>> GetServicos()
        {
            return await _context.Servicos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Servico>> GetServico(int id)
        {
            var servico = await _context.Servicos.FindAsync(id);

            if (servico == null)
            {
                return NotFound();
            }

            return servico;
        }

        [HttpPost]
        public async Task<ActionResult<Servico>> CreateServico(Servico servico)
        {
            _context.Servicos.Add(servico);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetServico), new { id = servico.Id }, servico);
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateServico(int id, Servico updatedServico)
        {

            if (id != updatedServico.Id)
            {
                return BadRequest();
            }

            var servico = await _context.Servicos.FindAsync(id);
            if (servico == null)
            {
                return NotFound();
            }

            if (updatedServico.Name != null) {
                servico.Name = updatedServico.Name;
            }
            
            if (updatedServico.Preco != null) {
                servico.Preco = updatedServico.Preco;
            }

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteServico(int id)
        {
            var servico = await _context.Servicos.FindAsync(id);
            if (servico == null)
            {
                return NotFound();
            }

            _context.Servicos.Remove(servico);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
