using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.Data;
using Server.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace Server.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly ServerContext _context;

        public ProdutosController(ServerContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Produto>> PostProduto(Produto produto)
        {
            _context.Produto.Add(produto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduto", new { id = produto.Id }, produto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduto(int id, Produto produto)
        {
            if (id != produto.Id)
            {
                return BadRequest();
            }

            _context.Entry(produto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!(_context.Produto?.Any(e => e.Id == id)).GetValueOrDefault())
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> GetProduto()
        {
            if (_context.Produto == null)
            {
                return NotFound();
            }
            return await _context.Produto.ToListAsync();
        }

        // GET: api/Produtos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Produto>> GetProduto(int id)
        {
            if (_context.Produto == null)
            {
                return NotFound();
            }
            var produto = await _context.Produto.FindAsync(id);

            if (produto == null)
            {
                return NotFound();
            }

            return produto;
        }

        // DELETE: api/Produtos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduto(int id)
        {
            if (_context.Produto == null)
            {
                return NotFound();
            }
            var produto = await _context.Produto.FindAsync(id);
            if (produto == null)
            {
                return NotFound();
            }

            _context.Produto.Remove(produto);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
