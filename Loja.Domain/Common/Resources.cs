namespace Loja.Domain.Common;

public static class Resources
{
  public static string InvalidId => "Id com valor inválido ou negativo.";
  public static string InvalidList => "A lista não pode estar vazia.";
  public static string PropertyNullOrEmpty => "O campo não pode ser nulo.";
  public static string InvalidDimensions => "As dimensões devem possuir valores positivos.";
  public static string PropertyTooShortValueString => "Campo inválido, muito curto, mínimo de 3 caracteres.";
  public static string BoxUnavailable => "Produto não cabe em nenhuma caixa disponível.";
}