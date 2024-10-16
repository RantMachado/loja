using Loja.Domain.Common;
using Loja.Domain.Validation;

namespace Loja.Domain.Entities;

public class Pedido : BaseEntity
{
  public int Pedido_Id { get; private set; }
  public List<Produto> Produtos { get; private set; } = [];

  public Pedido(int pedido_id, List<Produto> produtos)
  {
    ValidateDomain(pedido_id, produtos);
    Pedido_Id = pedido_id;
    Produtos = produtos;
  }

  public static void ValidateDomain(int pedido_id, List<Produto> produtos)
  {
    DomainExceptionValidation.When(pedido_id < 0, Resources.InvalidId);

    DomainExceptionValidation.When(produtos.Count < 1, Resources.InvalidList);
  }
}