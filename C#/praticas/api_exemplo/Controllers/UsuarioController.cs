using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using YamlDotNet.Core.Tokens;
using Newtonsoft.Json.Linq;
using System.Text.Json.Nodes;

namespace api_exemplo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObterDataHora()
        {
            var obj = new
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            };

            return Ok(obj);
        }

        [HttpGet("Apresentar/{nome}")]
        public IActionResult Apresentar(string nome)
        {

            var mensagem = $"Olá {nome}, seja bem vindo!";
            return Ok(new { mensagem });
        }

        [HttpGet("ObterEndereco/{cep}")]
        public async IAsyncEnumerable<object> ObterEndereco(string cep)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync($"https://viacep.com.br/ws/{cep}/json/");
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject(data);
                    yield return Ok(result);
                }
                else
                {
                    yield return new Exception("Erro na requisição");
                }

            }
        }

    }
}