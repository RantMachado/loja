using AutoMapper;
using Loja.Application.DTOs;
using Loja.Domain.Entities;
using Loja.Domain.ValueObjects;

namespace Loja.Application.Mappings;

public class DomainToDTOMappingProfile : Profile
{
  public DomainToDTOMappingProfile()
  {
    CreateMap<Pedido, PedidoDto>().ReverseMap();
    CreateMap<Produto, ProdutoDto>().ReverseMap();
    CreateMap<Dimensao, DimensaoDto>().ReverseMap();
    CreateMap<Caixa, CaixaDto>().ReverseMap();
  }
}
