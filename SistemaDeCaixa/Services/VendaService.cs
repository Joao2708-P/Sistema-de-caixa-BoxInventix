using SistemaDeCaixa.Models;
using SistemaDeCaixa.Services;
using System;
using System.Data;

public class VendaService
{
    private readonly VendaRepository vendaRepo = new();
    private readonly VendaItemRepository itemRepo = new();

    public int IniciarVenda(int lojaId, int funcionarioId)
    {
        return vendaRepo.Criar(lojaId, funcionarioId);
    }

    public void AdicionarItem(
        int vendaId,
        int produtoId,
        int quantidade,
        decimal preco,
        decimal? pesoKg,
        decimal subtotal
    )
    {
        if (!vendaRepo.VendaExiste(vendaId))
            throw new Exception("Venda não existe");

        itemRepo.Criar(vendaId, produtoId, quantidade, preco, pesoKg, subtotal);
    }

    public void AtualizarTotais(
        int vendaId,
        decimal sub,
        decimal desconto,
        decimal total
    )
    {
        vendaRepo.AtualizarValores(vendaId, sub, desconto, total);
    }

    public void FinalizarVenda(
        int vendaId,
        string formaPagamento
    )
    {
        vendaRepo.AtualizarStatus(vendaId, "fechada", formaPagamento);
    }

    public void CancelarVenda(int vendaId)
    {
        vendaRepo.AtualizarStatus(vendaId, "cancelada", null);
    }

    public (int venda_id, List<ItemCaixa> itens) CarregarVendaAberta(int loja_id)
    {
        return vendaRepo.ObterVendaAberta(loja_id);
    }
}
