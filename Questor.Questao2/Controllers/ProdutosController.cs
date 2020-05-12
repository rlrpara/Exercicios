using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Questor.Questao2.Library.Contexto;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

            var query = from pedidoitem in pedItem
                        join pedido in ped on pedidoitem.PedidoItensId equals pedido.PedidoId
                        join cliente in cli on pedido.ClienteId equals cliente.ClienteId
                        join produto in prod on pedidoitem.ProdutoId equals produto.ProdutoId
                        select new
                        {
                            pedido.PedidoId,
                            produto.ProdutoId,
                            ProdutoNome = produto.Nome,
                            cliente.ClienteId,
                            ClienteNome = cliente.Nome,
                        };

            ViewBag.ListaProduto = query;

            return View();
        }
    }
};