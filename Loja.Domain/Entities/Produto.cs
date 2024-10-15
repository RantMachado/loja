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
    DomainExceptionValidation.When(string.IsNullOrEmpty(produto_id), string.Format(Resources.PropertyNullOrEmpty, nameof(Produto_Id)));

    DomainExceptionValidation
      .When(dimensoes.Altura < 0, string.Format(Resources.ValidDimensions, nameof(dimensoes.Altura), dimensoes.Altura));

    DomainExceptionValidation
      .When(dimensoes.Largura < 0, string.Format(Resources.ValidDimensions, nameof(dimensoes.Largura), dimensoes.Largura));

    DomainExceptionValidation
      .When(dimensoes.Comprimento < 0, string.Format(Resources.ValidDimensions, nameof(dimensoes.Comprimento), dimensoes.Comprimento));
  }
}