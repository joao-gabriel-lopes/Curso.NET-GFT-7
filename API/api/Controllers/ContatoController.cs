using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using api.Context;
using api.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;
        public ContatoController(AgendaContext context)
        {
            _context = context;
        }

        [HttpPost("/criar")]
        public IActionResult Create(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ObterPorId), new { id = contato.Id }, contato);
        }

        [HttpPost("/criar/web/{nome}/{telefone}/{estado}")]
        public IActionResult CreateViaWeb(string nome, string telefone, string estado)
        {
            if (estado == "false" || estado == "False")
            {
                if (!string.IsNullOrWhiteSpace(nome) && !string.IsNullOrWhiteSpace(telefone) && !string.IsNullOrWhiteSpace(estado))
                {
                    Contato contato = new Contato();
                    contato.Nome = nome;
                    contato.Telefone = telefone;
                    contato.Ativo = false;

                    _context.Add(contato);
                    _context.SaveChanges();
                    return CreatedAtAction(nameof(ObterPorId), new { id = contato.Id }, contato);
                }
                else
                {
                    return NotFound("Valor inválido inserido nos parâmetros");
                }
            }
            else if (estado == "true" || estado == "True")
            {
                if (!string.IsNullOrWhiteSpace(nome) && !string.IsNullOrWhiteSpace(telefone) && !string.IsNullOrWhiteSpace(estado))
                {
                    Contato contato = new Contato();
                    contato.Nome = nome;
                    contato.Telefone = telefone;
                    contato.Ativo = true;

                    _context.Add(contato);
                    _context.SaveChanges();
                    return CreatedAtAction(nameof(ObterPorId), new { id = contato.Id }, contato);
                }
                else
                {
                    return NotFound("Valor inválido inserido nos parâmetros");
                }
            }
            else
            {
                return NotFound("Valor inválido inserido no parâmetro {estado}");
            }
        }

        [HttpGet("/obter/id/{id}")]
        public IActionResult ObterPorId(int id)
        {
            var contato = _context.Contatos.Find(id);

            if (contato == null)
            {
                return NotFound();
            }

            return Ok(contato);
        }

        [HttpGet("/obter/nome/{nome}")]
        public IActionResult ObterPorNome(string nome)
        {
            var contatos = _context.Contatos.Where(x => x.Nome.Contains(nome));

            if (contatos == null)
            {
                return NotFound();
            }

            return Ok(contatos);
        }

        [HttpGet("/obter/estado/{estado}")]
        public IActionResult ObterPorEstado(string estado)
        {
            switch (estado)
            {
                case "false":
                    var contatosf = _context.Contatos.Where(x => x.Ativo == false);
                    return Ok(contatosf);
                case "true":
                    var contatost = _context.Contatos.Where(x => x.Ativo == true);
                    return Ok(contatost);
                case "False":
                    var contatosF = _context.Contatos.Where(x => x.Ativo == false);
                    return Ok(contatosF);
                case "True":
                    var contatosT = _context.Contatos.Where(x => x.Ativo == true);
                    return Ok(contatosT);
                default:
                    return NotFound();
            }

        }

        [HttpGet("/obter/todos")]
        public IActionResult ObterTodos()
        {
            var contatos = _context.Contatos.Where(x => x.Nome != "");

            if (contatos == null)
            {
                return NotFound();
            }

            return Ok(contatos);
        }

        [HttpPut("/atualizar/{id}")]
        public IActionResult AtualizarPorId(int id, Contato contato)
        {
            var contatoBanco = _context.Contatos.Find(id);

            if (contatoBanco == null)
            {
                return NotFound();
            }

            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();

            return Ok(contatoBanco);
        }

        [HttpPatch("/modificar/nome/{id}")]
        public IActionResult ModificarId(int id, Contato contato)
        {
            var contatoBanco = _context.Contatos.Find(id);

            if (contatoBanco == null)
            {
                return NotFound();
            }

            contatoBanco.Nome = contato.Nome;

            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();

            return Ok(contatoBanco);
        }

        [HttpPatch("/modificar/telefone/{id}")]
        public IActionResult ModificarTelefone(int id, Contato contato)
        {
            var contatoBanco = _context.Contatos.Find(id);

            if (contatoBanco == null)
            {
                return NotFound();
            }

            contatoBanco.Telefone = contato.Telefone;

            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();

            return Ok(contatoBanco);
        }

        [HttpPatch("/modificar/estado/{id}")]
        public IActionResult ModificarEstado(int id, Contato contato)
        {
            var contatoBanco = _context.Contatos.Find(id);

            if (contatoBanco == null)
            {
                return NotFound();
            }

            if (contato.Ativo == false || contato.Ativo == true)
            {
                contatoBanco.Ativo = contato.Ativo;

                _context.Contatos.Update(contatoBanco);
                _context.SaveChanges();

                return Ok(contatoBanco);
            }
            else
            {
                return NotFound("Valor inválido inserido no parâmetro");
            }

        }

        [HttpDelete("/deletar/id/{id}")]
        public IActionResult DeletarPorId(int id)
        {
            var contatoBanco = _context.Contatos.Find(id);

            if (contatoBanco == null)
            {
                return NotFound();
            }

            _context.Contatos.Remove(contatoBanco);
            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete("/deletar/nome/{nome}")]
        public IActionResult DeletarPorNome(string nome)
        {
            var contatoBanco = _context.Contatos.Where(x => x.Nome.Contains(nome));

            if (contatoBanco == null)
            {
                return NotFound();
            }

            _context.Contatos.RemoveRange(contatoBanco);
            _context.SaveChanges();

            return Ok();
        }
    }
}