namespace Loja.Application.DTOs;

public class CaixaDto
{
  public string Caixa_Id { get; set; } = string.Empty;
  public List<string> Produtos { get; set; } = [];
  public string Observacao { get; set; } = string.Empty;
}