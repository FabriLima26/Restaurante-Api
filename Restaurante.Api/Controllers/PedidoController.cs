using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Restaurante.Api.Model;
using Restaurante.Api.Repositories;

namespace Restaurante.Api.Controllers

{
    public class PedidoController : Controller
    {
        private readonly IPedidoRepository _repositorio;

        public PedidoController(IPedidoRepository repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet("v1/pedido")]
        public IActionResult ListarPedidos()
        {
            return Ok( _repositorio.ListarPedido() );
        }

        [HttpPost("v1/pedido")]
        public IActionResult AdicionarPedido([FromBody]Pedido pedido)
        {
            _repositorio.AdicionarPedido(pedido);
            return Ok();
        }

    }
}