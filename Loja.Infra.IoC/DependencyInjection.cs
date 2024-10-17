using Loja.Application.Mappings;
using Loja.Application.Services;
using Loja.Application.UseCases;
using Loja.Application.Interfaces.Services;
using Loja.Application.Interfaces.UseCases;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Loja.Application.DTOs;
using Loja.Application.Validators;

namespace Loja.Infra.IoC;

public static class DependencyInjection
{
  public static IServiceCollection AddInfrastructure(this IServiceCollection services)
  {
    #region Mapper
    services.AddAutoMapper(typeof(DomainToDTOMappingProfile));
    #endregion

    #region Services
    services.AddScoped<IEmpacotarService, EmpacotarService>();
    #endregion

    #region Use Cases
    services.AddScoped<IProcessarPedido, ProcessarPedido>();
    #endregion

    #region Validacoes
    services.AddScoped<IValidator<PedidosDto>, PedidosDtoValidator>();
    #endregion

    return services;
  }
}