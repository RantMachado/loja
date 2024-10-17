using Loja.Application.DTOs;
using Loja.Application.Interfaces.Services;
using Loja.Application.Interfaces.UseCases;

namespace Loja.Application.UseCases;

public class ProcessarPedido(IEmpacotarService empacotarService) : IProcessarPedido
{
  private readonly IEmpacotarService _empacotarService = empacotarService;

  public async Task<IEnumerable<PedidoProcessadoDto>> Processar(PedidosDto pedidosDto)
  {
    // Implementar validaçoes

    return await _empacotarService.EmpacotarAsync(pedidosDto);
  }
}