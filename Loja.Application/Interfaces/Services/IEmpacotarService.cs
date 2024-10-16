using Loja.Application.DTOs;

namespace Loja.Application.Interfaces.Services;

public interface IEmpacotarService
{
  Task<IEnumerable<PedidoProcessadoDto>> Empacotar(IEnumerable<PedidoDto> pedidosDtos);
}