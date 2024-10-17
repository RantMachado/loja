namespace Loja.Application.DTOs;

public class ProdutoDto
{
  public string Produto_Id { get; set; } = string.Empty;
  public DimensaoDto Dimensoes { get; set; }
}