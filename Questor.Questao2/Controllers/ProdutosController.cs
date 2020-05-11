using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Questor.Questao2.Library.Contexto;
using Questor.Questao2.Library.Domain.Entities;

namespace Questor.Questao2.Controllers
{
    public class ProdutosController : Controller
    {
        public readonly QuestorContext _questorContext;
        public ProdutosController(QuestorContext questorContext)
        {
            _questorContext = questorContext;
        }
        public async Task<IActionResult> Index()
        {
            var prod = await _questorContext.Produtos.ToListAsync();
            var cli = await _questorContext.Clientes.ToListAsync();
            var ped = await _questorContext.Pedidos.ToListAsync();
            var pedItem = await _questorContext.PedidoItens.ToListAsync();

            var result = prod
                .Join(pedItem,
                    produto => produto.ProdutoId,
                    pedidoitem => pedidoitem.ProdutoId,
                    (produto, pedidoitem) => new { prod = produto, pedItem = pedidoitem })
                .Join(ped,
                    pedidoitem => pedidoitem.pedItem.ProdutoId,
                    pedido => pedido.PedidoId,
                    (pedidoitem, pedido) => new { pedItem = pedidoitem, ped = pedido })
                .Join(cli,
                    pedido => pedido.ped.ClienteId,
                    cliente => cliente.ClienteId,
                    (pedido, cliente) => new { ped = pedido, cli = cliente })
                .Select(x => new
                {
                    x.
                });

            return View();
        }
    }
};