using Loja.Application.DTOs;
using Loja.Application.Interfaces.Services;
using Loja.Domain.ValueObjects;
using Loja.Domain.Common;

namespace Loja.Application.Services;

public class EmpacotarService : IEmpacotarService
{
  public async Task<IEnumerable<PedidoProcessadoDto>> EmpacotarAsync(PedidosDto pedidosDto)
  {
    var pedidosProcessados = new List<PedidoProcessadoDto>();

    foreach (var pedido in pedidosDto.Pedidos)
    {
      pedidosProcessados.Add(
        new()
        {
          Pedido_Id = pedido.Pedido_Id,
          Caixas = SepararProdutosPorCaixa(pedido.Produtos)
        }
      );
    }

    return pedidosProcessados;
  }

  private static List<CaixaDto> SepararProdutosPorCaixa(List<ProdutoDto> produtos)
  {
    var caixasSelecionadas = new List<CaixaDto>();

    foreach (var produto in produtos)
    {
      var caixaSelecionada = ColocarProdutoCaixa(produto);

      var existeCaixa = caixasSelecionadas.Find(x => x.Caixa_Id == caixaSelecionada.Caixa_Id);

      if (existeCaixa is null)
        caixasSelecionadas.Add(caixaSelecionada);
      else
        existeCaixa.Produtos.Add(produto.Produto_Id);
    }

    return caixasSelecionadas;
  }

  private static CaixaDto ColocarProdutoCaixa(ProdutoDto produto)
  {
    var (caixinha, caixa, caixao) = MontarCaixas();
    var caixaSelecionada = new CaixaDto();

    if (
      produto.Dimensoes.Altura <= caixinha.Altura &&
      produto.Dimensoes.Largura <= caixinha.Largura &&
      produto.Dimensoes.Comprimento <= caixinha.Comprimento
    )
    {
      caixaSelecionada.Caixa_Id = caixinha.Caixa_Id;
      caixaSelecionada.Produtos.Add(produto.Produto_Id);

      return caixaSelecionada;
    }

    if (
      produto.Dimensoes.Altura <= caixa.Altura &&
      produto.Dimensoes.Largura <= caixa.Largura &&
      produto.Dimensoes.Comprimento <= caixa.Comprimento
    )
    {
      caixaSelecionada.Caixa_Id = caixa.Caixa_Id;
      caixaSelecionada.Produtos.Add(produto.Produto_Id);

      return caixaSelecionada;
    }

    if (
      produto.Dimensoes.Altura <= caixao.Altura &&
      produto.Dimensoes.Largura <= caixao.Largura &&
      produto.Dimensoes.Comprimento <= caixao.Comprimento
    )
    {
      caixaSelecionada.Caixa_Id = caixao.Caixa_Id;
      caixaSelecionada.Produtos.Add(produto.Produto_Id);

      return caixaSelecionada;
    }

    caixaSelecionada.Caixa_Id = string.Empty;
    caixaSelecionada.Produtos.Add(produto.Produto_Id);
    caixaSelecionada.Observacao = Resources.BoxUnavailable;

    return caixaSelecionada;
  }

  private static (Caixa, Caixa, Caixa) MontarCaixas() => (
      new("Caixa 1", 30, 40, 80),
      new("Caixa 2", 80, 50, 40),
      new("Caixa 3", 50, 80, 60));
}