using Loja.Application.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Loja.WebApi.Controllers;

[ApiController]
[Route("Pedidos")]
public class PedidoController : ControllerBase
{
  /// <summary>
  /// Rora responsável por receber uma lista de pedidos e retornar uma lista de objetos com empacotamento de caixa correto por pedido
  /// </summary>
  /// <param name="pedidoDtos">Recebe uma lista de pedidos</param>
  /// <returns>Retorna uma lista de pedidos processados</returns>
  [HttpPost("Processar")]
  public IActionResult ProcessarPedido(
    [FromBody] List<PedidoDto> pedidoDtos) =>
    Ok();
}