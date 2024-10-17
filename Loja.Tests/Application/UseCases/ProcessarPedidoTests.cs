using Moq;
using Xunit;
using FluentAssertions;
using Loja.Tests._Helpers;
using Loja.Application.Interfaces.Services;
using Loja.Application.Interfaces.UseCases;
using Loja.Application.UseCases;
using Loja.Application.DTOs;

namespace Loja.Tests.Application.UseCases;

public class ProcessarPedidoTests : BaseTest
{
  private readonly IProcessarPedido _sut;
  private readonly Mock<IEmpacotarService> _empacotarService = new();

  public ProcessarPedidoTests()
  {
    _sut = new ProcessarPedido(_empacotarService.Object);
  }

  [Fact(DisplayName = "Given valid PedidosDto when use case ProcessarPedido is called then execute withoud errors")]
  public async Task GivenValidPedidosDto_WhenUseCaseProcessarPedidoIsCalled_ThenExecuteWithoutErrors()
  {
    _empacotarService
      .Setup(x => x.EmpacotarAsync(It.IsAny<PedidosDto>()))
      .ReturnsAsync(It.IsAny<IEnumerable<PedidoProcessadoDto>>());

    var resultado = await _sut.Processar(It.IsAny<PedidosDto>());

    resultado.Should().BeNull();
  }
}