using Loja.Application.Mappings;
using Loja.Application.Services;
using Loja.Application.UseCases;
using Loja.Application.Interfaces.Services;
using Loja.Application.Interfaces.UseCases;
using Microsoft.Extensions.DependencyInjection;

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

    return services;
  }
}