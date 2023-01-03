using Graos_API.Domain.Interfaces;
using Graos_API.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Graos_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MotoristaController : ControllerBase
    {
        private readonly IMotoristaRepository _motoristaRepository;

        public MotoristaController(IMotoristaRepository motoristaRepository)
        {
            _motoristaRepository = motoristaRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Motorista_tb>>> GetAll()
        {
            var motorista = await _motoristaRepository.Get();

            if (motorista != null)
            {
                return Ok(motorista);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Motorista_tb>> GetOne(int id)
        {
            var motorista = await _motoristaRepository.Get(id);

            if (motorista != null)
            {
                return Ok(motorista);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<ActionResult<Motorista_tb>> Post([FromBody] Motorista_tb motorista)
        {
            if (motorista != null)
            {
                await _motoristaRepository.Create(motorista);

                return CreatedAtAction(nameof(GetAll), new { id = motorista.MotoristaID }, motorista);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public async Task<ActionResult<Motorista_tb>> Put([FromBody] Motorista_tb motorista)
        {
            if (motorista != null)
            {
                await _motoristaRepository.Update(motorista);

                return motorista;
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var motorista = await _motoristaRepository.Get(id);

            if (motorista == null)
            {
                return NotFound();
            }
            else
            {
                await _motoristaRepository.Delete(motorista.MotoristaID);
                //return NoContent();
                return Ok();
            }
        }
    }
}
