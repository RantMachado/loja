namespace Loja.Application.DTOs;

public class ProdutoDto
{
  public Guid Id { get; set; }
  public string Produto_Id { get; set; } = string.Empty;
  public required DimensaoDto DimensoesDto { get; set; }
}

public record DimensaoDto(double Altura, double Largura, double Comprimento);