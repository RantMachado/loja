namespace Loja.Application.DTOs;

public class PedidoDto
{
  public Guid Id { get; set; }
  public int Pedido_Id { get; set; }
  List<ProdutoDto> produtoDtos { get; set; } = [];
}