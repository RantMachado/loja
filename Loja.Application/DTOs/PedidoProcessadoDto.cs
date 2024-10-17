namespace Loja.Application.DTOs;

public class PedidoProcessadoDto
{
  public long Pedido_Id { get; set; }
  public List<CaixaDto> Caixas { get; set; } = [];
}