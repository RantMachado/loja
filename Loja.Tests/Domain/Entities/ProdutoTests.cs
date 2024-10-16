using Xunit;
using FluentAssertions;
using AutoFixture;
using Loja.Domain.Common;
using Loja.Domain.Entities;
using Loja.Domain.Validation;
using Loja.Domain.ValueObjects;
using Loja.Tests._Helpers;

namespace Loja.Tests.Domain.Entities;

public class ProdutoTests : BaseTest
{
  [Fact(DisplayName = "Create Produto - with string empty value on product_id")]
  public void WhenCreateProduto_WithStringEmptyProductId_ThrowDomainExceptionPropertyNullOrEmpty()
  {
    var dimensao = _fixture.Create<Dimensao>();

    Action action = () => SetupProduto(string.Empty, dimensao);

    action.Should()
        .Throw<DomainExceptionValidation>()
        .WithMessage(Resources.PropertyNullOrEmpty);
  }

  [Fact(DisplayName = "Create produto - with too short value on product_id ")]
  public void WhenCreateProduto_WithShortProductIdValue_ThrowDomainExceptionPropertyTooShortValueString()
  {
    var dimensao = _fixture.Create<Dimensao>();

    Action action = () => SetupProduto("Ps", _fixture.Create<Dimensao>());

    action.Should()
            .Throw<DomainExceptionValidation>()
            .WithMessage(Resources.PropertyTooShortValueString);
  }

  [Theory(DisplayName = "Create Produto - with negative values for dimensao")]
  [InlineData(int.MinValue, int.MaxValue, int.MaxValue)]
  [InlineData(int.MaxValue, int.MinValue, int.MaxValue)]
  [InlineData(int.MaxValue, int.MaxValue, int.MinValue)]
  public void WhenCreateProduto_WithNegativeValuesForDimensao_ThrowDomainExceptionInvalidDimensions(int largura, int altura, int comprimento)
  {
    var dimensao = _fixture.Build<Dimensao>()
                      .With(x => x.Largura, largura)
                      .With(x => x.Altura, altura)
                      .With(x => x.Comprimento, comprimento)
                      .Create();

    Action action = () => SetupProduto("Ps5", dimensao);

    action.Should()
        .Throw<DomainExceptionValidation>()
        .WithMessage(Resources.InvalidDimensions);
  }

  [Fact(DisplayName = "Create Produto - with valid values")]
  public void WhenCreateProduto_WithValidValues_DontThrowException()
  {
    var dimensao = _fixture.Create<Dimensao>();

    var produto = SetupProduto("Ps5", dimensao);

    Action action = () => SetupProduto("Ps5", dimensao);

    action.Should().NotThrow<DomainExceptionValidation>();
    Assert.Equal("Ps5", produto.Produto_Id);
  }

  private static Produto SetupProduto(string name, Dimensao dimensao) =>
    new(name, dimensao);
}