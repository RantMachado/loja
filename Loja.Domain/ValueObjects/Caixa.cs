namespace Loja.Domain.ValueObjects;

public struct Caixa(string caixa_Id, double altura, double largura, double comprimento)
{
  public string Caixa_Id { get; private set; } = caixa_Id;
  public double Altura { get; private set; } = altura;
  public double Largura { get; private set; } = largura;
  public double Comprimento { get; private set; } = comprimento;

  public readonly double Volume() =>
    Altura * Largura * Comprimento;
}