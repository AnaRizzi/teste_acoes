using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste_investimentos_Domain.Models;
using Teste_investimentos_Domain.Services;

namespace Teste_investimentos.Controllers
{
    [ApiController]
    [Route("investimentos")]
    public class AcoesController : ControllerBase
    {
        private readonly ILogger<AcoesController> _logger;
        private readonly IAcoesService _service;

        public AcoesController(ILogger<AcoesController> logger, IAcoesService service)
        {
            _logger = logger;
            _service = service;
        }

        [Route("cadastro")]
        [HttpPost]
        public IActionResult CadastroAcoes([FromBody] NovaAcao request)
        {
            try
            {
                _service.CadastroAcoes(request);

                return Created("", request);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [Route("cotacao")]
        [HttpGet]
        public IActionResult CotacaoAcao()
        {
            try
            {
                var cotacao = _service.CotacaoAcao();

                return Ok(cotacao);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [Route("compra")]
        [HttpPost]
        public IActionResult CompraAcao([FromBody] CompraAcao request)
        {
            try
            {
                _service.CompraAcao(request);

                return Created("", request);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [Route("venda")]
        [HttpPost]
        public IActionResult VendaAcao([FromBody] VendaAcao request)
        {
            try
            {
                _service.VendaAcao(request);

                return Created("", request);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
