using Loja.Application.DTOs;
using Loja.Application.Interfaces.Services;

namespace Loja.Application.Services;

public class EmpacotarService : IEmpacotarService
{
  public Task<IEnumerable<PedidoProcessadoDto>> Empacotar(IEnumerable<PedidoDto> pedidosDtos)
  {
    throw new NotImplementedException();
  }
}