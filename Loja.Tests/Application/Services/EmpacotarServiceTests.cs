using Moq;
using Xunit;
using Loja.Tests._Helpers;
using Loja.Application.Interfaces.Services;
using Loja.Application.Services;
using Loja.Application.DTOs;
using FluentAssertions;
using AutoFixture;

namespace Loja.Tests.Application.Services;

public class EmpacotarServiceTests : BaseTest
{
  private readonly IEmpacotarService _sut = new EmpacotarService();

  [Fact(DisplayName = "Given valid PedidosDto when use case EmpacotarAsync is called then execute withoud errors")]
  public async Task GivenValidPedidosDto_WhenServiceEmpacotarIsCalled_ThenExecute_WithoudErrors()
  {
    var pedidosDto = _fixture.Create<PedidosDto>();

    var resultado = await _sut.EmpacotarAsync(pedidosDto);

    resultado.Should().NotBeNull();
  }
}