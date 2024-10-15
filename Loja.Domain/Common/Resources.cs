namespace Loja.Domain.Common;

public static class Resources
{
  public static string InvalidId => "Id com valor inválido.";
  public static string InvalidList => "A lista de produtos não pode estar vazia.";
  public static string PropertyNullOrEmpty => $"O campo {0} não pode estar em branco.";
  public static string ValidDimensions => $"{0} deve possuir valores positivos. O valor informado é {1}.";
}