using Loja.Application.DTOs;
using FluentValidation;
using Loja.Domain.Common;

namespace Loja.Application.Validators
{
  public class PedidosDtoValidator : AbstractValidator<PedidosDto>
  {
    public PedidosDtoValidator()
    {
      RuleFor(x => x.Pedidos)
        .NotNull()
        .WithMessage(Resources.InvalidList);
    }
  }
}