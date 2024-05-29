using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MemorizarPalavraApi.Context;
using MemorizarPalavraApi.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MemorizarPalavraApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PalavraController : ControllerBase
    {
        private readonly PalavraContext _context;

        public PalavraController(PalavraContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(Palavra palavra)
        {
            _context.Add(palavra);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ObterPorId), new { id = palavra.Id }, palavra);
        }

        [HttpGet("obterPorId/{id}")]
        public IActionResult ObterPorId(int id)
        {
            var palavra = _context.Palavras.Find(id);

            if (palavra == null)
                return NotFound();
            
            return Ok(palavra);
        }

        [HttpGet("obterPalavraEstrangeira/{palavraEstrangeira}")]
        public IActionResult ObterPorPalavraNaLinguaEstrangeira(string palavraEstrangeira)
        {
            var palavras = _context.Palavras.Where(x => x.PalavraLinguaEstrangeira.Contains(palavraEstrangeira)) ;
            return Ok(palavras);
        }

        [HttpGet("ObterPorPalavraTraduzida/{palavraTraduzida}")]
        public IActionResult ObterPorPalavraTraduzida(string palavraTraduzida)
        {
            var palavras = _context.Palavras.Where(x => x.PalavraTraduzida.Contains(palavraTraduzida)) ;
            return Ok(palavras);
        }

        [HttpGet("ObterTodos")]
        public IActionResult ObterTodos()
        {
            var palavras = _context.Palavras;
            return Ok(palavras);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Palavra palavra)
        {
            var palavraBanco = _context.Palavras.Find(id);

            if (palavraBanco == null)
                return NotFound();

            palavraBanco.PalavraLinguaEstrangeira = palavra.PalavraLinguaEstrangeira;
            palavraBanco.PalavraTraduzida = palavra.PalavraTraduzida;

            _context.Palavras.Update(palavraBanco);
            _context.SaveChanges();

            return Ok(palavraBanco);
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var palavraBanco = _context.Palavras.Find(id);

            if (palavraBanco == null)
                return NotFound();
            
            _context.Palavras.Remove(palavraBanco);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
