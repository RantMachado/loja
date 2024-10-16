using Loja.Domain.Entities;

namespace Loja.Domain.Interfaces;

public interface IPedidoRepository
{
  Task<IEnumerable<Pedido>> GetPedidosAsync();
  Task<Pedido> CreateAsync(Pedido pedido);
}