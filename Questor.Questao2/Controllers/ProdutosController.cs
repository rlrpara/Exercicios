using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Questor.Questao2.Library.Contexto;

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
            return View(await _questorContext.Produtos.ToListAsync());
        }
    }
}