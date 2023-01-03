using Graos_API.Domain.Interfaces;
using Graos_API.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Graos_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto_tb>>> GetAll()
        {
            var produto = await _produtoRepository.Get();

            if (produto != null)
            {
                return Ok(produto);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Produto_tb>> GetOne(int id)
        {
            var produto = await _produtoRepository.Get(id);

            if (produto != null)
            {
                return Ok(produto);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<ActionResult<Produto_tb>> Post([FromBody] Produto_tb produto)
        {
            if (produto != null)
            {
                await _produtoRepository.Create(produto);

                return CreatedAtAction(nameof(GetAll), new { id = produto.ProdutoID }, produto);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public async Task<ActionResult<Produto_tb>> Put([FromBody] Produto_tb produto)
        {
            if (produto != null)
            {
                await _produtoRepository.Update(produto);

                return produto;
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var produto = await _produtoRepository.Get(id);

            if (produto == null)
            {
                return NotFound();
            }
            else
            {
                await _produtoRepository.Delete(produto.ProdutoID);
                return NoContent();
            }
        }
    }
}
