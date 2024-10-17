using Loja.Application.DTOs;
using Loja.Application.Interfaces.UseCases;
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
  public async Task<IActionResult> ProcessarPedido(
    [FromBody] PedidosDto pedidosDtos,
    [FromServices] IProcessarPedido service) =>
    Ok(await service.ProcessarAsync(pedidosDtos));
}