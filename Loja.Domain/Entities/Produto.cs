using Loja.Domain.Common;
using Loja.Domain.ValueObjects;
using Loja.Domain.Validation;

namespace Loja.Domain.Entities;

public sealed class Produto : BaseEntity
{
  public string Produto_Id { get; private set; } = string.Empty;
  public Dimensao Dimensoes { get; private set; }

  public Produto(string produto_id, Dimensao dimensoes)
  {
    ValidateDomain(produto_id, dimensoes);
    Produto_Id = produto_id;
    Dimensoes = dimensoes;
  }

  private static void ValidateDomain(string produto_id, Dimensao dimensoes)
  {
    DomainExceptionValidation
      .When(string.IsNullOrEmpty(produto_id), Resources.PropertyNullOrEmpty);

    DomainExceptionValidation
      .When(produto_id.Length < 3, Resources.PropertyTooShortValueString);

    DomainExceptionValidation
      .When(dimensoes.Altura < 0, Resources.InvalidDimensions);

    DomainExceptionValidation
      .When(dimensoes.Largura < 0, Resources.InvalidDimensions);

    DomainExceptionValidation
      .When(dimensoes.Comprimento < 0, Resources.InvalidDimensions);
  }
}