namespace Loja.Application.DTOs;

public class PedidoDto
{
  public int Pedido_Id { get; set; }
  public List<ProdutoDto> Produtos { get; set; } = [];
}