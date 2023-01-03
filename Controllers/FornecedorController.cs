using Graos_API.Domain.Interfaces;
using Graos_API.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Graos_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FornecedorController : ControllerBase
    {
        private readonly IFornecedorRepository _fornecedorRepository;

        public FornecedorController(IFornecedorRepository fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fornecedor_tb>>> GetAll()
        {
            var fornecedor = await _fornecedorRepository.Get();

            if (fornecedor != null)
            {
                return Ok(fornecedor);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Fornecedor_tb>> GetOne(int id)
        {
            var fornecedor = await _fornecedorRepository.Get(id);

            if (fornecedor != null)
            {
                return Ok(fornecedor);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<ActionResult<Fornecedor_tb>> Post([FromBody] Fornecedor_tb fornecedor)
        {
            if (fornecedor != null)
            {
                await _fornecedorRepository.Create(fornecedor);

                return CreatedAtAction(nameof(GetAll), new { id = fornecedor.FornecedorID }, fornecedor);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public async Task<ActionResult<Fornecedor_tb>> Put([FromBody] Fornecedor_tb fornecedor)
        {
            if (fornecedor != null)
            {
                await _fornecedorRepository.Update(fornecedor);

                return fornecedor;
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var fornecedor = await _fornecedorRepository.Get(id);

            if (fornecedor == null)
            {
                return NotFound();
            }
            else
            {
                await _fornecedorRepository.Delete(fornecedor.FornecedorID);
                return NoContent();
            }
        }
    }
}
