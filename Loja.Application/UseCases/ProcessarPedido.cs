using Loja.Application.DTOs;
using Loja.Application.Interfaces.UseCases;

namespace Loja.Application.UseCases;

public class ProcessarPedido : IProcessarPedido
{
  public Task<IEnumerable<PedidoProcessadoDto>> Processar(IEnumerable<PedidoDto> pedidosDto)
  {
    throw new NotImplementedException();
  }
}