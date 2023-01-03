using Graos_API.Domain.Interfaces;
using Graos_API.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Graos_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PropriedadeController : ControllerBase
    {
        private readonly IPropriedadeRepository _propriedadeRepository;

        public PropriedadeController(IPropriedadeRepository propriedadeRepository)
        {
            _propriedadeRepository = propriedadeRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Propriedade_tb>>> GetAll()
        {
            var propriedade = await _propriedadeRepository.Get();

            if (propriedade != null)
            {
                return Ok(propriedade);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Propriedade_tb>> GetOne(int id)
        {
            var propriedade = await _propriedadeRepository.Get(id);

            if (propriedade != null)
            {
                return Ok(propriedade);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<ActionResult<Propriedade_tb>> Post([FromBody] Propriedade_tb propriedade)
        {
            if (propriedade != null)
            {
                await _propriedadeRepository.Create(propriedade);

                return CreatedAtAction(nameof(GetAll), new { id = propriedade.PropriedadeID }, propriedade);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public async Task<ActionResult<Propriedade_tb>> Put([FromBody] Propriedade_tb propriedade)
        {
            if (propriedade != null)
            {
                await _propriedadeRepository.Update(propriedade);

                return propriedade;
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var propriedade = await _propriedadeRepository.Get(id);

            if (propriedade == null)
            {
                return NotFound();
            }
            else
            {
                await _propriedadeRepository.Delete(propriedade.PropriedadeID);
                return NoContent();
            }
        }
    }
}
