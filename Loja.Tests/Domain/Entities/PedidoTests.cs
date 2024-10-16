using Xunit;
using FluentAssertions;
using AutoFixture;
using Loja.Domain.Common;
using Loja.Domain.Entities;
using Loja.Domain.Validation;
using Loja.Tests._Helpers;

namespace Loja.Tests.Domain.Entities;

public class PedidoTests : BaseTest
{
  [Fact(DisplayName = "Create Pedido - With Invalid id")]
  public void WhenCreatePedido_WithInvalidId_ThrowDomainExceptionInvalidId()
  {
    var produtos = SetupProdutos(_fixture, 3);

    Action action = () => SetupPedido(int.MinValue, produtos);

    action.Should()
          .Throw<DomainExceptionValidation>()
          .WithMessage(Resources.InvalidId);
  }

  [Fact(DisplayName = "Create Pedido - With list of products null")]
  public void WhenCreatePedido_WithNullListProdutos_ThrowDomainExceptionInvalidList()
  {
    var produtos = SetupProdutos(_fixture);

    Action action = () => SetupPedido(int.MaxValue, produtos);

    action.Should()
          .Throw<DomainExceptionValidation>()
          .WithMessage(Resources.InvalidList);
  }

  [Fact(DisplayName = "Create Pedido - With Valid Values")]
  public void WhenCreatePedido_WithValidValues_DontThrowException()
  {
    var produtos = SetupProdutos(_fixture, 3);

    Action action = () => SetupPedido(int.MaxValue, produtos);

    action.Should().NotThrow<DomainExceptionValidation>();
    action.Should().NotBeNull();
  }

  private static List<Produto> SetupProdutos(Fixture _fixture, int quantidade = 0) =>
    _fixture.CreateMany<Produto>(quantidade).ToList();

  private static Pedido SetupPedido(int product_id, List<Produto> produtos) =>
    new(product_id, produtos);
}