using FluentValidation;
using Loja.Application.DTOs;
using Loja.Application.Interfaces.Services;
using Loja.Application.Interfaces.UseCases;
using Loja.Application.Validators;

namespace Loja.Application.UseCases;

public class ProcessarPedido(IEmpacotarService empacotarService) : IProcessarPedido
{
  private readonly IValidator<PedidosDto> _validator = new PedidosDtoValidator();
  private readonly IEmpacotarService _empacotarService = empacotarService;

  public async Task<IEnumerable<PedidoProcessadoDto>> ProcessarAsync(PedidosDto pedidosDto)
  {
    _validator.Validate(pedidosDto);

    return await _empacotarService.EmpacotarAsync(pedidosDto);
  }
}