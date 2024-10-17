using Loja.Application.DTOs;

namespace Loja.Application.Interfaces.UseCases;

public interface IProcessarPedido
{
  Task<IEnumerable<PedidoProcessadoDto>> ProcessarAsync(PedidosDto pedidosDto);
}